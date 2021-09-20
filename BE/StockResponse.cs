using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class StockResponse
    {
        public List<BebidasBE> ProductosEnStock { get; set; }
        public List<BebidasBE> ProductosARenovar { get; set; }
    }
}
