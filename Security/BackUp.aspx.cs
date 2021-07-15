using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PuroEscabio.Security
{
    public partial class Security : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dpBackUps.DataSource = CargarBackUps();
                dpBackUps.DataValueField = "BackUpPath";
                dpBackUps.DataTextField = "NombreBD";
                dpBackUps.DataBind();
            }
        }

        private List<BackUp> CargarBackUps()
        {
            var seguridad = new SeguridadBLL();
            var path = Server.MapPath("~/BackUps");
            return seguridad.ObtenerBackUps(path);
        }

        protected void btnExecBackup_Click(object sender, EventArgs e)
        {
            var seguridad = new SeguridadBLL();
            var path = Server.MapPath("~/BackUps/");
            seguridad.CrearBackUpBD(dpDB.SelectedValue, path);
        }

        protected void btnRestoreBD_Click(object sender, EventArgs e)
        {

        }
    }
}



