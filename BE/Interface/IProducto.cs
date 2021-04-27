using System.Collections.Generic;

namespace BE.Interface
{
    public interface IProducto
    {
        Bebidas CrearProducto(Bebidas product);
        List<Bebidas> ObtenerProductos(Bebidas product);
        bool BorrarProductos(List<Bebidas> products);
        Bebidas ModificarProducto(Bebidas product);
        List<Bebidas> ObtenerListaDePackDeProductos();
        List<Bebidas> ObtenerPackDeProductos(Bebidas product);
    }
}
