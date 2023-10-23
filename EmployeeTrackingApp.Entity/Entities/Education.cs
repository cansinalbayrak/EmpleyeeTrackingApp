using EmployeeTrackingApp.Entity.Absract;
using EmployeeTrackingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingApp.Entity.Entities
{
    public class Education:BaseEntity
    {
        public string SchoolName { get; set; }
        public DateTime GraduationDate { get; set; }
        public Degree Degree { get; set; }
        public string Diploma { get; set; }
        public string Certificate { get; set; }
        public string CompanyTrainingDesc { get; set; }
        public int EmployeeId { get; set; }

        #region Navigation Property
        public Employee Employee { get; set; }
        #endregion
    }

}
