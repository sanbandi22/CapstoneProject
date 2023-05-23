using Microsoft.EntityFrameworkCore;
namespace CapstoneProject_Backend.Models
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Users> Userss { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BSC-PG02KEAN\\SQLEXPRESS;Database=CapstoneProject_ABCHealthcare;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
