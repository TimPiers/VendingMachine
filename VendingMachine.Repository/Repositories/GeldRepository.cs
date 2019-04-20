using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Repository;
using VendingMachine.Domain.Models;

namespace VendingMachine.Repository.Repositories
{
    public class GeldRepository : BaseRepository<Geld>, IGeldRepository
    {
        public Geld GetGeldByHoeveelheid(double hoeveelheid)
        {
            using (var context = CreateContext())
            {
                return context.Set<Geld>()
               .AsNoTracking()
               .Where(n => n.Valuta == hoeveelheid)
               .FirstOrDefault();
            }
        }

        public List<Geld> GetVoorraadGeld()
        {
            List<Geld> result = new List<Geld>();

            using (var context = CreateContext())
            {
                result = context.Set<Geld>()
               .AsNoTracking()
               .OrderByDescending(n => n.Kwantiteit)
               .ToList();
            }
            return result;
        }

        public void ChangeGeld(double hoeveelheid, int amount)
        {
            Geld geldObj = GetGeldByHoeveelheid(hoeveelheid);
            geldObj.Kwantiteit += amount;
            using (var context = CreateContext())
            {
                if (geldObj.Id > 0)
                { // Update
                    context.Set<Geld>().Attach(geldObj);
                    context.Entry(geldObj).State = EntityState.Modified;
                }
                context.SaveChanges();
            }

        }
    }
}
