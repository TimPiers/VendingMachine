using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace VendingMachine.Repository
{
    public class MachineContext : DbContext
    {

        public MachineContext()
           : base(@"Data Source=(LocalDb)\SoftwareDevelopment;Initial Catalog=VendingMachine;User Id=DevUser;Password=root;MultipleActiveResultSets=true;Connect Timeout=60;")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Location>().ToTable("Locations", "Admin");


        }

    }
}
