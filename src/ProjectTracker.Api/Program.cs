using ProjectTracker.Infrastructure;
using ProjectTracker.Infrastructure.Database.Extensions;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddCors(o =>
  o.AddDefaultPolicy(p => p
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("https://localhost:7778", "http://localhost:7777"))); // Put in appsettings


var app = builder.Build();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
    return "test";
});

app.Run();
