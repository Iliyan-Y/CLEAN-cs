namespace BbDinner.Application.Services.Auth;

public interface IAuthService
{
  AuthResult Login(
    string Email,
    string Password
  );

  AuthResult Register(
    string FirstName,
    string LastName,
    string Email,
    string Password
  );
}