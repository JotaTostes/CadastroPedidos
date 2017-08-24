using CadastroPedidos.WebAPI.App_Start;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SimpleInjector.Integration.WebApi;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace CadastroPedidos.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter
            {
                SerializerSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    ContractResolver = new DefaultContractResolver
                    {
                        IgnoreSerializableAttribute = true
                    }
                }
            });

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(SimpleInjectorContainer.Build());

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
