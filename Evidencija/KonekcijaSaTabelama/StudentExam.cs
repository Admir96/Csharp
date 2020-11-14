using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija.KonekcijaSaTabelama
{
    [Table("StudentExam")]
    public class StudentExam
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }
        public int Grade { get; set; }
        public string Date { get; set; }

    }
}
