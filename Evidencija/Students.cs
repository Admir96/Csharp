using Evidencija.KonekcijaSaTabelama;
using Evidencija.ReportDesigner;
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
    public partial class Students : Form
    {
        private DLWMSContent Baza = KonekcijaNaBazu.DB;
        public Students()
        {
            InitializeComponent();
            dgvStudent.AutoGenerateColumns = false;
        }
        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                LoadGridDate();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Student Load ---> " + ex.Message + " " + ex.InnerException?.Message);
            }         
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Registration NoviStudent = new Registration();
            NoviStudent.ShowDialog();
            LoadGridDate();
        }

        private void DgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form form = null;
            if (dgvStudent.SelectedRows.Count > 0)
            {           
                Student EditStudent = dgvStudent.SelectedRows[0].DataBoundItem as Student;
                if (EditStudent != null)
                {
                    if (e.ColumnIndex < 3)
                    {
                        form = new Registration(EditStudent);
                        form.ShowDialog();
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        form = new PassedExams(EditStudent);
                        form.ShowDialog();
                    }
                    else if(e.ColumnIndex == 4)
                    {
                        form = new Report(EditStudent);
                        form.ShowDialog();
                    }
                    LoadGridDate();
                }
            }
        }

        private void LoadGridDate()
        {
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = Baza.Student.ToList();

        }
    }
}
