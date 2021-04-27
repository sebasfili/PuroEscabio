using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Item
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<Bebidas> Producto { get; set; }

    }
}
