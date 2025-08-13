using ProjectTracker.Api.Abstractions.Endpoints;
using ProjectTracker.Infrastructure;
using ProjectTracker.Infrastructure.Database.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddEndpoints(typeof(Program).Assembly);

var allowedOrigins = builder.Configuration
    .GetSection("AllowedOrigins")
    .Get<string[]>() ?? Array.Empty<string>();


builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddCors(o =>
    o.AddDefaultPolicy(p => p
        .AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins(allowedOrigins)));


var app = builder.Build();

app.MapEndpoints();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.ApplyMigrations();
}

app.UseHttpsRedirection();

app.Run();
