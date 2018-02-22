using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining.Bootcamp.DotNet.TestDrivenDevelopment.Jen;

namespace TestCases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool allTestsPassed = TestForZeroInputs();
            allTestsPassed &= TestForOneInput();

            if (allTestsPassed)
            {
                Console.WriteLine("All tests passed");
            }
            else
            {
                Console.WriteLine("Some tests failed.");
            }
            Console.ReadKey();
        }

        private static bool TestForOneInput()
        {
            string userInput = "100";
            string ApplicationExceptionThrown = "No Exception";
            Calculator calulator = new Calculator();
            try
            {
                //should throw an ApplicationException
                calulator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("2", "Test for one inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }

        private static bool TestForZeroInputs()
        {
            string userInput = "";
            string ApplicationExceptionThrown = "No Exception";
            Calculator calulator = new Calculator();
            try
            {
                //should throw an ApplicationException
                calulator.Add(userInput);
            }
            catch (ApplicationException ex)
            {
                ApplicationExceptionThrown = "ApplicationException";
            }
            bool passed = PrintTestResult("1", "Test for zero inputs", "ApplicationException", ApplicationExceptionThrown);
            return passed;
        }

        private static bool PrintTestResult(string Id, string Description, string ExpectedResults, string ActualResults)
        {
            string passfail = ExpectedResults == ActualResults ? "PASS" : "FAIL";
            Console.WriteLine($"{Id} {Description} {ExpectedResults} {ActualResults} {passfail}");
            return passfail == "PASS";
        }
    }
}