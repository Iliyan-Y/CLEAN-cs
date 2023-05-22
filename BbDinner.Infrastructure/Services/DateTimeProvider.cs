using BbDinner.Application.Common.Interfaces.Services;

namespace BbDinner.Infrastrucutre.Services;

public class DateTimeProvider : IDateTimeProvider
{
  public DateTime UtcNow => DateTime.UtcNow;
}