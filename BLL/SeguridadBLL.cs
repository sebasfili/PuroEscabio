using BE;
using BE.Interface;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class SeguridadBLL : ISeguridad
    {
        public bool BorrarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public bool CrearBackUpBD(string BDName)
        {
            throw new System.NotImplementedException();
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
            var hashedPassword = System.Security.Cryptography.SHA256.Create().ComputeHash(ASCIIPassword);
            
            return Encoding.ASCII.GetString(hashedPassword);
        }

        public bool GenerarDigitoVerificadorHorizontal()
        {
            throw new System.NotImplementedException();
        }

        public bool GenerarDigitoVerificadorVertical()
        {
            throw new System.NotImplementedException();
        }

        public string GenerarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public List<string> ObtenerBackUps()
        {
            throw new System.NotImplementedException();
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

        public bool RestoreBD(string BDName)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidarIntegridadDeAplicacion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }
    }
}
