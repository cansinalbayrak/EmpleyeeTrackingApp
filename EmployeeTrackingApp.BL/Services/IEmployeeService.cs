using EmployeeTrackingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.BL.Services
{
    public interface IEmployeeService : IService<Employee>
    {
        public void SetSalary(Employee employee);
        public bool PaymentAdvance(Employee employee, decimal advanceAmount, int term);
        public void SetMonthlyPayroll(Employee employee);
    }
}
