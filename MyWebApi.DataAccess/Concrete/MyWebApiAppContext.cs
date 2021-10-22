using Microsoft.EntityFrameworkCore;
using MyWebApiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApi.DataAccess.Concrete
{
   public class MyWebApiAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OLHGM4B\SQLEXPRESS;Database=MyWebApiAppDb;integrated security=true;");
        }

        public DbSet<User>  Users { get; set; }
        public DbSet<Address>  Addresses { get; set; }
        public DbSet<Company>  Companies { get; set; }
        public DbSet<Geo>  Geos { get; set; }

    }
}
