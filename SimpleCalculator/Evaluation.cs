using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluation
    {
        //the calcuator will check this variable after it runs the evaluation
        public int result { get; set; }

        public bool exceptionCaught { get; set; }
        public string exceptionMessage { get; set; }
        public bool equalOperation = false;

        //this method takes two terms and a string, and sets the result variable
        public Evaluation (int firstTerm, int secondTerm, string operation)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        Additon(firstTerm, secondTerm);
                        break;
                    case "-":
                        Subtraction(firstTerm, secondTerm);
                        break;
                    case "*":
                        Multiplication(firstTerm, secondTerm);
                        break;
                    case "/":
                        Division(firstTerm, secondTerm);
                        break;
                    case "%":
                        Modulus(firstTerm, secondTerm);
                        break;
                    case "=":
                        equalOperation = true;
                        break;
                    default:
                        throw new InvalidOperationException("Invalid operator");
                }
            }
            catch (Exception e)
            {
                exceptionCaught = true;
                exceptionMessage = e.Message;
            }

        }

        private void Additon(int firstTerm, int secondTerm)
        {
            result = (firstTerm + secondTerm);
        }

        private void Subtraction(int firstTerm, int secondTerm)
        {
            result = (firstTerm - secondTerm);
        }
        private void Multiplication(int firstTerm, int secondTerm)
        {
            result = (firstTerm * secondTerm);
        }
        private void Division(int firstTerm, int secondTerm)
        {

            result = (firstTerm / secondTerm);
        }
        private void Modulus(int firstTerm, int secondTerm)
        {
            result = (firstTerm % secondTerm);
        }
    }
}
