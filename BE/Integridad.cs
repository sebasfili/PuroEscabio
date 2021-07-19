using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Integridad
    {
        public List<BebidasBE> Bebidas { get; set; } = new List<BebidasBE>();
        public List<UsuarioBE> Usuarios { get; set; } = new List<UsuarioBE>();
    }
}
