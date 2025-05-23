using AuthApi.Core.Interfaces; // для IAuthService
using AuthApi.Core.DTOs;
using AuthApi.Application.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.Run();

