using System.Configuration;
using BbDinner.Application.Common.Interfaces.Auth;
using BbDinner.Application.Common.Interfaces.Presistance;
using BbDinner.Application.Common.Interfaces.Services;
using BbDinner.Infrastrucutre.Auth;
using BbDinner.Infrastrucutre.Presistence;
using BbDinner.Infrastrucutre.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BbDinner.Infrastrucutre;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services,
    ConfigurationManager builderConfiguration)
  {
    services.Configure<JwtSettings>(builderConfiguration.GetSection(JwtSettings.SectionName));
    services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
    services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
    services.AddScoped<IUserRepository, UserRepository>();
    return services;
  }
}