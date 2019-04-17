using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Domain.Models
{
    public class Voorraad
    {

        public int Id { get; set; }
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        public int Kwantiteit { get; set; }
    }
}
