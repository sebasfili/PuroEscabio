using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    [Serializable]
    public class BebidasBE
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        [XmlElement("SKU")]
        public string SKU { get; set; }
        [XmlElement("Descripcion")]
        public string Descripcion { get; set; }
        [XmlElement("Precio", IsNullable = true)]
        public decimal? Precio { get; set; }
        [XmlElement("DigVerificador")]
        public string DigVerificador { get; set; }
        [XmlElement("StockMinimo", IsNullable = true)]
        public int? StockMinimo { get; set; }
        [XmlElement("StockActual", IsNullable = true)]
        public int? StockActual { get; set; }
        [XmlElement("Sucursal")]
        public string Sucursal { get; set; }
    }
}
