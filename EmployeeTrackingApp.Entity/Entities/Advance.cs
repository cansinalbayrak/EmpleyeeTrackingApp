using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class Advance:BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int Term { get; set; }
        public int EmployeeId { get; set; }

        #region Navigation Property
        public Employee Employee { get; set; }
        #endregion


    }
}
