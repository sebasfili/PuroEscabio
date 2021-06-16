using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ItemBE
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<BebidasBE> Producto { get; set; }

    }
}
