using Microsoft.EntityFrameworkCore;
using WebScraper_BackEnd.Entities;

namespace TakeHomeAssessment_BindySt.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<SearchEntity> Searches { get; set; }

    }
}