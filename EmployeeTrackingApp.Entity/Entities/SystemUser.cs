using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class SystemUser:BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public bool IsOwner { get; set; }
        public int EmployeeId { get; set; }

        #region Navigation Property
        public Employee Employee { get; set; }
        #endregion

    }

}
