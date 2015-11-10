using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTienda.Model;

namespace RepositorioTienda.ViewModel
{
   public class AlmacenViewModel:IViewModel<Almacen>
   {

        public int idAlmacen { get; set; }
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public string cp { get; set; }
        public Almacen ToBaseDatos()
        {
            return new Almacen()
            {
                idAlmacen = idAlmacen,
                nombre = nombre,
                ciudad = ciudad,
                cp = cp,

            };
        }

       public void FromBaseDatos(Almacen modelo)
       {
           idAlmacen = modelo.idAlmacen;
           nombre = modelo.nombre;
           ciudad = modelo.ciudad;
           cp = modelo.cp;
       }

       public void UpdateBaseDatos(Almacen modelo)
       {
            modelo.idAlmacen = idAlmacen;
            modelo.nombre = nombre;
            modelo.ciudad = ciudad;
            modelo.cp = cp;
        }

       public object[] GetKeys()
       {
          return new object[] {idAlmacen};
       }
   }
}
