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
            SpecialCommand prev = new SpecialCommand();
            Constants constant = new Constants();
            while (_continue)
            {
                string prompt = "[" + counter + "]> ";
                Console.Write(prompt);
                counter++;
                string command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "quit":
                        _continue = false;
                        break;
                    case "exit":
                        _continue = false;
                        break;
                    case "last":
                        Console.WriteLine(prev.GetPrevCommand());
                        break;
                    case "lastq":
                        Console.WriteLine(prev.GetPrevResult());
                        break;
                    default:
                        Expression newExpression = new Expression(command);
                        if (newExpression.exceptionCaught)
                        {
                            Console.WriteLine("invalid input!!");
                        }
                        else
                        {
                            prev.prevCommand.Push(command);
                            constant.EvaluateConstants(newExpression.firstTerm, newExpression.secondTerm, newExpression._operator);
                            Evaluation newEvaluation = new Evaluation(constant.firstTerm, constant.secondTerm, newExpression._operator);
                            Console.WriteLine(newEvaluation.result);
                            prev.prevResult.Push(newEvaluation.result.ToString());
                        }
                        break;
                 }
            }
            Console.WriteLine("goodbye! press a key to exit");
            Console.ReadLine();
        }

    }
}
