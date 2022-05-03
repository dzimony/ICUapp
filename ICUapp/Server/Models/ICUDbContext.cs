using ICUapp.Shared;
using Microsoft.EntityFrameworkCore;

namespace ICUapp.Server.Models
{
    public class ICUDbContext:DbContext
    {
        public ICUDbContext(DbContextOptions<ICUDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MyConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
