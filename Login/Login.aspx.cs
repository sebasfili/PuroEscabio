using BE;
using BLL;
using System;
using System.Text;
using System.Web;
using System.Web.Security;

namespace PuroEscabio.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            var logIn = new LogInBLL();
            var seguridad = new SeguridadBLL();

            var usuario = new UsuarioBE()
            {
                Password = seguridad.EncriptarClaveDeUsuario(txtPassword.Text),
                NombreDeUsuario = txtUsuario.Text
            };

            UsuarioBE usuarioActual = logIn.ObtenerLoginIn(usuario);

            if (usuarioActual != null)
            {

                seguridad.CrearBitacora(usuarioActual, "Ingresó");
                Session["UsuarioLogueado"] = usuarioActual;

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, txtUsuario.Text, DateTime.Now, DateTime.Now.AddMinutes(2880), false, usuarioActual.PerfilDeUsuario.Descripcion, FormsAuthentication.FormsCookiePath);
                string hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                if (ticket.IsPersistent)
                {
                    cookie.Expires = ticket.Expiration;
                }
                Response.Cookies.Add(cookie);
                Response.Redirect(FormsAuthentication.GetRedirectUrl(txtUsuario.Text, false));


            }
            else
            {
                lblErrorLogin.Visible = true;
                lblErrorLogin.Text = "El usuario y/o contraseña ingresado es incorrecto";
            }
        }
    }
}