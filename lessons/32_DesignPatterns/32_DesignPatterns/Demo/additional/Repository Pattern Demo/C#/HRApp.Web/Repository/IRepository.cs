using System;
using System.Linq;
using System.Data.Linq;

namespace HRApp.Web.Repository
{  
    public interface IRepository<T> 
    {
        IQueryable<T> Query();

        void Add(T entity);

        void Remove(T entity);

        void Attach(T current, T original);

        void Attach(T current);

        void SubmitChanges();
    }  
}
