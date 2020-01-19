using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVCApplication.Repository.Interface
{
    public interface IRepository<Model> where Model : class
    {
        // Get all list
        IEnumerable<Model> GetAll();

        // Find an specific entry
        Model GetById(int id);

        // Add new Item to the database
        int Insert(Model obj);

        // Update entry in the database
        int Update(Model obj);

        // delete one entry in the database
        int Delete(int id);

        // Save the Model to the database
        int Save();
    }
}