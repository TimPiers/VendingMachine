﻿using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Domain.Business.Contracts.Repository;
using VendingMachine.Domain.Models;

namespace VendingMachine.Repository.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
    }
}
