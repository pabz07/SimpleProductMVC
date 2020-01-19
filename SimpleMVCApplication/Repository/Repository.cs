using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleMVCApplication.Repository.Interface;
using SimpleMVCApplication.Models;
using System.Data.Entity;

namespace SimpleMVCApplication.Repository
{
    public class Repository<Model> : IRepository<Model> where Model : class
    {

        public SimpleApplication _dbContext = null;
        public DbSet<Model> model = null;

        public Repository()
        {
            this._dbContext = new SimpleApplication();
            model = _dbContext.Set<Model>();
        }

        public Repository(SimpleApplication _dbContext)
        {
            this._dbContext = _dbContext;
            model = _dbContext.Set<Model>();
        }

        // Get all list
        public IEnumerable<Model> GetAll()
        {
            return model.ToList();
        }

        // Find an specific entry
        public Model GetById(int id)
        {
            return model.Find(id);
        }

        // Add new Item to the database
        public int Insert(Model obj)
        {
            model.Add(obj);
            return this.Save();
        }

        // Update entry in the database
        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        // delete one entry in the database
        public int Update(Model obj)
        {
            model.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
            return this.Save();
        }

        // Save the Model to the database
        public int Delete(int id)
        {
            Model existing = this.GetById(id);
            model.Remove(existing);
            return this.Save();
        }
    }
}