using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//service registration
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen().AddEndpointsApiExplorer();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
//middleware
app.MapControllers();
app.MapOpenApi();
app.MapScalarApiReference();
app.Run();
