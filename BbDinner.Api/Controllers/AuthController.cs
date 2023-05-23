using BbDinner.Application.Services.Auth;
using BbDinner.Contracts.Auth;
using Microsoft.AspNetCore.Mvc;

namespace BbDinner.Api.Controllers;

[Route("auth")]
[ApiController]
public class AuthController : ControllerBase
{
  private readonly IAuthService _authService;

  public AuthController(IAuthService authService)
  {
    _authService = authService;
  }

  [HttpPost]
  [Route("register")]
  public IActionResult Register(RegisterRequest request)
  {
    var authResult = _authService.Register(request.FirstName, request.LastName, request.Email, request.Password);
    var response = new AuthResponse(authResult.User.Id, authResult.User.FirstName, authResult.User.LastName,
      authResult.User.Email,
      authResult.token);
    return Ok(response);
  }

  [HttpPost]
  [Route("login")]
  public IActionResult Login(LoginRequest request)
  {
    var authResult = _authService.Login(request.Email, request.Password);
    var response = new AuthResponse(authResult.User.Id, authResult.User.FirstName, authResult.User.LastName,
      authResult.User.Email,
      authResult.token);
    return Ok(response);
  }
}