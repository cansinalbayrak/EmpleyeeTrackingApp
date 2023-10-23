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
    public partial class DepartmentSenioritySalary : Form
    {
        public DepartmentSenioritySalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentManager departmentManager = new DepartmentManager(new GenericRepository<Department>(new AppDbContext()));
            Department department = new Department();
            department.Name = textBox1.Text;
            department.Description = textBox2.Text;
            departmentManager.Add(department);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeniorityManager manager = new SeniorityManager(new GenericRepository<Seniority>(new AppDbContext()));
            Seniority seniority = new Seniority();
            seniority.Name = textBox3.Text;
            seniority.Description = textBox4.Text;
            manager.Add(seniority);
        }
    }
}
