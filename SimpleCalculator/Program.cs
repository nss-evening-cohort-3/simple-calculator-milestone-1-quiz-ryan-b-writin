using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string prompt = "["+ counter + "]> ";

            //step 1- pass a number to expression class
            Console.WriteLine("Simple Calculato!!");
            Console.Write(prompt);
            counter++;
            string userInput = Console.ReadLine();
            Expression newExpression = new Expression(userInput);
            Console.WriteLine(newExpression.firstTerm + newExpression._operator + newExpression.secondTerm);
            Console.ReadLine();
        }
    }
}
