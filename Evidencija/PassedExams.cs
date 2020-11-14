using Evidencija.KonekcijaSaTabelama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija
{
    public partial class PassedExams : Form
    {
      private DLWMSContent Baza = KonekcijaNaBazu.DB;
      private Student NewStudent = new Student();
      const string Format = "dd/mm/yyyy";

        public PassedExams()
        {
            InitializeComponent();
            LoadExams();
            dgvExams.AutoGenerateColumns = false;
        }
        public PassedExams(Student Student) : this()
        {
            NewStudent = Student;
        }

        private void PassedExams_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {       
            try
            {
                StudentExam NewExam = new StudentExam();
                Exam SelectedExam = cmbExams.SelectedItem as Exam;
                CheckIfExamIsValid(SelectedExam);   
                NewExam.Exam = SelectedExam;
                NewExam.Date = dtpForExam.Value.ToString(Format);
                NewExam.Grade = int.Parse(txtGrade.Text);
                NewStudent.studentExam.Add(NewExam);
                Baza.SaveChanges();
                LoadDataGrid();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadExams()
        {
            cmbExams.DataSource = Baza.Exam.ToList();
            cmbExams.DisplayMember = "Name";
            cmbExams.ValueMember = "Id";
        }
        private void LoadDataGrid()
        {
            dgvExams.DataSource = null;
            dgvExams.DataSource = NewStudent.studentExam;
            
        }
        private void CheckIfExamIsValid(Exam SelectedExam)
        {
            if (NewStudent.studentExam.Where(x => x.Exam.Id == SelectedExam.Id).Count() > 0)
                throw new Exception($"there is {SelectedExam} allready in your DataBase {NewStudent}");
        }
    }
}
