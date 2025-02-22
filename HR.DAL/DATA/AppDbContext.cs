using Microsoft.EntityFrameworkCore;
using HR.DAL.Models;
using Microsoft.Extensions.Configuration;


namespace HR.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

            this.Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  if (!optionsBuilder.IsConfigured)
          //  {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = "Server=localhost;Database=HRDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True";
                optionsBuilder.UseSqlServer(connectionString);

         //   }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define mappings for the 'User' entity
            modelBuilder.Entity<User>(entity =>
            {
                // Define table name if needed (optional)
                entity.ToTable("Users");

                entity.HasKey(e => e.Id);

                // Configure properties (example)
                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("Id");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsRequired();
                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsRequired();

            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                   .IsRequired()
                   .HasColumnName("Id");

                entity.Property(e => e.FirstName)
                   .HasMaxLength(50)
                   .IsRequired();

                entity.Property(e => e.MiddleName)
                   .HasMaxLength(50);

                entity.Property(e => e.LastName)
                   .HasMaxLength(50)
                   .IsRequired();

                entity.Property(e => e.Age)
                   .IsRequired();

                entity.Property(e => e.Gender)
                   .IsRequired();

                entity.Property(e => e.Address)
                   .HasMaxLength(200)
                   .IsRequired();
            });
        }
        public DbSet<User> Users { get; set; }
        public DbSet <Employee> Employees { get; set; }
    }
}
