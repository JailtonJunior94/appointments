using Appointments.Core.Infra.Contexts;
using Appointments.Core.Infra.Repositories;
using Appointments.Core.Infra.Mappings.Setup;
using Appointments.Core.Application.Services;
using Appointments.Core.Domain.Interfaces.Services;
using Appointments.Core.Domain.Interfaces.Contexts;
using Appointments.Core.Domain.Interfaces.Repositories;

namespace Appointments.API.Configurations
{
    public static class DependenciesConfiguration
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            /* Context */
            services.AddSingleton<IMongoDbContext>(m => new MongoDbContext(configuration["MongoDB:ConnectionString"], configuration["MongoDB:DatabaseName"]));
            SetupMaps.ConfigureMaps();

            /* Repositories */
            services.AddScoped<ICustomerRepository, CustomerRepository>();

            /* Services */
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
