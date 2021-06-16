using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuroEscabio
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var a = Session["UsuarioLogueado"];

            if (a != null)
            {
                lblUsuarioLogueado.Text = (a as UsuarioBE).NombreDeUsuario != null ?
                                          string.Format("Usuario Actual: {0}", (a as UsuarioBE).NombreDeUsuario) : string.Empty;
            }
        }
    }
}