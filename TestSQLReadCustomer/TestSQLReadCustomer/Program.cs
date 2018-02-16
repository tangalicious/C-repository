using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLReadCustomer;

namespace TestSQLReadCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerController cust = new CustomerController();
            Customer c = new Customer();
            c.Id = 9;
            c.Name = "SuperDuperMAX";
            c.City = "Mason";
            c.State = "OH";
            c.IsCorpAcct = true;
            c.CreditLimit = 1000000;
            c.Active = true;
            if (cust.Delete(c))
            {
                Console.WriteLine("Delete failed!");
            }
            //List<Customer> customers = cust.SearchByName("in");
            //        List<Customer> customers = cust.List();
            //          List<Customer> customers = cust.SearchByCreditLimitRange(300000, 100000);
            // List<Customer> customers = cust.SearchByName();
            
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.Id} | {customer.Name} | {customer.City} | {customer.State} | {customer.IsCorpAcct} | {customer.CreditLimit} | {customer.Active}");
                Console.ReadKey();
            }
            //Customer customer = cust.Get(1);
            Console.ReadKey();
        }
    }
}
