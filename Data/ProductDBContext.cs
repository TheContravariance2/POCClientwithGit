using Microsoft.EntityFrameworkCore;
using POCClient.Models;

namespace POCClient.Data
{
    public class ProductDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server=DESKTOP-T27J4C9;Database=AZProductDB1;TrustServerCertificate=true; Integrated security=true;");
            //optionsBuilder.UseSqlServer("Data Source=host.docker.internal,8002;Initial Catalog=ProductDb;uid=SA;Pwd=password@12345#;TrustServerCertificate=True;");
            //optionsBuilder.UseSqlServer("Data Source=host.docker.internal,50017;Initial Catalog=ProductDb;uid=SA;Pwd=password@12345#;TrustServerCertificate=True;");

        }

        // Products will be table name in AZURE SQL server dynamically 
        public DbSet<Product> Products { get; set; } 

    }
}
