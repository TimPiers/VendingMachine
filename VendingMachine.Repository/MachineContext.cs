using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using VendingMachine.Domain.Models;

namespace VendingMachine.Repository
{
    public class MachineContext : DbContext
    {

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Voorraad> Voorraads { get; set; }

        public MachineContext()
           : base(@"Data Source=(LocalDb)\SoftwareDevelopment;Initial Catalog=VendingMachine;User Id=VendingUser;Password=VendingUser;MultipleActiveResultSets=true;Connect Timeout=60;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapping to diffrent tables
            modelBuilder.Entity<Product>().ToTable("Producten", "Machine");
            modelBuilder.Entity<Bestelling>().ToTable("Bestellingen", "Machine");
            modelBuilder.Entity<Geld>().ToTable("Voorraad_Geld", "Machine");
            modelBuilder.Entity<Voorraad>().ToTable("Voorraad_Producten", "Machine");


        }

    }
}
