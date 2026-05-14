using Microsoft.EntityFrameworkCore;
using QuestAnswerApi.Interfaces;
using QuestAnswerApi.Middlewares;
using QuestAnswerApi.Repositories;
using QuestAnswerApi.Repositories.CardRepositories;
using QuestAnswerApi.Service.CardServices;
using QuestAnswerApi.Services;

var builder = WebApplication.CreateBuilder(args);
//
// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowAll", policy =>
//     {
//         policy.AllowAnyOrigin()
//             .AllowAnyMethod()
//             .AllowAnyHeader();
//     });
// });

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddTransient<IApiKeyValidation, ApiKeyValidation>();
builder.Services.AddScoped<CardRepository>();
builder.Services.AddScoped<ICardServices, CardServices>();

var app = builder.Build();
app.UseMiddleware<ApiKeyMiddleware>();
// app.UseCors("AllowAll");

app.MapControllers();
app.Run();