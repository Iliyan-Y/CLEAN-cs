using BbDinner.Application.Common.Interfaces.Presistance;
using BbDinner.Domain.Entities;

namespace BbDinner.Infrastrucutre.Presistence;

public class UserRepository : IUserRepository
{
  private static readonly List<User> _users = new();

  public User? GetUserByEmail(string email)
  {
    return _users.SingleOrDefault(e => e.Email == email);
  }

  public void Add(User user)
  {
    _users.Add(user);
  }
}