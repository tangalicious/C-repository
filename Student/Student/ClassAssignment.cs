using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace Student
{
    public class IntroDbContext : DbContext
    {

        public IntroDbContext() : base()
        {

        }
        public virtual DbSet<Student> Students { get; set; }

    }
}



