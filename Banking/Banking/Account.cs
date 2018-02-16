using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account : IAccountStatement
    {
        //Types of accounts
    
        //The properties
        public int Id { get; set; }
        public string Description { get; set; }
        public double Balance { get; set; }
        public Customer Owner { get; set; }


        // The methods
        public virtual string ToPrint() { //shows the multiple properties of an Account
            return "Acct Name=" + Owner.Fullname + ", Id=" + Id.ToString() + ", Desc=" + Description + ", Bal=" + Balance.ToString();
        }
        public void Deposit(double amount)
        {
            //{   if (amount < 0)
            //    {Console.WriteLine("Amount cannot be negative."); 
            //    return; }
            CheckForNegativeAmount(amount);
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Funds.");
                return;
            }
            if (amount < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
                return;
            }
            Balance = Balance - amount;
        }
        public double GetBalance()
        {
            return Balance;
        }
        private void CheckForNegativeAmount(double amount)
        {
            if (amount < 0)
            {Console.WriteLine("Amount cannot be negative.");
            }
        }
        private bool IsAmountNegative(double amount)
        {
            if (amount < 0)
            {Console.WriteLine("Amount cannot be negative");
            return true; }
            else
            return false;
        }
    }
}