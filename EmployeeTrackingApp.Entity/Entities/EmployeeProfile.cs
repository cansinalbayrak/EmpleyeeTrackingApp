using EmployeeTrackingApp.Entity.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class EmployeeProfile:BaseEntity
    {
        public string ResidingAdress { get; set; }
        public string HealthReport { get; set; }
        public string CriminalRecord { get; set; }
        public string DriverLicense { get; set; }
        public string Contract { get; set; }
        public string CV { get; set; }
        public string JobApplication { get; set; }
        public string MarriageCertificate { get; set; }
        public string MilitaryRecord { get; set; }
        public int EmployeeId { get; set; }

        #region Navigation Property
        public Employee Employee { get; set; }
        #endregion


    }
}
