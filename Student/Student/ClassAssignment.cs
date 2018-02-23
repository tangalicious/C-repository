using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace ClassAssign
{
    public class ClassAssignment : DbContext
    {

        public ClassAssignment() : base()
        {

        }
        public virtual DbSet<Student> Students { get; set; }

    }
}



