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

            Console.WriteLine("Simple Calculator: Enter simple problems in this format: _ + _");
            Console.WriteLine("You may set each letter as a constant once in this format: x = _");
            Console.WriteLine("Input 'Exit' or 'Quit' to quit, 'Last' to see your last input,");
            Console.WriteLine("and 'Lastq' to see your last result.");
            //main loop
            while (_continue)
            {
                //counter prompt & incrementer
                string prompt = "[" + counter + "]> ";
                Console.Write(prompt);
                counter++;
                constant.exceptionCaught = false;

                //interpret & evaluate user input
                string command = Console.ReadLine().ToLower();

                //check for special commands. default case continues main loop.
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

                        //feed user input into an expression class,
                        //which will separate the first term, second term and operator into three strings
                        Expression newExpression = new Expression(command);
                        //check to see if an exception was thrown and print it if so
                        if (newExpression.exceptionCaught)
                        {
                            Console.WriteLine(newExpression.exceptionMessage);
                            break;
                        }
                        else
                        {
                            //add user inout to lastq stack
                            prev.prevCommand.Push(command);

                            //feed three strings into constant class, which will check for constants
                            //and handle any equals operations. the two term strings become int variables here
                            constant.EvaluateConstants(newExpression.firstTerm, newExpression.secondTerm, newExpression._operator);
                            if (constant.exceptionCaught)
                            {
                                Console.WriteLine(constant.exceptionMessage);
                                break;
                            }

                            //feed the two ints and the operation string into evaluation class,
                            //which will interpret them and produce the result of the operation
                            Evaluation newEvaluation = new Evaluation(constant.firstTerm, constant.secondTerm, newExpression._operator);
                            if (newEvaluation.exceptionCaught)
                            {
                                Console.WriteLine(newEvaluation.exceptionMessage);
                                break;
                            }

                            //if an equal operation was carried out, print out a different result.
                            //push the result to the 'lastq' stack
                            if (newEvaluation.equalOperation)
                            {
                                Console.WriteLine(constant.constantEqualsOperationMessage);
                                prev.prevResult.Push(constant.secondTerm.ToString());
                            }
                            else
                            {
                                Console.WriteLine("    = " + newEvaluation.result);
                                prev.prevResult.Push(newEvaluation.result.ToString());
                            }
                            
                        }
                        break;
                 }
            }
            Console.WriteLine("Goodbye! Press a key to exit");
            Console.ReadLine();
        }

    }
}
