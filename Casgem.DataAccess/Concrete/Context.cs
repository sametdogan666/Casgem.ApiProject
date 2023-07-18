using Casgem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Casgem.DataAccess.Concrete;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LVPTDQG\SQLEXPRESS; initial catalog= CasgemApiDb; integrated security = true");
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
}