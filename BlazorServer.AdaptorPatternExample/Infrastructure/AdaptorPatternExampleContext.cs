using BlazorServer.AdaptorPatternExample.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace BlazorServer.AdaptorPatternExample.Infrastructure
{
    public class AdaptorPatternExampleContext : DbContext
    {

        public AdaptorPatternExampleContext(DbContextOptions<AdaptorPatternExampleContext> options) : base(options) { }

        DbSet<Fruit> Fruits => Set<Fruit>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fruit>().HasData(
                new Fruit { Id = 1, Calories = 96, Carbohydrates = 22, Description = "Banana", ExternalId = 2, Family = "Musaceae", Fat = 0.2,
                    Genus = "Musa", Name = "Banana", Order = "Zingiberales", Protein = 0, RquestedDate = DateTime.Now, Sugar = 17.2 }
            );
        }
    }
}
