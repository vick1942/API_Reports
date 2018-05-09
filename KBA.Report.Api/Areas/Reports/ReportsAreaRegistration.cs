using System.Web.Http;
using System.Web.Mvc;

namespace Report.Api.Areas.Reports
{
    public class ReportsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Reports";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            GlobalConfiguration.Configuration.MapHttpAttributeRoutes();

            context.MapRoute(
                "Reports_default",
                "Reports/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            context.Routes.MapHttpRoute(
                   name: "Reports_Api",
                   routeTemplate: "api/Reports/{controller}/{id}",
                   defaults: new { id = RouteParameter.Optional }
               );
            context.Routes.MapHttpRoute(
                  name: "Reports",
                  routeTemplate: "api/Reports/{controller}/{action}/{id}",
                  defaults: new { id = RouteParameter.Optional }
              );
        }
    }
}