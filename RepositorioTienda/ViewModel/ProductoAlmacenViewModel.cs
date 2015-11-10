using System;
using BaseRepositorio.ViewModel;
using RepositorioTienda.Model;

namespace RepositorioTienda.ViewModel
{
    public class ProductoAlmacenViewModel:IViewModel<ProductoAlmacen>
    {
        public int idProducto { get; set; }
        public int idAlmacen { get; set; }
        public String Almacen { get; set; }
        public int unidades { get; set; }

        public ProductoAlmacen ToBaseDatos()
        {
           return new ProductoAlmacen()
           {
               idProducto = idProducto,
               idAlmacen = idAlmacen,
               unidades = unidades,
           };
        }

        public void FromBaseDatos(ProductoAlmacen modelo)
        {
            idProducto = modelo.idProducto;
            idAlmacen = modelo.idAlmacen;
            unidades = modelo.unidades;

            try
            {
                Almacen = modelo.Almacen.nombre;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void UpdateBaseDatos(ProductoAlmacen modelo)
        {
            modelo.idProducto = idProducto;
            modelo.idAlmacen = idAlmacen;
            modelo.unidades = unidades;
        }

        public object[] GetKeys()
        {
           return new object[] {idProducto,idAlmacen};
        }
    }
}