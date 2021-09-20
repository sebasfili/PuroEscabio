using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //pedido de stock en total
        [WebMethod]
        public StockResponse PedidoDeStock(StockRequest stockReq)
        {
            StockResponse result = null;
            return result;
        }

        //pedido de stock por sucursal
        [WebMethod]
        public StockResponse PedidoDeStockPorSucursal(StockRequest stockReq)
        {
            StockResponse result = null;
            return result;
        }

        //Responde con la foto actual de como queda el stock.
        [WebMethod]
        public StockResponse ModificarStock(StockRequest stockReq)
        {
            StockResponse result = null;
            return result;
        }

        //Compras del usuario
        [WebMethod]
        public ItemBE CarritoDeCompras(UsuarioBE user)
        {
            ItemBE result = null;
            return result;
        }

    }
}
