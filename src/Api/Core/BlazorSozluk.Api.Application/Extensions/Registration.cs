using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlazorSozluk.Api.Application.Extensions;

public static class Registration
{
    public static IServiceCollection AddApplicationRegistration(this IServiceCollection services)
    {
        var assm = Assembly.GetExecutingAssembly();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assm));
        services.AddAutoMapper(assm);
        services.AddValidatorsFromAssembly(assm);

        return services;
    }
}
