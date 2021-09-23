using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Repository;

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
        public StockResponse PedidoDeStock()
        {
            var wsDAL = new WebserviceDAL();
            var result = wsDAL.ObtenerStock();
            var stockResponse = new StockResponse()
            {
                ProductosARenovar = new List<BebidasBE>(),
                ProductosEnStock = new List<BebidasBE>()
            };

            result.ForEach(bebida =>
            {            

                if (bebida.StockActual < bebida.StockMinimo)
                {
                    stockResponse.ProductosARenovar.Add(bebida);
                }
                else
                {
                    stockResponse.ProductosEnStock.Add(bebida);
                }
            });

         
            return stockResponse;
        }

        //Pedido de stock por sucursal
        [WebMethod]
        public StockResponse PedidoDeStockPorSucursal(int idSucursal)
        {
            var wsDAL = new WebserviceDAL();           
            var result = wsDAL.ObtenerStockPorSucursal(idSucursal);

            var stockResponse = new StockResponse()
            {
                ProductosARenovar = new List<BebidasBE>(),
                ProductosEnStock = new List<BebidasBE>()
            };

            result.ForEach(bebida =>
            {

                if (bebida.StockActual < bebida.StockMinimo)
                {
                    stockResponse.ProductosARenovar.Add(bebida);
                }
                else
                {
                    stockResponse.ProductosEnStock.Add(bebida);
                }
            });

            return stockResponse;
        }

        //Responde con la foto actual de como queda el stock.
        [WebMethod]
        public bool ModificarStock(int idSucursal, int idProducto, int cantidad)
        {
            var wsDAL = new WebserviceDAL();
            var result = wsDAL.ActualizarStock(idSucursal, idProducto, cantidad);         

            
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
