using System.Collections.Generic;

namespace BE.Interface
{
    public interface IProducto
    {
        BebidasBE CrearProducto(BebidasBE product);
        List<BebidasBE> ObtenerProductos(BebidasBE product);
        bool BorrarProductos(List<BebidasBE> products);
        BebidasBE ModificarProducto(BebidasBE product);
        List<BebidasBE> ObtenerListaDePackDeProductos();
        List<BebidasBE> ObtenerPackDeProductos(BebidasBE product);
    }
}
