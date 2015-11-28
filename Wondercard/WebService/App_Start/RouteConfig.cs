using System.Web.Http;

namespace Wondercard.Client.Gateway
{
    public static class RouteConfig
    {
        /// <summary>
        ///     Routing registration.
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                "Default",
                "api/{controller}/{id}",
                new {controller = "Default", id = RouteParameter.Optional},
                new {}
                );
        }
    }
}