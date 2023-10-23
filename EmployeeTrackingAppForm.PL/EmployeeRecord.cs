using EmployeeTrackingApp.BL.Managers;
using EmployeeTrackingApp.DAL.Context;
using EmployeeTrackingApp.DAL.Repository;
using EmployeeTrackingApp.Entity.Entities;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using EmployeeTrackingApp.Entity.Enums;

namespace EmployeeTrackingAppForm.PL
{
    public partial class EmployeeRecord : Form
    {
        public EmployeeRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager(new GenericRepository<Employee>(new AppDbContext()));
            Employee employee = new Employee();
            LoadImageFromFileDialogAndSetEmployeePhoto(employee, pictureBox1);
            employee.BirthDate = Convert.ToDateTime(textBox1.Text);
            employee.BirthPlace = textBox2.Text;
            City city = (City)Enum.Parse(typeof(City), textBox3.Text, true);
            employee.City = city;
            employee.Name = textBox4.Text;
            employee.Surname = textBox5.Text;
            employee.MaritialStatus = textBox6.Text;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), textBox7.Text, true);
            employee.Gender = gender;
            employee.StartDate = Convert.ToDateTime(textBox8.Text);
            employee.EndDate = Convert.ToDateTime(textBox9.Text);
            employee.Contact = textBox10.Text;
            employee.DepartmentId = Convert.ToInt32(textBox11.Text);
            employee.SeniorityId = Convert.ToInt32(textBox12.Text);
            employee.TCNo = textBox13.Text;
            employee.MotherName = textBox14.Text;
            employee.FatherName = textBox15.Text;
            employeeManager.SetSalary(employee);
            employee.TotalAdvanceAmount = Convert.ToDecimal(textBox16.Text);

            employeeManager.Add(employee);

        }
        private void LoadImageFromFileDialogAndSetEmployeePhoto(Employee employee, PictureBox pictureBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|Tüm Dosyalar (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                try
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(selectedFilePath);
                    pictureBox.Image = image;

                    byte[] imageBytes = ImageToByteArray(image);
                    employee.Photo = imageBytes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim yükleme hatası: " + ex.Message);
                }
            }
        }
        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void EmployeeRecord_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }

}

