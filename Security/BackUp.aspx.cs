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
                dpBackUps.DataSource = null;

                foreach (BackUp item in CargarBackUps())
                {
                    var listItem = new ListItem()
                    {
                        Text = item.NombreBD,

                    };
                    dpBackUps.Items.Add(listItem);
                }


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
            bool res = seguridad.CrearBackUpBD(dpDB.SelectedValue, path);
            divBackupError.Visible = !res;
            divBackupExito.Visible = res;
        }

        protected void btnRestoreBD_Click(object sender, EventArgs e)
        {
            var seguridad = new SeguridadBLL();
            var bk = new BackUp()
            {
                BackUpPath = Server.MapPath("~/BackUps/"),
                NombreBD = dpBackUps.SelectedItem.Text
            };


            bool res = seguridad.RestoreBD(bk);
            divError.Visible = !res;
            divExito.Visible = res;
        }

        protected void Unnamed_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = 0;
        }

        protected void Unnamed_TextChanged(object sender, EventArgs e)
        {
            var a = 0;
        }
    }
}



