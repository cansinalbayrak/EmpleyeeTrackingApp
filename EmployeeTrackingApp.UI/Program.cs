using EmployeeTrackingApp.BL.Managers;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;

namespace EmployeeTrackingApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.BirthDate = DateTime.Now;
            employee.Salary = 10;
            employee.Surname = "Test";
            employee.Name = "testad";
            employee.StartDate = DateTime.Now.AddDays(-70);
            employee.FatherName = "Test";
            employee.MaritialStatus = "evli";
            employee.MotherName = "Test";
            employee.TCNo = "tcno";
            employee.TotalAdvanceAmount = 5000;
            employee.SeniorityId = 1;
            employee.DepartmentId = 1;
            employee.BirthPlace = "ankara";
            employee.City = Entity.Enums.City.Adıyaman;
            employee.Gender = Entity.Enums.Gender.Kadın;
            employee.Contact = "telno";
            employee.EndDate = DateTime.Now.AddDays(300);
            EmployeeManager employeeManager = new EmployeeManager(new GenericRepository<Employee>(new AppDbContext()));
            employeeManager.Add(employee);

        }
    }
}