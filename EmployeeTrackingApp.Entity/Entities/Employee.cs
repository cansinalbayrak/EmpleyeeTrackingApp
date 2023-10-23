using EmployeeTrackingApp.Entity.Absract;
using EmployeeTrackingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            Educations = new();
            Leaves = new();
            Advances = new();
            Payrolls = new();
            Salaries = new();
        }
        public byte[] Photo { get; set; }
        public string TCNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public City City { get; set; }
        public string MaritialStatus { get; set; }
        public Gender Gender { get; set; }
        public string Contact { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DepartmentId { get; set; }
        public int SeniorityId { get; set; }
        public decimal Salary { get; set; } 
        public decimal TotalAdvanceAmount { get; set; }

        #region Navigation Property
        public SystemUser SystemUser { get; set; }
        public Department Department { get; set; }
        public Seniority Seniority { get; set; }
        public EmployeeProfile EmployeeProfile { get; set; }
        public List<Education> Educations { get; set; }
        public List<Leave> Leaves { get; set; }
        public List<Advance> Advances { get; set; }
        public List<Payroll> Payrolls { get; set; }
        public List<Salary> Salaries { get; set; }
        #endregion
    }

}

