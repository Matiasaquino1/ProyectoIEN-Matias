using InstitutoIENService.Core.Interfaces;
using InstitutoIENService.Infrastructure.Data;
using InstitutoIENService.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InstitutoIENServices.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            //Add ConnectionStrings
            services.AddDbContext<InstitutoIencursoContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("InstitutoIENContext"))
            );

            //dependencias de repository
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IRrhhRepository, RrhhRepository>();
            services.AddTransient<IProvinceRepository, ProvinceRepository>();
            services.AddTransient<ILocalityRepository, LocalityRepository>();
            return services;
        }
    }
}
