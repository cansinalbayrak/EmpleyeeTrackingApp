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

namespace EmployeeTrackingAppForm.PL
{
    public partial class EmployeeDetail : Form
    {
        EmployeeProfileManager manager = new EmployeeProfileManager(new GenericRepository<EmployeeProfile>(new AppDbContext()));
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeProfile profile = new EmployeeProfile();
            profile.EmployeeId = Convert.ToInt32(textBox1.Text);
            profile.ResidingAdress = textBox2.Text;
            profile.CriminalRecord = textBox3.Text;
            profile.DriverLicense = textBox4.Text;
            profile.Contract = textBox5.Text;
            profile.CV = textBox6.Text;
            profile.JobApplication = textBox7.Text;
            profile.MarriageCertificate = textBox8.Text;
            profile.MilitaryRecord = textBox9.Text;
            profile.HealthReport = textBox10.Text;

            manager.Add(profile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = manager.GetAll();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Id + " " + item.Contract + " " + item.ResidingAdress + " " + item.CriminalRecord + " " + item.DriverLicense + " " + item.CV + " " + item.MarriageCertificate + " " + item.EmployeeId + " " + item.HealthReport);
            }
        }
    }
}
