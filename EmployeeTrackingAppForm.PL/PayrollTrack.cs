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
    public partial class PayrollTrack : Form
    {
        EmployeeManager manager = new EmployeeManager(new GenericRepository<Employee>(new AppDbContext()));
        PayrollManager manager1 = new PayrollManager(new GenericRepository<Payroll>(new AppDbContext()));
        public PayrollTrack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Text);
            Employee employee = manager.GetById(id);
            manager.SetMonthlyPayroll(employee);
            var data = manager1.GetAll().Where(x=>x.EmployeeId == id).ToList();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Date + " " + item.SalaryAmount);
            }
        }
    }
}
