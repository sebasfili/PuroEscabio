using BE;
using BE.Interface;
using DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class SeguridadBLL : ISeguridad
    {
        public bool BorrarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public bool CrearBackUpBD(string DBName, string targetPath)
        {
            var seguridad = new SeguridadDAL();
            return seguridad.BackupDatabase(DBName, targetPath);

        }

        public List<BitacoraBE> ObtenerBitacoraCompleta()
        {
            var seguridad = new SeguridadDAL();
            return seguridad.ObtenerBitacoraCompleta();
        }

        public void CrearBitacora(UsuarioBE user, string action)
        {
            var seguridad = new SeguridadDAL();
            seguridad.CrearBitacora(user, action);

        }

        public string EncriptarClaveDeUsuario(string password)
        {
            var ASCIIPassword = Encoding.ASCII.GetBytes(password);
            var hashedPassword = SHA256.Create().ComputeHash(ASCIIPassword);

            return Encoding.ASCII.GetString(hashedPassword);
        }

        public void RecalcularDigitoVerificadorHorizontalTodos()
        {
            var seguridad = new SeguridadDAL();
            seguridad.RecalcularDigitoVerificadorHorizontalTodos();
        }

        public void RecalcularDigitoVerificadorVerticalTodos()
        {
            throw new NotImplementedException();
        }

        public string GenerarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public List<BackUp> ObtenerBackUps(string path)
        {
            var seguridad = new SeguridadDAL();
            return seguridad.ObtenerBackUps(path);
        }

        public List<RolPatenteBE> ObtenerPermisosDeUsuario(UsuarioBE user)
        {
            var permisos = new DAL.SeguridadDAL();

            var rolPatenteResultados = permisos.ObtenerPermisosDeUsuario(user);


            return rolPatenteResultados;
        }

        public string RenovarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public bool RestoreBD(BackUp backUpSelected)
        {
            var seguridad = new SeguridadDAL();
            return seguridad.RestoreDataBase(backUpSelected.BackUpPath, "PuroEscabio", backUpSelected.NombreBD);
        }

        public Integridad ValidarIntegridadDeAplicacion()
        {
            var seguridad = new SeguridadDAL();
            var integridad = new Integridad();

            #region Validación Hash Usuario
            var usuarioHash = seguridad.ObtenerHashUsuarioParaValidarIntegridad();

            foreach (UsuarioBE usuario in usuarioHash)
            {
                var reHash = seguridad.GenerarHash(usuario.NombreDeUsuario, usuario.Password, usuario.PerfilDeUsuario.Id.ToString());

                if (!(string.Compare(reHash, usuario.DigVerificador) == 0))
                {
                    integridad.Usuarios.Add(usuario);
                }
            }
            #endregion

            #region Validación Hash Producto

            var bebidaHash = seguridad.ObtenerHashProductoParaValidarIntegridad();

            foreach (BebidasBE producto in bebidaHash)
            {
                var reHash = seguridad.GenerarHash(producto.Descripcion, producto.SKU, producto.Precio.ToString());

                if (!(string.Compare(reHash, producto.DigVerificador) == 0))
                {
                    integridad.Bebidas.Add(producto);
                }
            }
            #endregion

            return integridad;
        }
    }
}
