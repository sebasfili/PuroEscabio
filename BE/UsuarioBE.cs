using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class UsuarioBE
    {
        public int Id { get; set; }
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
        public PerfilBE PerfilDeUsuario { get; set; }
    }
}
