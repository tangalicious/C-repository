using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class MathLib
    {
        public double Add(double a, double b)
        {
            return a + b;       //a+b Addition 
        }
        public double Subtract(double a, double b)
        { return a - b; }       //a-b   Subtraction     
        public double Multiply(double a, double b)
        { return a * b; }       //a*b   Multiplication
        public double Divide(double a, double b)
        { return a / b; }       //a/b   Division
        public double Square(double a)
        { return a * a; }       //a*a   Square
        public double Inverse(double a)
        { return 1 / a ; }      //1/a   Inverse
        public double Negate(double a)
        { return a * -1; }      //a*-1  Negation
        public double Halved(double a)
        { return a / 2; }       //a/2 Halving
        public double Quarter(double a)
        { return a / 4; }       //a/4 Quartering 
    }
}
