using Barrel.Infrastructure.Data;
using Barrel.Infrastructure.Messaging;
using Barrel.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Barrel.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ArquivoDbContext>(opt =>
                opt.UseSqlServer(config.GetConnectionString("SqlWriteConnection")));

            services.AddScoped<IArquivoRepository, ArquivoRepository>();
            services.AddSingleton<IMessageBus, RabbitMqMessageBus>();
            return services;
        }
    }
}
