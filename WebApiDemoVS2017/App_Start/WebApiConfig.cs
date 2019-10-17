using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using WebApiDemoVS2017.Data;
using WebApiDemoVS2017.Data.DependencyResolver;

namespace WebApiDemoVS2017
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //Configure Unity Container
            var container = new UnityContainer();
            container.RegisterType<IStudentRepository, StudentRespository>();
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
