using backend.Helpers.Seeders;
using backend.Repositories.MaterieRepository;
using backend.Repositories.ProfesorMaterieRepository;
using backend.Repositories.ProfesorRepository;
using backend.Services.MaterieService;
using backend.Services.ProfesorMaterieService;
using backend.Services.ProfesorService;

namespace backend.Helpers.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {        
        services.AddTransient<IProfesorRepository, ProfesorRepository>();
        services.AddTransient<IMaterieRepository, MaterieRepository>();
        services.AddTransient<IProfesorMaterieRepository, ProfesorMaterieRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient<IProfesorService, ProfesorService>();
        services.AddTransient<IMaterieService, MaterieService>();
        services.AddTransient<IProfesorMaterieService, ProfesorMaterieService>();

        return services;
    }

    public static IServiceCollection AddSeeders(this IServiceCollection services)
    {
        services.AddTransient<TestSeeder>();
    
        return services;
    }
}