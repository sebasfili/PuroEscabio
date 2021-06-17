using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class FamiliaComposite : PermisoComponent
    {
        private List<PermisoComponent> _hojas = new List<PermisoComponent>();

        public FamiliaComposite(string nombre)
            : base(nombre)
        {

        }
        public override void Agregar(PermisoComponent elemento)
        {
            _hojas.Add(elemento);
        }

        public override void Borrar(PermisoComponent elemento)
        {
            _hojas.Remove(elemento);
        }

        public override List<PermisoComponent> PermisoComponents()
        {
            return _hojas;
        }
    }
}
