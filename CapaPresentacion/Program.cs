var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configura los servicios necesarios, incluidos los controladores.
builder.Services.AddControllers(); // Habilita el uso de controladores.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configura HTTPS redirection y mapeo de rutas.
app.UseHttpsRedirection();

app.UseAuthorization(); // Para futuras configuraciones de autenticación y autorización.

app.MapControllers(); // Permite que la aplicación reconozca y use controladores.

app.Run();
