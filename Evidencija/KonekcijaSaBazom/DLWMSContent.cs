using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Evidencija.KonekcijaSaTabelama;

namespace Evidencija
{
    public class DLWMSContent : DbContext
    {
        public DLWMSContent() : base("PutanjaDoBaze"){}

         public DbSet<Student> Student { get; set; }
         public DbSet<Exam> Exam { get; set; }
         public DbSet<StudentExam> StudentExam { get; set; }
         public DbSet<Gender> Gender { get; set; }

    }
}
      

    


