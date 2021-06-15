using BE;
using BE.Composite;
using BE.Interface;
using System.Collections.Generic;

namespace BLL
{
    public class Seguridad : ISeguridad
    {
        public bool BorrarTokenDeSesion(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public bool CrearBackUpBD(string BDName)
        {
            throw new System.NotImplementedException();
        }

        public void CrearBitacora(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public string EncriptarClaveDeUsuario(string password)
        {
            throw new System.NotImplementedException();
        }

        public bool GenerarDigitoVerificadorHorizontal()
        {
            throw new System.NotImplementedException();
        }

        public bool GenerarDigitoVerificadorVertical()
        {
            throw new System.NotImplementedException();
        }

        public string GenerarTokenDeSesion(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public List<string> ObtenerBackUps()
        {
            throw new System.NotImplementedException();
        }

        public List<PermisoComponent> ObtenerPermisosDeUsuario(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public string RenovarTokenDeSesion(Usuario user)
        {
            throw new System.NotImplementedException();
        }

        public bool RestoreBD(string BDName)
        {
            throw new System.NotImplementedException();
        }

        public bool ValidarIntegridadDeAplicacion(Usuario user)
        {
            throw new System.NotImplementedException();
        }
    }
}
