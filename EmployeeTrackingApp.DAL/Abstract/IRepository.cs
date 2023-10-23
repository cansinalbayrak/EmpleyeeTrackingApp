using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.DAL.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        T? GetById(int id);
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> GetQueryable();
    }
}
