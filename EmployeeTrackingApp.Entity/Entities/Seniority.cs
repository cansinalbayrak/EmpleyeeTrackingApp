using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class Seniority:BaseEntity
    {
        public Seniority()
        {
            Employees = new();
        }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Navigation Propery
        public List<Employee> Employees { get; set; }
        #endregion
    }

}
