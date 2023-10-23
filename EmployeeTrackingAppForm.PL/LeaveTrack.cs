using EmployeeTrackingApp.BL.Managers;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using EmployeeTrackingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeTrackingAppForm.PL
{
    public partial class LeaveTrack : Form
    {
        LeaveManager manager = new LeaveManager(new GenericRepository<Leave>(new AppDbContext()));
        public LeaveTrack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Leave leave = new Leave();
            leave.EmployeeId = Convert.ToInt32(textBox1.Text);
            LeaveType type = (LeaveType)Enum.Parse(typeof(LeaveType), textBox2.Text, true);
            leave.LeaveType = type;
            LeaveStatus status = (LeaveStatus)Enum.Parse(typeof(LeaveStatus), textBox4.Text, true);
            leave.Status = status;
            leave.StartDate = Convert.ToDateTime(textBox3.Text);
            leave.EndDate = Convert.ToDateTime(textBox5.Text);
            manager.Add(leave);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = manager.GetAll();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.EmployeeId + " " + item.LeaveType + " " + item.Status + " " + item.StartDate + " " + item.EndDate);
            }
        }
    }
}
