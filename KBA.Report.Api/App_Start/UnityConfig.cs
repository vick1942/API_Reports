using Business;
using IBusiness;
using IRepository;
using Repository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Report.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IGroupBusiness, GroupBusiness>();
            container.RegisterType<IGroupRepository, GroupRepository>();
            container.RegisterType<IEmployerReportBusiness, EmployerReportBusiness>();
            container.RegisterType<IEmployerReportRepository, EmployerReportRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}