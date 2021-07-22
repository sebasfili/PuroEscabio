using BE;
using System.Data.Common;
using System.Data.Linq;
using System.Linq;
using System.Transactions;

namespace DAL
{
    public class LogInDAL
    {
        public UsuarioBE ObtenerLogIn(UsuarioBE user)
        {
            /*generar un linq a la base para obtener el usuario con rol y cargarlo en la sesion
             Obtener las patentes
            */
            using (var dbContext = new PuroEscabioDataContext())
            {
                var resultado = (from usuario in dbContext.Usuarios
                                 where usuario.Usuario1.ToLower().Trim() == user.NombreDeUsuario.ToLower().Trim()
                                  && string.Compare(usuario.Contraseña, user.Password) == 0
                                 select usuario).FirstOrDefault();

                if (resultado != null)
                {
                    var usuarioActual = new UsuarioBE()
                    {
                        Id = resultado.Id,
                        NombreDeUsuario = resultado.Usuario1,
                        Password = resultado.Contraseña,
                        PerfilDeUsuario = new PerfilBE()
                        {
                            Descripcion = resultado.Rol.Descripcion,
                            Id = resultado.Rol.Id
                        }
                    };

                    return usuarioActual;
                }
                else
                {
                    return null;
                }
            }

        }

        public UsuarioBE RegistrarUsuario(UsuarioBE user, PersonaBE person)
        {
            using (var transaction = new TransactionScope())
            {
                using (var dbContext = new PuroEscabioDataContext())
                {

                    var usuario = new Usuario()
                    {
                        Contraseña = user.Password,
                        Id_rol = user.PerfilDeUsuario.Id,
                        Usuario1 = user.NombreDeUsuario,
                        Dig_ver_h = user.DigVerificador,
                        Habilitado = true
                    };

                    var persona = new Persona()
                    {
                        Apellido = person.Apellido,
                        Nombre = person.Nombre,
                        Direccion = person.Direccion,
                        DNI = person.DNI,
                        Provincia_estado = person.ProvinciaEstado,
                        Pais_id = person.PaisID
                    };

                    dbContext.Personas.InsertOnSubmit(persona);

                    dbContext.SubmitChanges();
                    usuario.Persona_id = persona.Id;
                    dbContext.Usuarios.InsertOnSubmit(usuario);

                    dbContext.SubmitChanges();
                    transaction.Complete();

                    user.Id = usuario.Id;
                    return user;
                }
            }

        }
    }
}
