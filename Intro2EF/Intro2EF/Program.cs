using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2EF
{
    class Program
    {

        static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();
            Order[] orders = db.Orders.ToArray();
            foreach (Order order in orders)
            {
                string message = $"Id ={order.Id}, Total={order.Total}, Cust={order.Customer.Name}, Description={order.Description}";
                            Console.WriteLine(message);
                Console.ReadLine();
            }
            //
            //Customer[] customers = db.Customers.Where(cust => cust.State == "KY"), db.Customers.OrderByDescending(cust => cust.Name).ToArray();
            //foreach (Customer cust in customers)
            //{
            //    string message = $"Id ={cust.Id}, Name={cust.Name}";
            //    Console.WriteLine(message);
            //}

            //Customer Chris = db.Customers.Find(5);
            //if (Chris == null)
            //{
            //    Console.WriteLine("couldn't find Chris");
            //}
            //else Console.WriteLine("found Chris");

            //Customer[] custs = db.Customers.Where(cust => cust.State == "KY" && cust => cust.City =="Covington").ToArray();
            //foreach(Customer cust in custs)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}, City/St={cust.City}/{cust.State}";
            //    Console.WriteLine(message);
            //}
            //List<Customer> custs = db.Customers.Where(c => c.Name == "Cong" && c.City == "Covington").ToList();
            //if (custs.Count == 0)
            //{
            //    Console.WriteLine("None found");
            //}
            //else
            //{
            //    Console.WriteLine($"Found {custs[0].Name}");
            //    Console.ReadKey();
            //}

        }
        }
    }



