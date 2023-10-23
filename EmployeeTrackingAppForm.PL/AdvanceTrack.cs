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
    public partial class AdvanceTrack : Form
    {
        public AdvanceTrack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManager manager = new EmployeeManager(new GenericRepository<Employee>(new AppDbContext()));
            Employee employee = new Employee();
            employee.Name = textBox1.Text;
            decimal amount = Convert.ToDecimal(textBox2.Text);
            int term = Convert.ToInt32(textBox3.Text);
            var data = manager.PaymentAdvance(employee, amount, term);
            if (!data) MessageBox.Show("Avans miktarı maksimum 2 maaş olabilir ve avans vadesi maksimum 12 ay olabilir");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvanceManager manager = new AvanceManager(new GenericRepository<Advance>(new AppDbContext()));
            var data = manager.GetAll();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.PaymentDate + " " + item.Amount + " " + item.Term + " " + item.EmployeeId);
            }
        }
    }
}
