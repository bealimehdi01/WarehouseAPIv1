using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configure MySQL Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<WarehouseDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger in all environments (useful for debugging in production)
app.UseSwagger();
app.UseSwaggerUI();

// Use HTTPS redirection
app.UseHttpsRedirection();
app.UseAuthorization();

// Use CORS policy
app.UseCors("AllowAll");

// Ensure the app listens on Railway's assigned port
var port = Environment.GetEnvironmentVariable("PORT") ?? "80";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapControllers();
app.Run();
