using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTienda.Model;

namespace RepositorioTienda.ViewModel
{
   public class ProductoViewModel:IViewModel<Producto>
   {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precioCoste { get; set; }
        public Nullable<decimal> precioVenta { get; set; }
        public string fabricante { get; set; }
        public int idCategoria { get; set; }
       public String Categoria { get; set; }

       public List<EtiquetaViewModel> Etiquetas { get; set; }


        public Producto ToBaseDatos()
       {
          return new Producto()
          {
              idCategoria = idCategoria,
              idProducto = idProducto,
              nombre = nombre,
              descripcion = descripcion,
              fabricante = fabricante,
              precioCoste = precioCoste,
              precioVenta = precioVenta,
          };
       }

       public void FromBaseDatos(Producto modelo)
       {
           idCategoria = modelo.idCategoria;
           idProducto = modelo.idProducto;
           nombre = modelo.nombre;
           descripcion = modelo.descripcion;
           fabricante = modelo.fabricante;
           precioCoste = modelo.precioCoste;
           precioVenta = modelo.precioVenta;

           try
           {
               Categoria = modelo.Categoria.nombre;
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
           }

           try
           {
               if(Etiquetas==null)
                   Etiquetas=new List<EtiquetaViewModel>();

               foreach (var etiqueta in modelo.Etiqueta)
               {
                   var et=new EtiquetaViewModel();
                   et.FromBaseDatos(etiqueta);
                   Etiquetas.Add(et);
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
           }


       }

       public void UpdateBaseDatos(Producto modelo)
       {
            modelo.idCategoria = idCategoria;
            modelo.idProducto = idProducto;
            modelo.nombre = nombre;
            modelo.descripcion = descripcion;
            modelo.fabricante = fabricante;
            modelo.precioCoste = precioCoste;
            modelo.precioVenta = precioVenta;
        }

       public object[] GetKeys()
       {
         return new object[] {idProducto};
       }
   }
}
