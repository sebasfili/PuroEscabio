using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DAL
{
    public class SeguridadDAL
    {
        public List<RolPatenteBE> ObtenerPermisosDeUsuario(UsuarioBE user)
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var rolUsuario = (from usuario in dbContext.Usuarios
                                  where usuario.Usuario1.ToLower().Trim() == user.NombreDeUsuario.ToLower().Trim()
                                   && string.Compare(usuario.Contraseña, user.Password) == 0
                                  select usuario.Rol).FirstOrDefault();

                var rolPatenteResultado = from rolPatente in dbContext.RolPatentes
                                          where rolPatente.Id_rol == rolUsuario.Id
                                          join patente in dbContext.Patentes on rolPatente.Id_patente equals patente.Id
                                          select new RolPatenteBE
                                          {
                                              IdPatente = patente.Id,
                                              DescripcionPatente = patente.Descripcion,
                                              Rol = rolUsuario.Descripcion
                                          };

                return rolPatenteResultado.ToList();
            }
        }


        public List<BitacoraBE> ObtenerBitacoraCompleta()
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var bitacora = (from bt in dbContext.Bitacoras
                                select new BitacoraBE
                                {
                                    Descripcion = bt.Descripcion,
                                    FechaFin = bt.Fecha_fin,
                                    FechaInicio = bt.Fecha_inicio,
                                    Id = bt.Id,
                                    Usuario_id = bt.Usuario_id
                                }).ToList();

                return bitacora;

            }
        }

        public void RecalcularDigitoVerificadorHorizontalTodos()
        {
            using (var dbContext = new PuroEscabioDataContext())
            {                
                var rowsToHash = (from hash in dbContext.Usuarios select hash).ToList();

                foreach (var row in rowsToHash)
                {
                    string fila = string.Format("{0}{1}{0}", row.Usuario1, row.Contraseña, row.Id_rol);
                    var hashedData = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(fila));
                    var hash = BitConverter.ToString(hashedData).Replace("-", "").ToLower();

                    row.Dig_ver_h = hash;

                }

                dbContext.SubmitChanges();
            }
        }

        public void CrearBitacora(UsuarioBE user, string action)
        {
            using (var dbContext = new PuroEscabioDataContext())
            {
                var bitacora = new Bitacora()
                {
                    Descripcion = string.Format("{0}. Usuario: {1}. Rol: {2}", action, user.NombreDeUsuario, user.PerfilDeUsuario.Descripcion),
                    Fecha_fin = null,
                    Fecha_inicio = DateTime.Now,
                    Usuario_id = user.Id,

                };

                dbContext.Bitacoras.InsertOnSubmit(bitacora);
                dbContext.SubmitChanges();
            }
        }
    }
}
