using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace PuroEscabio.Security
{
    public partial class Security : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["CheckRefresh"] = Session["CheckRefresh"];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["CheckRefresh"] =
                Server.UrlDecode(System.DateTime.Now.ToString());
            }

            dpBackUps.DataSource = null;
            dpBackUps.Items.Clear();

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

        private List<BackUp> CargarBackUps()
        {
            var seguridad = new SeguridadBLL();
            var path = Server.MapPath("~/BackUps");
            return seguridad.ObtenerBackUps(path);
        }

        protected void btnExecBackup_Click(object sender, EventArgs e)
        {
            if (Session["CheckRefresh"].ToString() == ViewState["CheckRefresh"].ToString())
            {
                var seguridad = new SeguridadBLL();
                var path = Server.MapPath("~/BackUps/");
                bool res = seguridad.CrearBackUpBD(dpDB.SelectedValue, path);
                divBackupError.Visible = !res;
                divBackupExito.Visible = res;
                Session["CheckRefresh"] =
                Server.UrlDecode(System.DateTime.Now.ToString());
            }
            else
            {
                //Label1.Text = "Page Refreshed";
            }
        }

        protected void btnRestoreBD_Click(object sender, EventArgs e)
        {
            try
            {
                sinBackup.Visible = false;
                if (dpBackUps.Items == null || dpBackUps.Items.Count <= 0)
                {
                    sinBackup.Visible = true;
                    return;
                }

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
            catch (Exception)
            {

                sinBackup.Visible = true;
            }
        }
       

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            dpBackUps.DataSource = null;
            dpBackUps.Items.Clear();

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
}



