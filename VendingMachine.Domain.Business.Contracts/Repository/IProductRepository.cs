using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Models;

namespace VendingMachine.Domain.Business.Contracts.Repository
{
    public interface IProductRepository
    {

        List<Product> GetProducts();

    }
}
