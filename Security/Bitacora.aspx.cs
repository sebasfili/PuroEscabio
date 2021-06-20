using BE;
using BLL;
using System;

namespace PuroEscabio.Security
{
    public partial class Bitacora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var permisos = new Seguridad();
            var usuario = Session["UsuarioLogueado"] as UsuarioBE;

            var resultado = permisos.ObtenerBitacoraCompleta();

            gvBitacora.DataSource = resultado;

            gvBitacora.AutoGenerateColumns = true;
            gvBitacora.DataBind();
        }
    }
}