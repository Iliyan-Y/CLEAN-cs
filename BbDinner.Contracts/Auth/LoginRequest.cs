namespace BbDinner.Contracts.Auth;

public record LoginRequest(
  string Email,
  string Password
);