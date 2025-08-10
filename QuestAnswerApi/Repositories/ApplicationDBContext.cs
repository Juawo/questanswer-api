using Microsoft.EntityFrameworkCore;
using QuestAnswerApi.Models;
namespace QuestAnswerApi.Repositories
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
    }
}