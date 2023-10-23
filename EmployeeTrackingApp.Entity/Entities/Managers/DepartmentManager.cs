using EmployeeTrackingApp.BL.Services;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.BL.Managers
{
    public class DepartmentManager : BaseManager<Department>, IDepartmentService
    {
        public DepartmentManager(GenericRepository<Department> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
