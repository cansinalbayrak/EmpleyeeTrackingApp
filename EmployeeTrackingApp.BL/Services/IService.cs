using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.BL.Services
{
    public interface IService<T> where T : class, IEntity
    {
        T? GetById(int id);
        List<T> GetAll();
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);
        IQueryable<T> GetQueryable();
    }
}
