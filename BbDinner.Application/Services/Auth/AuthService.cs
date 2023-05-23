using BbDinner.Application.Common.Interfaces.Auth;
using BbDinner.Application.Common.Interfaces.Presistance;
using BbDinner.Domain.Entities;

namespace BbDinner.Application.Services.Auth;

public class AuthService : IAuthService
{
  private readonly IJwtTokenGenerator _jwtTokenGenerator;
  private readonly IUserRepository _userRepository;

  public AuthService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
  {
    _jwtTokenGenerator = jwtTokenGenerator;
    _userRepository = userRepository;
  }


  public AuthResult Login(string Email, string Password)
  {
    if (_userRepository.GetUserByEmail(Email) is not User user) throw new Exception("User doesn't exists");

    if (user.Password != Password) throw new Exception("BOOOM");

    var token = _jwtTokenGenerator.GenerateToken(user);

    return new AuthResult(user, token);
  }

  public AuthResult Register(string FirstName, string LastName, string Email, string Password)
  {
    if (_userRepository.GetUserByEmail(Email) is not null) throw new Exception("User exists");

    var user = new User { FirstName = FirstName, LastName = LastName, Email = Email, Password = Password };
    _userRepository.Add(user);

    var token = _jwtTokenGenerator.GenerateToken(user);

    return new AuthResult(user, token);
  }
}