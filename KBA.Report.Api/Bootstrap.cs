using Business;
using IBusiness;
using IRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Entities;

namespace KBA.Reporting.Api
{
    public class Bootstrap
    {
        private const string _sqlConnectionString = "SqlConnectionString";
        private const string _sqlStoreProcedureKeys = "SqlStoreProcedureKeys";
        /// <summary>
        /// This properties will register the Service and Repository layer entities
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGroupBusiness, GroupBusiness>();
            services.AddScoped<IEmployerReportBusiness, EmployerReportBusiness>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IEmployerReportRepository, EmployerReportRepository>();
            services.Configure<SqlStoreProcedureKeys>(configuration.GetSection(_sqlStoreProcedureKeys));           
        }
    }
}
