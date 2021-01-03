namespace dim.Data
{
    using dim.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public ApplicationDbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connect = this.configuration["ConnectionStrings:Connection"];
                optionsBuilder.UseSqlServer(connect);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Photo> Photos { get; set; } 
    }
}
