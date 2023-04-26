using Application.Common.Interfaces;
using Infrastructure.Persistence;
using WebAPI.Services;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigurationServices
{
    public static IServiceCollection AddWebUIServices(this IServiceCollection services)
    {
        services.AddDatabaseDeveloperPageExceptionFilter();

        services.AddScoped<ICurrentUserService, CurrentUserService > ();
        
        services.AddHttpContextAccessor();
        services.AddHealthChecks().AddDbContextCheck<ApplicationDbContext>();
        services.AddControllersWithViews();
        services.AddRazorPages();
        
        

        return services;
    }
}

