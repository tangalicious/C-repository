﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssign
{
    public class Student
    { 
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Major { get; set; }
        [Required]
        [MaxLength(30)]
        public string College { get; set; }
        public int GradYear { get; set; }
        public bool GradWithHonors { get; set; }
        public bool AlumniDonor { get; set; }
        
    }
}
