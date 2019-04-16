using System;

namespace VendingMachine.Domain.Models
{
    public class BaseClass
    {

        public DateTime TimeCreated { get; set; }

        public string UserCreated { get; set; }

        public DateTime TimeModified { get; set; }

        public string UserModified { get; set; }

    }
}
