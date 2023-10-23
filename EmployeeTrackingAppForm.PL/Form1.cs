using EmployeeTrackingApp.BL.Managers;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;

namespace EmployeeTrackingAppForm.PL
{
    public partial class Form1 : Form
    {
        SystemUserManager userManager = new SystemUserManager(new GenericRepository<SystemUser>(new AppDbContext()));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemUser user = new SystemUser()
            {
                Username = textBox1.Text,
                Password = textBox2.Text,
            };
            userManager.Add(user);
            this.Close();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var isUserExist = userManager.IsUserExist(textBox1.Text);
            var isMailOk = userManager.IsValidEmail(textBox1.Text);
            var pass1 = userManager.IsStrongPassword(textBox2.Text);

            if (isMailOk)
            {
                if (isUserExist)
                {
                    label1.Text = "Bu mail adresi kullanýlýyor.";
                }
                else
                {
                    label1.Text = "Mail adresi uygun.";
                }

            }
            else
            {
                label1.Text = "Geçerli bir adresi girin.";
            }

            if (!isUserExist && isMailOk && pass1 && textBox2.Text == textBox3.Text)
            {
                button1.Enabled = true;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var pass1 = userManager.IsStrongPassword(textBox2.Text);

            if (pass1)
                label2.Text = "Güçlü þifre";
            else
                label2.Text = "Zayýf þifre";

            var validmail = userManager.IsValidEmail(textBox1.Text);
            var isExist = userManager.IsUserExist(textBox1.Text);
            var pass2 = userManager.IsStrongPassword(textBox2.Text);
            if (!isExist && validmail && pass2 && textBox2.Text == textBox3.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var pass1 = userManager.IsStrongPassword(textBox3.Text);
            var validmail = userManager.IsValidEmail(textBox1.Text);
            var isExist = userManager.IsUserExist(textBox1.Text);

            if (!isExist && validmail && pass1 && textBox2.Text == textBox3.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}