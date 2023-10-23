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
    public partial class EducationTrack : Form
    {
        EducationManager manager = new EducationManager(new GenericRepository<Education>(new AppDbContext()));
        public EducationTrack()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.EmployeeId = Convert.ToInt32(textBox1.Text);
            education.SchoolName = textBox2.Text;
            Degree degree = (Degree)Enum.Parse(typeof(Degree), textBox3.Text, true);
            education.Degree = degree;
            education.Diploma = textBox4.Text;
            education.GraduationDate = Convert.ToDateTime(textBox5.Text);
            education.CompanyTrainingDesc = textBox6.Text;
            education.Certificate = textBox7.Text;
            manager.Add(education);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = manager.GetAll();
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Id + " " + item.SchoolName + " " + item.GraduationDate + " " + item.Degree + " " + item.Certificate + " " + item.CompanyTrainingDesc + " " + item.Diploma + " " + item.EmployeeId);
            }
        }
    }
}
