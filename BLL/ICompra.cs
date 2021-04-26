using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface ICompra
    {
        bool AgregarAlCarritoDeCompra(Item item);
        bool BorrarDelCarritoDeCompra(Item item);
        bool ModificarCarritoDeCompra(Item item);
        bool GuardarCarritoDeCompra(Item item);
        List<Item> ObtenerCarritoDeCompra(Usuario user);//listado de compras realizadas pero no pagas.
    }
}
