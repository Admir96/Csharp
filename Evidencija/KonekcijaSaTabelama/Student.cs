using Evidencija.OstaleKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija.KonekcijaSaTabelama
{
    [Table("Student")]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Gender Gender  { get; set; }
        public byte[] Picture { get; set; }
        public string Password { get; set; }

        public List<StudentsPassedExams> PassedExams { get; set; } = new List<StudentsPassedExams>();
        public virtual List<StudentExam> studentExam { get; set; } = new List<StudentExam>();

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
