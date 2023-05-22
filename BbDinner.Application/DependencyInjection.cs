using BbDinner.Application.Services.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace BbDinner.Application;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    services.AddScoped<IAuthService, AuthService>();
    return services;
  }
}