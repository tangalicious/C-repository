﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Calculator
{
    public class calculator
    {
        public static bool Evaluate(string equation, double answer) {
            if (equation.Length == 0)
            {
                return false;
            }
            Stack<double> TheStack = new Stack<double>();
              string[] operands = equation.Split(',');
            foreach(string oper in operands)
            {   if (oper == "+")
                {
                    double op1 = TheStack.Pop();
                    double op2 = TheStack.Pop();
                    double ans = op1 + op2;
                    TheStack.Push(ans);
                }
                else if (oper == "-")
                {
                    double op1 = TheStack.Pop();
                    double op2 = TheStack.Pop();
                    double ans = op1 - op2;
                    TheStack.Push(ans);
                }
                if (oper == "*")
                {
                    double op1 = TheStack.Pop();
                    double op2 = TheStack.Pop();
                    double ans = op1 * op2;
                    TheStack.Push(ans);
                }
                if (oper == "/")
                {
                    double op1 = TheStack.Pop();
                    double op2 = TheStack.Pop();
                    double ans = op1 / op2;
                    TheStack.Push(ans);
                } else
                {
                    double nbr = double.Parse(oper);
                    TheStack.Push(nbr);
                }
            }
            answer = TheStack.Pop();
            return true;
        }
    }
}
