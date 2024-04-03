using LoansApplication.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LoansApplication.API.Data.Context
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoanType>().ToTable(nameof(LoanType));
            modelBuilder.Entity<LoanType>().HasKey(x => x.Id);

            modelBuilder.Entity<Customer>().ToTable(nameof(Customer));
            modelBuilder.Entity<Customer>().HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }


    }
}
