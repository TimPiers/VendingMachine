using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Repository;
using VendingMachine.Domain.Models;

namespace VendingMachine.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> result = new List<Product>();

            using (var context = CreateContext())
            {
                result = context.Set<Product>()
               .AsNoTracking()
               .OrderByDescending(n => n.Id)
               .ToList();
            }
            return result;
        }
    }
}
