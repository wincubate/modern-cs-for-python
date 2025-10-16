using ShortR.Api;
using ShortR.Infrastructure;
using ShortR.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddPresentation()
    .AddInfrastructure()
    .AddApplication()
    ;

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseExceptionHandler();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
