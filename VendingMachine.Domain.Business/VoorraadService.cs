using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Business;
using VendingMachine.Domain.Models;
using VendingMachine.Repository.Repositories;

namespace VendingMachine.Domain.Business
{
    public class VoorraadService : IVoorraadService
    {
        private VoorraadRepository voorraadRepository;

        public VoorraadService()
        {
            voorraadRepository = new VoorraadRepository();
        }
        public List<Voorraad> GetVoorraadProducts()
        {
            return voorraadRepository.GetVoorraadProducts();
        }
    }
}
