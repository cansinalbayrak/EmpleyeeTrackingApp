using EmployeeTrackingApp.Entity.Absract;
using EmployeeTrackingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class Leave : BaseEntity
    {
        public LeaveType LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveStatus Status { get; set; }
        public int EmployeeId { get; set; }

        #region Navigation Property
        public Employee Employee { get; set; }
        #endregion


    }
}
