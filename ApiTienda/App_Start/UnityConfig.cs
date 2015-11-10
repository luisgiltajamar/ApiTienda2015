using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using BaseRepositorio.Repositorio;
using RepositorioTienda.Model;
using RepositorioTienda.ViewModel;
using Unity.WebApi;

namespace ApiTienda
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<DbContext, tiendaluisEntities>();

            container.RegisterType<IRepositorio<Producto, ProductoViewModel>,
                RepositorioEntity<Producto,ProductoViewModel>>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}