using BLL;
using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void btnExecBackup_Click(object sender, EventArgs e)
        {
            var seguridad = new SeguridadBLL();
            var path = Server.MapPath("~/BackUps");
            seguridad.CrearBackUpBD(dpDB.SelectedValue, path);
        }

      
    }
}