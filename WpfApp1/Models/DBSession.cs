using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class DBSession : DbContext
    {

        public DBSession()
        {
        }

        public DBSession(DbContextOptions<DBSession> options) : base(options)
        {
            
        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Buyer> buyers { get; set; }
        public DbSet<Seller> sellers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Status> status { get; set; }
        public DbSet<Category> categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=master2;Trusted_Connection=True");
        }


    }
}
