using System;
using System.Collections.Generic;
using System.Text;

namespace PuroEscabio.App.Model
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public string ProductAndCost => $"{ProductName} - ${Cost}";
        public string SKU { get; set; }

        public bool Selected { get; set; }

    }
}
