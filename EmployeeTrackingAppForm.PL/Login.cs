using EmployeeTrackingApp.BL.Managers;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Login : Form
    {
        SystemUserManager userManager = new SystemUserManager(new GenericRepository<SystemUser>(new AppDbContext()));
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = userManager.IsAccountTrue(textBox1.Text, textBox2.Text);

            if (id == -1)
            {
                MessageBox.Show("Hatalı giriş");
                return;
            }
            else
            {
                Description description = new Description();
                description.Show();
                this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
