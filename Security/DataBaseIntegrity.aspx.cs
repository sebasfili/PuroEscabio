using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuroEscabio.Security
{
    public partial class DataBaseIntegrity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDigVertical_Click(object sender, EventArgs e)
        {

        }

        protected void btnDigHorizontal_Click(object sender, EventArgs e)
        {
            var seguridadBLL = new SeguridadBLL();
            seguridadBLL.RecalcularDigitoVerificadorHorizontalTodos();
        }
    }
}