using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonNetCore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-DonNetCore-96863899-057e-4d93-a79b-e085981465db;Trusted_Connection=True;MultipleActiveResultSets=true";
        //    optionsBuilder.UseSqlServer(connectionString);

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
