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
    public class SeniorityManager : BaseManager<Seniority>, ISeniorityService
    {
        public SeniorityManager(GenericRepository<Seniority> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
