using BbDinner.Domain.Entities;

namespace BbDinner.Application.Common.Interfaces.Auth;

public interface IJwtTokenGenerator
{
  string GenerateToken(User user);
}