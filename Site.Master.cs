using BE;
using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace PuroEscabio
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            aCerrarSesion.ServerClick += new EventHandler(this.aCerrarSesion_Click);
            var usuarioActual = Session["UsuarioLogueado"];

            if (usuarioActual != null)
            {
                aCerrarSesion.Visible = true;
                aIngresar.Visible = false;
                lblUsuarioLogueado.Text = (usuarioActual as UsuarioBE).NombreDeUsuario != null ?
                                          string.Format("Usuario Actual: {0}", (usuarioActual as UsuarioBE).NombreDeUsuario) : string.Empty;
            }
        }

        protected void aCerrarSesion_Click(Object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            Session.Clear();
            Session.Abandon();

        }

    }
}