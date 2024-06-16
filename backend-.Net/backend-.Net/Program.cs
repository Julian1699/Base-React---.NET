using backend_.Net.Infrastructure.Context;
using backend_.Net.Infrastructure.Repositories;
using backend_.Net.Application.Interfaces;
using backend_.Net.Application.Services;
using Microsoft.EntityFrameworkCore;
using backend_.Net.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Crear variable para la cadena de conexion
var connectionString = builder.Configuration.GetConnectionString("Connection");

// Registrar servicio para la conexion
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseNpgsql(connectionString)
);

builder.Services.AddControllers();

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:3000") // URL del frontend
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

// Registrar repositorios y servicios
builder.Services.AddScoped<IObjetoRepository, ObjetoRepository>();
builder.Services.AddScoped<IObjetoService, ObjetoService>();

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aplicar migraciones al iniciar
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Habilitar CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

