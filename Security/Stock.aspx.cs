using PuroEscabio.wsPuroEscabio;
using System;

namespace PuroEscabio.Security
{
    public partial class Stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var ws = new WebService1();                
                var result = ws.PedidoDeStock();

                gvStock.DataSource = result.ProductosEnStock;
                gvStock.AutoGenerateColumns = true;
                gvStock.DataBind();

                gvNoStock.DataSource = result.ProductosARenovar;
                gvNoStock.AutoGenerateColumns = true;
                gvNoStock.DataBind();
            }
        }

        
    }
}