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
    public class SalaryManager : BaseManager<Salary>, ISalaryService
    {
        public SalaryManager(GenericRepository<Salary> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
