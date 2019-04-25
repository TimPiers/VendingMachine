using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Repository;
using VendingMachine.Domain.Models;

namespace VendingMachine.Repository.Repositories
{
    public class VoorraadRepository : BaseRepository<Voorraad>, IVoorraadRepository
    {
        public List<Voorraad> GetVoorraadProducts()
        {
            List<Voorraad> result = new List<Voorraad>();

            using (var context = CreateContext())
            {
                result = context.Set<Voorraad>()
               .AsNoTracking()
               .OrderByDescending(n => n.Id)
               .ToList();
            }
            return result;
        }
    }
}
