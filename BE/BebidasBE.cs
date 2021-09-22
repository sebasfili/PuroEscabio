﻿using System;
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
        public decimal? Precio { get; set; }
        public string DigVerificador { get; set; }
        public int? StockMinimo { get; set; }
        public int? StockActual { get; set; }
        public string Sucursal { get; set; }
    }
}
