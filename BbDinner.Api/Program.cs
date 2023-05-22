using BbDinner.Application;
using BbDinner.Infrastrucutre;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddApplication();
  builder.Services.AddInfrastructure();
  builder.Services.AddControllers();
}

var app = builder.Build();
{
  app.UseHttpsRedirection();
  app.MapControllers();
  app.Run();
}

;