using Microsoft.EntityFrameworkCore;
using QuestAnswerApi.Repositories;
using QuestAnswerApi.Repositories.CardRepositories;
using QuestAnswerApi.Service.CardServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<CardRepository>();
builder.Services.AddScoped<ICardServices, CardServices>();
var app = builder.Build();
app.MapControllers();
app.Run();