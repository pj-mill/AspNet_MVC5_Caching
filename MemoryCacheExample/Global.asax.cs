using MemoryCacheExample.DependencyResolution;
using StructureMap;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MemoryCacheExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IContainer container = IoC.Initialize();
        }
    }
}
