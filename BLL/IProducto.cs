using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface IProducto
    {
        Producto CrearProducto(Producto product);
        List<Producto> ObtenerProductos(Producto product);
        bool BorrarProductos(List<Producto> products);
        Producto ModificarProducto(Producto product);
        List<Producto> ObtenerListaDePackDeProductos();
        List<Producto> ObtenerPackDeProductos(Producto product);
    }
}
