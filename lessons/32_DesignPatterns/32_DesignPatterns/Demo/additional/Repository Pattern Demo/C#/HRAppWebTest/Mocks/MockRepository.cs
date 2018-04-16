using System;
using System.Collections.Generic;
using System.Linq;
using HRApp.Web.Repository;


namespace HRApp.Web.Test
{
    //Mock repository class that implements IRepository inteface on in-memory collection
    public abstract class MockRepository<T> : IRepository<T> where T : class
    {
        private Dictionary<Type, List<T>> inMemoryTables = new Dictionary<Type, List<T>>();

        public List<T> Table
        {
            get
            {
                return inMemoryTables[typeof(T)];
            }
        }

        protected void AddTable()
        {
            List<T> table = new List<T>();
            inMemoryTables.Add(typeof(T), table);
        }

        #region IRepository<T> Members

        public IQueryable<T> Query()
        {
            return this.Table.AsQueryable();
        }

        public void Add(T entity)
        {
            this.Table.Add(entity);
        }

        public void Remove(T entity)
        {
            this.Table.Remove(entity);
        }

        public void Attach(T current, T original)
        {            
        }

        public void Attach(T current)
        {         
        }

        public void SubmitChanges()
        {         
        }

        #endregion
    }
}
