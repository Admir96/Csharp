using Evidencija.KonekcijaSaTabelama;
using Evidencija.OstaleKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija
{
    public partial class Registration : Form
    {
        private DLWMSContent Baza = KonekcijaNaBazu.DB;
        private Student student = new Student();
        private bool edit = false;

        public Registration()
        {
            InitializeComponent();            
        }

        public Registration(Student student) : this()
        {
           this.student = student;
           LoadDataFromEdit(student);
           edit = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGender();
        }

        private void BtnPicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (opnFileDialog.ShowDialog() == DialogResult.OK)

                {
                    string Putanja = opnFileDialog.FileName;
                    Image image = Image.FromFile(Putanja);
                    imgReg.Image = image;
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            char Prazan = new char();
            if (txtPassword.PasswordChar == Prazan)
                txtPassword.PasswordChar = '*';
            else
                txtPassword.PasswordChar = Prazan;

        }

        private void BtnReg_Click(object sender, EventArgs e)

        {
            if (Required() == true)
          {
           
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.Gender = cmbGender.SelectedItem as Gender;
            student.Picture = ImgHalper.FromImageToByte(imgReg.Image);
            student.Password = txtPassword.Text;
            Baza.SaveChanges();
            Close();

                if (edit == false)
                {
                    Baza.Student.Add(student);
                    DialogResult = DialogResult.OK;
                    Baza.SaveChanges();
                    MessageBox.Show(" You are now a part of our team! ");
                }
                else
                {
                    Baza.Entry(student).State = EntityState.Modified;
                    Baza.SaveChanges();
                    MessageBox.Show($" Your data were updated {txtName.Text}");
                }
          }
         
        }


        private bool Required()
        {
            return Validation.RequiredEntry(err, txtName, " You forgot to type your name ") &&
                   Validation.RequiredEntry(err, txtSurname, " You forgot to type your Surname ") &&
                   Validation.RequiredEntry(err, txtPassword, " You forgot to type your Password") &&
                   Validation.RequiredEntry(err, imgReg, " You forgot to set a Picture") &&
                    Validation.RequiredEntry(err, cmbGender, " You are not allowed to type in a Gender ");

        }
        private void LoadGender()
        {
            try
            {
                cmbGender.DataSource = Baza.Gender.ToList();              
                cmbGender.DisplayMember = "Name";
                cmbGender.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Gender eror ---> "+ ex.Message + " " + ex.InnerException?.Message);
            }
        }
        private void LoadDataFromEdit( Student student)
        {
            txtName.Text = student.Name;
            txtSurname.Text = student.Surname;
            cmbGender.SelectedValue = student.Gender.Id;
            imgReg.Image = ImgHalper.FromByteToImage(student.Picture);
            txtPassword.Text = student.Password;
        }
    }
}
