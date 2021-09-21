using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;

namespace WebService.Repository
{
    public class WebserviceDAL
    {
        public List<Bebida> ObtenerStock()
        {
            using (var dbContext = new PuroEscabioBDDataContext())
            {
                var query = (from prod in dbContext.Bebidas select prod).ToList();

                return query;
            }
        }

        public bool ActualizarStock(StockRequest req)
        {
            bool result = false;
            using (var transaction = new TransactionScope())
            {
                using (var dbContext = new PuroEscabioBDDataContext())
                {
                    var query = (from prod in dbContext.Bebidas where prod.Id == req.Producto.Id select prod).FirstOrDefault();

                    if (query != null)
                    {
                        query.stock_actual = req.Cantidad;

                        dbContext.SubmitChanges();
                        return result;
                    }

                    return result;
                }
            }
        }

        public void ObtenerStockPorSucursal()
        {
            throw new NotImplementedException();
        }
    }
}