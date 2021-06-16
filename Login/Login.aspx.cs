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

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            var logIn = new LogIn();
            var usuario = new UsuarioBE();
            usuario.Password = txtPassword.Text;
            usuario.NombreDeUsuario = txtUsuario.Text;

            UsuarioBE usuarioActual = logIn.ObtenerLoginIn(usuario);
            Session["UsuarioLogueado"] = usuarioActual;

            Response.Redirect("/Default.aspx");
        }
    }
}