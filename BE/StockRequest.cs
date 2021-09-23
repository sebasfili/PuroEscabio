using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class StockRequest
    {
        public BebidasBE Producto { get; set; }
        public int Cantidad { get; set; }
        public bool PorSucursal { get; set; }
        public int IDSucursal { get; set; }
    }
}
