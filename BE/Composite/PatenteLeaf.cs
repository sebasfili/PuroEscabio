using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class PatenteLeaf : PermisoComponent
    {
        public PatenteLeaf(string nombre)
            : base(nombre)
        { }

        public override void Agregar(PermisoComponent elemento)
        {
            throw new NotImplementedException();
        }

        public override void Borrar(PermisoComponent elemento)
        {
            throw new NotImplementedException();
        }

        public override List<PermisoComponent> PermisoComponents()
        {
            var hojaActual = new List<PermisoComponent>();
            hojaActual.Add(this);

            return hojaActual;
        }
    }
}
