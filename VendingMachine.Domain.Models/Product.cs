using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace VendingMachine.Domain.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public byte[] Afbeelding { get; set; }
    }
}
