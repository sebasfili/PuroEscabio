using BE;
using BLL;
using System;
using System.Web.Security;
using System.Web.UI;

namespace PuroEscabio
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuarioActual = Session["UsuarioLogueado"] as UsuarioBE;

            if (usuarioActual != null)
            {
                btnCerrarSesion.Visible = true;
                aIngresar.Visible = false;
                aRegistrar.Visible = false;
                lblUsuarioActual.Text = string.Format("Usuario: {0}-Rol: {1}", usuarioActual.NombreDeUsuario, usuarioActual.PerfilDeUsuario.Descripcion);
                lblUsuarioActual.Visible = true;
            }

            ValidarMenu();

        }

        private void ValidarMenu()
        {
            var usuarioActual = Session["UsuarioLogueado"] as UsuarioBE;

            switch (usuarioActual?.PerfilDeUsuario?.Descripcion)
            {
                case "Administrador":
                    aRoles.Visible = true;
                    aUsers.Visible = true;
                    aBitacora.Visible = true;
                    aProductsList.Visible = false;
                    aPackList.Visible = false;
                    aDigiVerificador.Visible = true;
                    break;
                case "Usuario":
                    aRoles.Visible = false;
                    aUsers.Visible = false;
                    aBitacora.Visible = false;
                    aProductsList.Visible = true;
                    aPackList.Visible = true;
                    aDigiVerificador.Visible = false;
                    break;
                default:
                    aRoles.Visible = false;
                    aUsers.Visible = false;
                    aBitacora.Visible = false;
                    aProductsList.Visible = false;
                    aPackList.Visible = false;
                    aDigiVerificador.Visible = false;
                    break;
            }
        }

        protected void aCerrarSesion_Click(Object sender, EventArgs e)
        {
            var seguridad = new SeguridadBLL();
            UsuarioBE usuario = Session["UsuarioLogueado"] as UsuarioBE;
            seguridad.CrearBitacora(usuario, "Cerró sesión");

            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            Session.Clear();
            Session.Abandon();
        }
    }
}