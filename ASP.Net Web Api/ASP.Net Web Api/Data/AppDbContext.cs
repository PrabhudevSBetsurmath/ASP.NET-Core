using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Web_Api.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "English", Description = "English" },
                new Language() { Id = 2, Title = "Hindi", Description = "Hindi" }
            );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get;set; }
    }
}
