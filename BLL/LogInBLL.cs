using BE;
using BE.Interface;
using DAL;
using System;

namespace BLL
{
    public class LogInBLL : ILogIn
    {
        public LogInBLL()
        {
            //descomentar para probar el singleton de sql connection
            //var a = DBRepository.Instance;

        }
        public bool BorrarUsuario(UsuarioBE user)
        {
            throw new NotImplementedException();
        }

        public UsuarioBE ModificarUsuario(UsuarioBE user)
        {
            throw new NotImplementedException();
        }

        public UsuarioBE ObtenerLoginIn(UsuarioBE user)
        {
            var logIn = new DAL.LogInDAL();
            return logIn.ObtenerLogIn(user);

        }

        public UsuarioBE RegistrarUsuario(UsuarioBE user, PersonaBE person)
        {
            var registrarDAL = new LogInDAL();
            return registrarDAL.RegistrarUsuario(user, person);            
        }

        public bool ValidarSesion(UsuarioBE user)
        {
            throw new NotImplementedException();
        }
    }
}
