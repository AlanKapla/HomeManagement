using HomeManagement.Application.Abstractions;
using HomeManagement.Persistance.EntityFramework.Repositories;
using HomeManagement.Persistance.EntityFramework.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HomeManagement.Persistance.EntityFramework
{
    public static class HomeManagementEntityFrameworkRegistration
    {
        public static IServiceCollection HomeManagementPersistanceEntityFrameworkServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HomeManagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("HomeManagementCS")));

            services.AddScoped<IHomeMemberRepository, HomeMemberRepository>();
            services.AddScoped<IIncomeRepository, IncomeRepository>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<Seeder>();

            return services;
        }
    }
}
