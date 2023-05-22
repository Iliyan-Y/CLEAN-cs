using BbDinner.Application.Common.Interfaces.Auth;

namespace BbDinner.Application.Services.Auth;

public class AuthService : IAuthService
{
  private readonly IJwtTokenGenerator _jwtTokenGenerator;

  public AuthResult Login(string Email, string Password)
  {
    return new AuthResult(Guid.NewGuid(), "FirstName", "LastName", Email, "Token");
  }

  public AuthResult Register(string FirstName, string LastName, string Email, string Password)
  {
    // todo: check if user exist 

    var userId = Guid.NewGuid();

    var token = _jwtTokenGenerator.GenerateToken(userId, FirstName, LastName);

    return new AuthResult(userId, FirstName, LastName, Email, token);
  }
}