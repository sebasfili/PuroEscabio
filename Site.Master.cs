using BE;
using System;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace PuroEscabio
{
    public partial class SiteMaster : MasterPage
    {
        UsuarioBE usuarioActual = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                aCerrarSesion.ServerClick += new EventHandler(this.aCerrarSesion_Click);
                usuarioActual = Session["UsuarioLogueado"] as UsuarioBE;

                if (usuarioActual != null)
                {
                    aCerrarSesion.Visible = true;
                    aIngresar.Visible = false;
                    lblUsuarioLogueado.Text = (usuarioActual as UsuarioBE).NombreDeUsuario != null ?
                                              string.Format("Usuario Actual: {0}", (usuarioActual as UsuarioBE).NombreDeUsuario) : string.Empty;


                }

                ValidarMenu(); 
            }
        }

        private void ValidarMenu()
        {
            switch (usuarioActual?.PerfilDeUsuario?.Descripcion)
            {
                case "Administrador":
                    aRoles.Visible = true;
                    aUsers.Visible = true;
                    aBitacora.Visible = true;
                    aProductsList.Visible = false;
                    aPackList.Visible = false;
                    break;
                case "Usuario":
                    aRoles.Visible = false;
                    aUsers.Visible = false;
                    aBitacora.Visible = false;
                    aProductsList.Visible = true;
                    aPackList.Visible = true;
                    break;
                default:
                    aRoles.Visible = false;
                    aUsers.Visible = false;
                    aBitacora.Visible = false;
                    aProductsList.Visible = false;
                    aPackList.Visible = false;
                    break;
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