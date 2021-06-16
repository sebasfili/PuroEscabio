using BE;
using BE.Interface;
using DAL;
using System;

namespace BLL
{
    public class LogIn : ILogIn
    {
        public LogIn()
        {
            //descomentar para probar el singleton de sql connection
            //var a = DBRepository.Instance;
            
        }
        public bool BorrarUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Usuario ModificarUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerLoginIn(Usuario user)
        {
            var logIn = new DAL.LogIn();
            return logIn.ObtenerLogIn(user);

        }

        public Usuario RegistrarUsuario(Usuario user)
        {
            throw new NotImplementedException();
        }

        public bool ValidarSesion(Usuario user)
        {
            throw new NotImplementedException();
        }
    }
}
