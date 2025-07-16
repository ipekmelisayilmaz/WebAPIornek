using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//service registration
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

//middleware
app.MapControllers();
app.MapOpenApi();
app.MapScalarApiReference();
app.Run();
