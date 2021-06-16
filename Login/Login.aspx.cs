using BE;
using BLL;
using System;

namespace PuroEscabio.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            var logIn = new LogIn();
            var usuario = new Usuario();
            usuario.Password = txtPassword.Text;
            usuario.NombreDeUsuario = txtUsuario.Text;

            Usuario usuarioActual = logIn.ObtenerLoginIn(usuario);
        }
    }
}