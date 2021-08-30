using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class DataAdapter : DbContext
  {
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Store> Stores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=StoreApplicationDB;user id =sqladmin;password=Password12345");
    }


  }
}