using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleMVCApplication.Models;
using SimpleMVCApplication.Repository.Interface;


namespace SimpleMVCApplication.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
    }
}