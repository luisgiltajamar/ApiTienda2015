using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioTienda.Model;
using RepositorioTienda.ViewModel;

namespace ApiTienda.Controllers
{
    public class ProductosController : ApiController
    {
        [Dependency]
        public IRepositorio<Producto,ProductoViewModel> Repositorio { get; set; }

        public List<ProductoViewModel> Get()
        {

            return Repositorio.Get().ToList();

        }

        [ResponseType(typeof(ProductoViewModel))]
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);
            if (data == null)
                return NotFound();

            return Ok(data);

        }

    }
}
