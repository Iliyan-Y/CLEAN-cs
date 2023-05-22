namespace BbDinner.Contracts.Auth;

public record AuthResponse
(
  Guid Id,
  string FirstName,
  string LastName,
  string Email,
  string token
);