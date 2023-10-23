using EmployeeTrackingApp.BL.Managers;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTrackingAppForm.PL
{
    public partial class EmployeeList : Form
    {
        EmployeeManager manager = new EmployeeManager(new GenericRepository<Employee>(new AppDbContext()));
        EmployeeProfileManager manager2 = new EmployeeProfileManager(new GenericRepository<EmployeeProfile>(new AppDbContext()));
        EducationManager manager3 = new EducationManager(new GenericRepository<Education>(new AppDbContext()));
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = manager.GetAll();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Id+" "+item.Name + " " + item.Surname + " " + item.TCNo + " " + item.Gender + " " + item.Contact + " " + item.BirthDate + " " + item.BirthPlace + " " + item.City + " " + item.DepartmentId + " " + item.EndDate + " " + item.MotherName + " " + item.FatherName + " " + item.MaritialStatus + " " + item.SeniorityId + " " + item.Salary + " " + item.TotalAdvanceAmount);
            }
        }

        
    }
}
