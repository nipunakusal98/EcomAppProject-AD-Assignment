using EcomAppProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomApp.Data
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure other relationships

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AntivirusSoftware> AntivirusSoftwares { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerConfiguration> CustomerConfigurations { get; set; }
        public DbSet<CustomerConfiguredModelOrder> CustomerConfiguredModelOrders { get; set; }
        public DbSet<CustomerConfiguredModelPayment> CustomerConfiguredModelPayments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<VGA> VGAs { get; set; }

    }
}
