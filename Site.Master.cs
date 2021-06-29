﻿using BE;
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
                //lblUsuarioLogueado.Text = (usuarioActual as UsuarioBE).NombreDeUsuario != null ?
                //                          string.Format("Usuario Actual: {0}", usuarioActual.NombreDeUsuario) : string.Empty;


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
            var seguridad = new Seguridad();
            UsuarioBE usuario = Session["UsuarioLogueado"] as UsuarioBE;
            seguridad.CrearBitacora(usuario, "Cerró sesión");

            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            Session.Clear();
            Session.Abandon();
        }
    }
}