using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class Salary:BaseEntity
    {
        public decimal Amount { get; set; }
        public int EmployeeId { get; set; }

        #region Navigation Propery
        public Employee Employee { get; set; }
        #endregion
    }
}


