using BbDinner.Application.Common.Interfaces.Auth;
using BbDinner.Infrastrucutre.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace BbDinner.Infrastrucutre;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
    return services;
  }
}