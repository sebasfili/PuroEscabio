using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public abstract class PermisoComponent
    {
        public abstract void Agregar(PatenteLeaf elemento);
        public abstract void Borrar(PatenteLeaf elemento);
        public abstract void Modificar(PatenteLeaf elemento);
        public abstract void Mostrar(PatenteLeaf elemento);

    }
}
