using Microsoft.EntityFrameworkCore;

namespace CPW219_AspnetMVC_CRUD_Debugging.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=cpw219Debugging;Trusted_Connection=True;");
        }

        public DbSet<Product> Product { get; set; }
    }
}
