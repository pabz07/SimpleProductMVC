using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleMVCApplication.Models;
using SimpleMVCApplication.Repository.Interface;

namespace SimpleMVCApplication.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        // search Product
        public IEnumerable<Product> SearchProduct(string search)
        {
            return _dbContext.Products.Where(prod => prod.Name.Contains(search)).ToList();
        }
    }
}