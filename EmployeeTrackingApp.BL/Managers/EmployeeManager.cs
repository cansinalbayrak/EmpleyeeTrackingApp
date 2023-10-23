using EmployeeTrackingApp.BL.Services;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.BL.Managers
{
    public class EmployeeManager : BaseManager<Employee>, IEmployeeService
    {
        public EmployeeManager(GenericRepository<Employee> repository) : base(repository)
        {
            _repository = repository;
        }
        public void SetSalary(Employee employee)
        {
            Salary salary = new Salary();
            salary.EmployeeId = employee.Id;
            int department = employee.DepartmentId;
            int seniorityLevel = employee.SeniorityId;

            switch (department)
            {
                case 1:
                    switch (seniorityLevel)
                    {
                        case 1:
                            salary.Amount = 5000;
                            break;
                        case 2:
                            salary.Amount = 6000;
                            break;
                        case 3:
                            salary.Amount = 7000;
                            break;
                        case 4:
                            salary.Amount = 8000;
                            break;
                        default:
                            salary.Amount = 5000;
                            break;
                    }
                    break;

                case 2:
                    switch (seniorityLevel)
                    {
                        case 1:
                            salary.Amount = 6000;
                            break;
                        case 2:
                            salary.Amount = 7000;
                            break;
                        case 3:
                            salary.Amount = 8000;
                            break;
                        case 4:
                            salary.Amount = 9000;
                            break;
                        default:
                            salary.Amount = 6000;
                            break;
                    }
                    break;
                case 3:
                    switch (seniorityLevel)
                    {
                        case 1:
                            salary.Amount = 10000;
                            break;
                        case 2:
                            salary.Amount = 11000;
                            break;
                        case 3:
                            salary.Amount = 12000;
                            break;
                        case 4:
                            salary.Amount = 13000;
                            break;
                        default:
                            salary.Amount = 10000;
                            break;
                    }
                    break;

                default:
                    salary.Amount = 5000;
                    break;
            }


        }
        public bool PaymentAdvance(Employee employee, decimal advanceAmount, int term)
        {
            DateTime startDate = employee.StartDate;
            DateTime currentDate = DateTime.Now;

            TimeSpan trialPeriod = currentDate - startDate;
            if (trialPeriod.TotalDays < 60)
            {
                return false;
            }

            decimal totalAdvanceAmount = employee.TotalAdvanceAmount;
            totalAdvanceAmount += advanceAmount;

            if (totalAdvanceAmount > 2 * employee.Salary)
            {
                return false;
            } 
            if (term > 12)
            {
                return false;
            }

            Advance advance = new Advance
            {
                EmployeeId = employee.Id,
                Amount = advanceAmount,
                Term = term,
                PaymentDate = currentDate
            };

            using (var dbContext = new AppDbContext())
            {
                dbContext.Advances.Add(advance);
                dbContext.SaveChanges();
            }

            return true;
        }
        public void SetMonthlyPayroll(Employee employee)
        {
            
            DateTime startDate = employee.StartDate;
            DateTime currentDate = DateTime.Now;

            TimeSpan employmentDuration = currentDate - startDate;

            if (employmentDuration.TotalDays >= 30)
            {
                decimal baseSalary = employee.Salary;
                Payroll payroll = new Payroll
                {
                    SalaryAmount = baseSalary,
                    Date = currentDate,
                    EmployeeId = employee.Id
                };
                using (var dbContext = new AppDbContext())
                {
                    dbContext.Payrolls.Add(payroll);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("Henüz 30 günlük çalışma süresi yok bordro eklenemez.");
            }
        }
    }
}
