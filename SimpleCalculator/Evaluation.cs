using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluation
    {
        public bool exceptionCaught { get; set; }
        public int result { get; set; }
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
                        break;
                    default:
                        throw new InvalidOperationException("invalid operation");
                }
            }
            catch (InvalidOperationException e)
            {
                exceptionCaught = true;
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
