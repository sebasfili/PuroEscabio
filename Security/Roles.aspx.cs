using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuroEscabio.Security
{
    public partial class Roles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var permisos = new SeguridadBLL();
            var usuario = Session["UsuarioLogueado"] as UsuarioBE;

            var resultado = permisos.ObtenerPermisosDeUsuario(usuario);

            gvPermisos.DataSource = resultado;
            
            gvPermisos.AutoGenerateColumns = true;
            gvPermisos.DataBind();
        }
    }
}