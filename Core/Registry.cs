using Core.Identities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Core;

public static class Registry
{
    public static IServiceCollection AddCoreRegistry(this IServiceCollection services)
    {
        services.TryAddScoped<IIdGenerator, NulloIdGenerator>();
        
        return services;
    }
}
