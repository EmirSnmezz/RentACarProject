﻿using Entities.Concrete;
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
            optionsBuilder.UseSqlServer(@"Server=EMIRSNMEZ;Database=RentACarProjectDB;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet <Car> Cars { get; set; }
        public DbSet <Brand> Brands { get; set; }
        public DbSet <Color> Colors { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
