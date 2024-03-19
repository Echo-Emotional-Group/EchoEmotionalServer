using Contexts;
using Microsoft.EntityFrameworkCore;
using Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbEchoEmotional> (c => c.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<PostService>();
builder.Services.AddScoped<EmotionService>();
builder.Services.AddScoped<ReactionService>();

builder.Services.AddHttpClient();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
    builder =>
    {
        builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
    });
});

builder.Services.AddControllers()
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        });

var app = builder.Build();

app.UseRouting();
app.UseCors("AllowAllOrigins");
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();


//app.MapGet("/", () => "Hello World!");

app.Run();