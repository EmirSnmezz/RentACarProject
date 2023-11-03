using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete.Entity_Framework
{
    public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Rent_A_Car_Project;Trusted_Connection=true");
        }

        public DbSet <Car> Car { get; set; }
        public DbSet <Brand> Brand { get; set; }
        public DbSet <Color> Color { get; set; }
    }
}
