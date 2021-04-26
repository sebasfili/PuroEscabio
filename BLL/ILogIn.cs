using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface ILogIn
    {
        Usuario ObtenerLoginIn(Usuario user);
        Usuario RegistrarUsuario(Usuario user);
        bool ValidarSesion(Usuario user);        
        bool BorrarUsuario(Usuario user);
        Usuario ModificarUsuario(Usuario user);
    }
}
