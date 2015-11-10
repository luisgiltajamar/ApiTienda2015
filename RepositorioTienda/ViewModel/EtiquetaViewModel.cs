using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseRepositorio.ViewModel;
using RepositorioTienda.Model;

namespace RepositorioTienda.ViewModel
{
   public class EtiquetaViewModel:IViewModel<Etiqueta>
   {
        public int idEtiqueta { get; set; }
        public string nombre { get; set; }
       public Etiqueta ToBaseDatos()
       {
           return new Etiqueta()
           {
               idEtiqueta = idEtiqueta,
               nombre = nombre,
           };
       }

       public void FromBaseDatos(Etiqueta modelo)
       {
           idEtiqueta = modelo.idEtiqueta;
           nombre = modelo.nombre;
       }

       public void UpdateBaseDatos(Etiqueta modelo)
       {
            modelo.idEtiqueta = idEtiqueta;
            modelo.nombre = nombre;
        }

       public object[] GetKeys()
       {
          return new object[] {idEtiqueta};
       }
   }
}
