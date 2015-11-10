using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTienda.Model;

namespace RepositorioTienda.ViewModel
{
   public class CategoriaViewModel:IViewModel<Categoria>
   {
        public int idCategoria { get; set; }
        public string nombre { get; set; }
       public Categoria ToBaseDatos()
       {
          return new Categoria()
          {
              idCategoria = idCategoria,
              nombre = nombre,
          };
       }

       public void FromBaseDatos(Categoria modelo)
       {
           idCategoria = modelo.idCategoria;
           nombre = modelo.nombre;
        }

       public void UpdateBaseDatos(Categoria modelo)
       {
            modelo.idCategoria = idCategoria;
            modelo.nombre = nombre;
        }

       public object[] GetKeys()
       {
          return new object[] {idCategoria};
       }
   }
}
