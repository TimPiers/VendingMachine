using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Models;

namespace VendingMachine.Domain.Business.Contracts.Business
{
    public interface IVoorraadService
    {

        List<Voorraad> GetVoorraadProducts();

    }
}
