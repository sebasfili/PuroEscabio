using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace WebService.Repository
{
    public class WebserviceDAL
    {
        public List<BebidasBE> ObtenerStock()
        {
            using (var dbContext = new PuroEscabioBDDataContext())
            {

                var query = (from prod in dbContext.Bebidas
                             join prod_suc in dbContext.bebida_sucursals on prod.Id equals prod_suc.Id_bebida
                             join suc in dbContext.Sucursals on prod_suc.Id_sucursal equals suc.Id
                             select new BebidasBE
                             {
                                 Descripcion = prod.Descripcion,
                                 StockActual = prod_suc.stock_actual,
                                 StockMinimo = prod_suc.stock_min,
                                 SKU = prod.SKU,
                                 Sucursal = suc.Descripcion

                             }).ToList();

                return query;
            }
        }

        public bool ActualizarStock(int idSucursal, int idProducto, int cantidad)
        {
            using (var transaction = new TransactionScope())
            {


                using (var dbContext = new PuroEscabioBDDataContext())
                {
                    var query = (from stock in dbContext.bebida_sucursals
                                 where stock.Id_bebida == idProducto && stock.Id_sucursal == idSucursal
                                 select stock
                             ).FirstOrDefault();


                    if (query != null)
                    {
                        query.stock_actual = cantidad;

                        dbContext.SubmitChanges();
                        transaction.Complete();
                        
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                }
            }
        }

        public List<BebidasBE> ObtenerStockPorSucursal(int IDSucursal)
        {
            using (var dbContext = new PuroEscabioBDDataContext())
            {
                var query = (from prod in dbContext.Bebidas
                             join prod_suc in dbContext.bebida_sucursals on prod.Id equals prod_suc.Id_bebida
                             join suc in dbContext.Sucursals on prod_suc.Id_sucursal equals suc.Id
                             where suc.Id == IDSucursal
                             select new BebidasBE
                             {
                                 Descripcion = prod.Descripcion,
                                 StockActual = prod_suc.stock_actual,
                                 StockMinimo = prod_suc.stock_min,
                                 SKU = prod.SKU,
                                 Sucursal = suc.Descripcion

                             }).ToList();

                return query;
            }
        }
    }
}