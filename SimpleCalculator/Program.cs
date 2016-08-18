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
            bool _continue = true;

            while (_continue)
            {
                string prompt = "[" + counter + "]> ";
                Console.Write(prompt);
                counter++;
                string command = Console.ReadLine();
                switch (command)
                {
                    case "quit":
                        _continue = false;
                        break;
                    case "exit":
                        _continue = false;
                        break;
                    case "last":
                        Console.WriteLine("last result");
                        break;
                    case "lastq":
                        Console.WriteLine("last command");
                        break;
                    default:
                        Expression newExpression = new Expression(command);
                        if (newExpression.exceptionCaught)
                        {
                            Console.WriteLine("invalid input!!");
                        }
                        else
                        {
                            Evaluation newEvaluation = new Evaluation(newExpression.firstTerm, newExpression.secondTerm, newExpression._operator);
                            Console.WriteLine(newEvaluation.result);
                        }
                        break;
                 }
            }
            Console.WriteLine("goodbye! press a key to exit");
            Console.ReadLine();
            //step 1- pass a number to expression class
            //Console.WriteLine("Simple Calculato!!");
            //Console.Write(prompt);
            //counter++;
            //string userInput = Console.ReadLine();
            //Expression newExpression = new Expression(userInput);
            //Console.WriteLine(newExpression.firstTerm + newExpression._operator + newExpression.secondTerm);
            //Console.ReadLine();
        }

    }
}
