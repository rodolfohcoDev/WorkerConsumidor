using Microsoft.Extensions.DependencyInjection;

namespace Consumer.IoC.Configurarion
{

    public static class ConfigMediator
    {
        public static void AddMediatRApi(this IServiceCollection services)
        =>        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
    }
}