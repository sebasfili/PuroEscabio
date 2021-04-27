using System.Collections.Generic;

namespace BE.Interface
{
    public interface ICompra
    {
        bool AgregarAlCarritoDeCompra(Item item);
        bool BorrarDelCarritoDeCompra(Item item);
        bool ModificarCarritoDeCompra(Item item);
        bool GuardarCarritoDeCompra(Item item);
        List<Item> ObtenerCarritoDeCompra(Usuario user);//listado de compras realizadas pero no pagas.
    }
}
