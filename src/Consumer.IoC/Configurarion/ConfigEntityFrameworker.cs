using Consumer.Data.Context;
using Consumer.Domain.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Consumer.IoC.Configurarion
{
    public static class ConfigEntityFrameworker
    {
        public static void AddEntityFramework(this IServiceCollection services,AppConfiguration configuration)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 36));

            services.AddDbContext<DBDataBase>(
                dbContextOptions => dbContextOptions
                    .UseMySql(configuration.EntityFrameworkConfig.ConectionString, serverVersion)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors());
        }
    }
}