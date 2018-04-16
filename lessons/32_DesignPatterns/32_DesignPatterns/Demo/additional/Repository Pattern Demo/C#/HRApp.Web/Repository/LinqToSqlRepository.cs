using System;
using System.Linq;
using System.Data.Linq;

namespace HRApp.Web.Repository
{
    public class LinqToSqlRepository<T> : IRepository<T> where T : class
    {
        private DataContext context;

        public LinqToSqlRepository(DataContext ctxt)
        {
            this.context = ctxt;
        }

        #region IRepository<T> Members

        public IQueryable<T> Query()
        {
            return this.context.GetTable<T>();
        }

        public void Add(T entity)
        {
            this.context.GetTable<T>().InsertOnSubmit(entity);
        }

        public void Remove(T entity)
        {
            this.context.GetTable<T>().DeleteOnSubmit(entity);
        }

        public void Attach(T current, T original)
        {
            this.context.GetTable<T>().Attach(current, original);
        }

        public void Attach(T current)
        {
            this.context.GetTable<T>().Attach(current);
        }

        public void SubmitChanges()
        {
            this.context.SubmitChanges();
        }

        #endregion   
    }
}
