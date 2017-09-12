using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using CSA.WEB.API;
using CSAApp.Web.API;
using System.Web.Http;
using System.Web.Mvc;

namespace CSA.Web.API
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
             builder.RegisterControllers(typeof(WebApiApplication).Assembly);
            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

            // Register our Data dependencies
            builder.RegisterModule(new ContainerRegistrationModule("CSAContext"));

            ////Web Api

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);

            //// OPTIONAL: Register the Autofac filter provider.
           builder.RegisterWebApiFilterProvider(config);

            //// OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            //// Set the dependency resolver to be Autofac.
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //// Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}