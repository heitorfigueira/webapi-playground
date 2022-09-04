using WebApi.Framework.Extensions;

var builder = WebApplication.CreateBuilder(args);
var (services, configuration) = builder.GetServicesAndConfiguration();


services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();
var env = app.Environment;


if (env.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
