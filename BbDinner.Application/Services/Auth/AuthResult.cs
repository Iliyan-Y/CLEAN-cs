using BbDinner.Domain.Entities;

namespace BbDinner.Application.Services.Auth;

public record AuthResult(
  User User,
  string token
);