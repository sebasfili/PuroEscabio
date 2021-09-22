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

            result.ForEach(x =>
            {
                var bebida = new BebidasBE()
                {
                    Descripcion = x.Descripcion,
                    DigVerificador = x.Dig_ver_h,
                    Id = x.Id,
                    Precio = x.Precio,
                    SKU = x.SKU,
                    StockActual = x.stock_actual,
                    StockMinimo = x.stock_minimo
                };

                if (x.stock_actual < x.stock_minimo)
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

        //pedido de stock por sucursal
        [WebMethod]
        public StockResponse PedidoDeStockPorSucursal(StockRequest stockReq)
        {
            var wsDAL = new WebserviceDAL();
            wsDAL.ObtenerStockPorSucursal();
            StockResponse result = null;
            return result;
        }

        //Responde con la foto actual de como queda el stock.
        [WebMethod]
        public StockResponse ModificarStock(StockRequest stockReq)
        {
            var wsDAL = new WebserviceDAL();
            wsDAL.ActualizarStock(stockReq);         

            StockResponse result = PedidoDeStock(); 
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
