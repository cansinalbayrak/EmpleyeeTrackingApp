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
    public class AvanceManager : BaseManager<Advance>, IAdvanceService
    {
        public AvanceManager(GenericRepository<Advance> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
