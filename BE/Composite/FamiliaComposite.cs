using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class FamiliaComposite : PermisoComponent
    {
        private List<PermisoComponent> _hoja = new List<PermisoComponent>();

        public FamiliaComposite(string nombre)
            : base(nombre)
        {

        }
        public override void Agregar(PermisoComponent elemento)
        {
            _hoja.Add(elemento);
        }

        public override void Borrar(PermisoComponent elemento)
        {
            _hoja.Remove(elemento);
        }

        
    }
}
