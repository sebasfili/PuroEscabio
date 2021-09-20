using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class StockRequest
    {
        public BebidasBE IDProducto { get; set; }
        public uint Cantidad { get; set; }
        public bool PorSucursal { get; set; }
    }
}
