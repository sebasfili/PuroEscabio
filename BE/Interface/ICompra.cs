using System.Collections.Generic;

namespace BE.Interface
{
    public interface ICompra
    {
        bool AgregarAlCarritoDeCompra(ItemBE item);
        bool BorrarDelCarritoDeCompra(ItemBE item);
        bool ModificarCarritoDeCompra(ItemBE item);
        bool GuardarCarritoDeCompra(ItemBE item);
        List<ItemBE> ObtenerCarritoDeCompra(UsuarioBE user);//listado de compras realizadas pero no pagas.
    }
}
