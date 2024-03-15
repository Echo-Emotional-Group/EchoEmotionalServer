using Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbEchoEmotional> (c => c.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();

//app.MapGet("/", () => "Hello World!");

app.Run();
