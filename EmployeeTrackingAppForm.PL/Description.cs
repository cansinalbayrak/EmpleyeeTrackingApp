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
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDetail employeed = new EmployeeDetail();
            employeed.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeRecord employeer = new EmployeeRecord();
            employeer.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DepartmentSenioritySalary dss = new DepartmentSenioritySalary();
            dss.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdvanceTrack at = new AdvanceTrack();
            at.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LeaveTrack lt = new LeaveTrack();
            lt.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PayrollTrack payrollTrack = new PayrollTrack();
            payrollTrack.Show();
            this.Close();
        }

        private void Description_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EducationTrack track = new EducationTrack();
            track.Show();
            this.Close();
        }
    }
}
