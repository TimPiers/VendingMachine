using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Business;
using VendingMachine.Domain.Business.Contracts.Repository;
using VendingMachine.Domain.Models;
using VendingMachine.Repository.Repositories;

namespace VendingMachine.Domain.Business
{
    public class ProductService : IProductService
    {

        private ProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }
    }
}
