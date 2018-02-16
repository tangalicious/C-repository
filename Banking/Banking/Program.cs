using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{    class Program
    {   static void Main(string[] args)
        {
            Account acct1 = new Account();
            acct1.Id = 1;
            acct1.Description = "My first checking account";
            acct1.Balance = 0.0;
            acct1.Owner = new Customer(100, "Greg Doud");
          
            acct1.Deposit(5.00);
            Console.WriteLine(acct1.ToPrint());

            acct1.Deposit(-5.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + " should be 0");

            acct1.Withdraw(-5.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + " should be 10.00");

            acct1.Withdraw(5000.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + " should be -4995.00");

            Savings sav2 = new Savings();
            sav2.Id = 2;
            sav2.Description = "My first savings account";
            sav2.Balance = 0.0;
            sav2.Owner = new Customer(101, "Lisa S.");
            sav2.IntRate = 0.12;
            sav2.Deposit(1000.00);

            Console.WriteLine(sav2.ToPrint());

            Checkings chk3 = new Checkings();
            chk3.Id = 3;
            chk3.Description = "My first checking account";
            chk3.Balance = 0.0;
            chk3.Owner = new Customer(102, "Denise B.");

            chk3.Deposit(2000.00);

            Checkings chk4 = new Checkings();
            chk4.Id = 4;
            chk4.Description = "My first checking account";
            chk4.Balance = 0.0;
            chk4.Owner = new Customer(102, "Kool B.");

            chk4.Deposit(2000.00);

            Savings chk5 = new Savings();
            chk5.Id = 5;
            chk5.Description = "My first checking account";
            chk5.Balance = 0.0;
            chk5.Owner = new Customer(102, "Rich B.");
            chk5.IntRate = 0.12;

            chk5.Deposit(2000.00);

            Investment inv1 = new Investment();
            inv1.Deposit(500.00);

            IAccountStatement[] accounts = {chk4, chk5, chk3, inv1};

            double grandTotal = 0;


            foreach(Account acct in accounts)
            {
                double accBalance = acct.GetBalance();
                grandTotal = grandTotal + acct.Balance;
                Console.WriteLine(acct.ToPrint());
            }
            Console.WriteLine("Grand total is " + grandTotal.ToString());
            Console.ReadKey();

            Account acct000 = new Savings();



            
        }
    }
}
