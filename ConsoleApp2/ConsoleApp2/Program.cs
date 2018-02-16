using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClassLibrary1;

namespace ConsoleApp2
{
    class Programs
    {
        static void Main(string[] args)
        {
            myClassLibrary1.Constants constants = new myClassLibrary1.Constants();
            Console.WriteLine(constants.Helloworld);
            Console.ReadKey();
        }
    }
}
