using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Checkings : Account //Treat a Checkings like an Account
    {
        public int LastCheckNumber { get; set; }

        public override string ToPrint()
        {
            string message = base.ToPrint();
            return message + ", Lastcheck=" + LastCheckNumber.ToString();
        }


        //Withdraws require check #
        //public void Withdraw(double amount);
    }
}
