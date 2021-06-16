using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BebidasBE
    {
        /// <summary>
        /// Id de la bebida
        /// </summary>
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        
    }
}
