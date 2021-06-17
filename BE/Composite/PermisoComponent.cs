using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public abstract class PermisoComponent
    {
        private string _name;

        // Constructor

        public PermisoComponent(string name)
        {
            this._name = name;
        }
        public abstract void Agregar(PermisoComponent elemento);
        public abstract void Borrar(PermisoComponent elemento);
       

    }
}
