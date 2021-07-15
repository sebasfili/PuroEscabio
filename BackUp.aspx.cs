using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace PuroEscabio.Security
{
    public partial class Security : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] backupfiles = Directory.GetFiles(Server.MapPath("~/BackUp/"));
            foreach (string file in backupfiles)
            {
                listBackUp.Items.Add(Path.GetFileName(file));

            }
        }

        protected void btnBackUp_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-DLOEM7H0\\SQLEXPRESS;Initial Catalog=PuroEscabio;Integrated Security=True";
            string backUpDir = Server.MapPath("~/BackUp");
            if (!Directory.Exists(backUpDir))
            {
                Directory.CreateDirectory(backUpDir);
            }

            try
            {
                con.Open();
                sqlcmd = new SqlCommand("backup database PuroEscabio to disk='" + backUpDir + "\\" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".Bak'", con);
                sqlcmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El backUp se realizó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el backUp ");
            }
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string backUpFile = Server.MapPath("~/BackUp") + listBackUp.SelectedItem.Text;
                con.Open();
                sqlcmd = new SqlCommand("restore database PuroEscabio from disk='" + backUpFile + "'");
                sqlcmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El restore se realizó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el restore");
            }
        }
    }
}