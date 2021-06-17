using BE;
using BE.Composite;
using BE.Interface;
using System.Collections.Generic;

namespace BLL
{
    public class Seguridad : ISeguridad
    {
        public bool BorrarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public bool CrearBackUpBD(string BDName)
        {
            throw new System.NotImplementedException();
        }

        public void CrearBitacora(UsuarioBE user)
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

        public string GenerarTokenDeSesion(UsuarioBE user)
        {
            throw new System.NotImplementedException();
        }

        public List<string> ObtenerBackUps()
        {
            throw new System.NotImplementedException();
        }

        public List<PermisoComponent> ObtenerPermisosDeUsuario(UsuarioBE user)
        {
            var permisos = new DAL.Seguridad();

            var rolPatenteResultados = permisos.ObtenerPermisosDeUsuario(user);
            var flia = new FamiliaComposite(rolPatenteResultados[0].Rol);

            foreach (var rolPatente in rolPatenteResultados)
            {
                var patente = new PatenteLeaf(rolPatente.DescripcionPatente);
                flia.Agregar(patente);

            }

            return flia.PermisoComponents();
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
