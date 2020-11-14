using Evidencija.KonekcijaSaTabelama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencija.OstaleKlase
{
    public class StudentsPassedExams
    {
        public int Id { get; set; }
        public virtual Exam Exam { get; set; }
        public int Grade { get; set; }
        public string Date { get; set; }
    }
}
