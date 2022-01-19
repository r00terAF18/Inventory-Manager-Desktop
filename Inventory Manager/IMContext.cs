using Microsoft.EntityFrameworkCore;
using Inventory_Manager.Models;

public class IMContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public string DbPath { get; }

    public IMContext()
    {
        var folder = $@"C:\Users\{Environment.UserName}\Dropbox\";
        // var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(folder, "IM.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }
}