using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2EF
{
    public class IntroDbContext : DbContext {

        public IntroDbContext() : base()
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        
        }
        
    
    
}
