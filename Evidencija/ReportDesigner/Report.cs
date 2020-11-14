using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Evidencija.KonekcijaSaTabelama;

namespace Evidencija.ReportDesigner
{
    public partial class Report : Form
    {
        private Student Student;

        public Report()
        {
            InitializeComponent();
        }

        public Report(Student student):this()
        {
            Student = student;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            if (Student != null)
            {
                ReportParameterCollection rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("Name", $"{Student.Name} {Student.Surname}"));
                rpc.Add(new ReportParameter("Index", "IB170256"));
             
                List<object> list = new List<object>();
                int i = 1;
                foreach (var studentExam in Student.studentExam)
                {
                    list.Add(new
                    {
                    Number = i++,
                    Grade = studentExam.Grade,
                    Name = studentExam.Exam.Name,
                    Date = studentExam.Date,
                    });        
                }                             
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = list;
                rv.LocalReport.DataSources.Add(rds);
                rv.LocalReport.SetParameters(rpc);
            }
            this.rv.RefreshReport();
        }


    }
}
