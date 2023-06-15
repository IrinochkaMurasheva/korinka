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
        public DbSet<Buyer> buyers { get; set; }
        public DbSet<Seller> sellers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ms-sql-10.in-solve.ru; Database=1gb_slaynkassa; uid=1gb_slayndev; pwd=86443ad5dgh;Encrypt=False;TrustServerCertificate=False;");
        }


    }
}
