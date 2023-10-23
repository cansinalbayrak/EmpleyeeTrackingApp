using EmployeeTrackingApp.BL.Services;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.BL.Managers
{
    public class BaseManager<T> : IService<T> where T : class, IEntity
    {
        protected GenericRepository<T> _repository;
        public BaseManager(GenericRepository<T> repository)
        {
            _repository = repository;
        }
        public void Add(T entity) => _repository.Add(entity);

        public void Delete(T entity) => _repository?.Delete(entity);

        public T? GetById(int id) => _repository.GetById(id);

        public List<T> GetAll() => _repository.GetAll();
        public IQueryable<T> GetQueryable() => _repository.GetQueryable();

        public void Update(T entity) => Update(entity);
    }
}
