using Reports.Api;
using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Report.Api
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Report.Api.UnityConfig.RegisterComponents();

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
                                .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept",
                              "text/html",
                              StringComparison.InvariantCultureIgnoreCase,
                              true,
                              "application/json"));
        }
    }
}

