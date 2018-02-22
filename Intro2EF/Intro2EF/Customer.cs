using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2EF
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string City { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }


    }
}
