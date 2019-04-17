using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Domain.Models
{
    public class Bestelling
    {

        public int Id { get; set; }
        public double Bedrag { get; set; }
        public DateTime datum { get; set; }

        public int Product_Id { get; set; }
        public Product Product { get; set; }

    }
}
