using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuroEscabio
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var usuarioLogueado = Session["UsuarioLogueado"] as UsuarioBE;

            if (usuarioLogueado == null)
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
            }
            else
            {
                lblRolUsuario.Text = usuarioLogueado?.PerfilDeUsuario?.Descripcion;
                ValidarIntegridadDeBaseDeDatos();
            }
        }

        private bool ValidarIntegridadDeBaseDeDatos()
        {
            var seguridad = new SeguridadBLL();
            var erroresIntegridad = new List<GrillaIntegridadBE>();
            var resultado = seguridad.ValidarIntegridadDeAplicacion();

            if (resultado.Bebidas.Count > 0 || resultado.Usuarios.Count > 0)
            {
                erroresIntegridad.AddRange(resultado.Bebidas.Select(x => new GrillaIntegridadBE()
                {
                    Tabla = "Bebidas",
                    IdRegistro = x.Id,
                    ValoresActuales = string.Format("Descripcion: {0}; Precio: ${1}, SKU: {2}", x.Descripcion, x.Precio, x.SKU)
                }).ToList());

                erroresIntegridad.AddRange(resultado.Usuarios.Select(x => new GrillaIntegridadBE()
                {
                    Tabla = "Usuarios",
                    IdRegistro = x.Id,
                    ValoresActuales = string.Format("Usuario: {0}; Perfil: {1}", x.NombreDeUsuario, x.PerfilDeUsuario)
                }));


                gvErroresIntegridad.DataSource = erroresIntegridad;
                gvErroresIntegridad.DataBind();

                divIntegridad.Visible = true;
                

                return true;
            }
            else
            {
                divIntegridad.Visible = false;

                return false;
            }

        }
    }
}