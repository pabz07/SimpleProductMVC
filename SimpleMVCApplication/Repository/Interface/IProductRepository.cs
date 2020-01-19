using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVCApplication.Models;

namespace SimpleMVCApplication.Repository.Interface
{
    interface IProductRepository : IRepository<Product>
    {
        // search product
        IEnumerable<Product> SearchProduct(string search);
    }
}
