using BbDinner.Domain.Entities;

namespace BbDinner.Application.Common.Interfaces.Presistance;

public interface IUserRepository
{
  User? GetUserByEmail(string email);
  void Add(User user);
}