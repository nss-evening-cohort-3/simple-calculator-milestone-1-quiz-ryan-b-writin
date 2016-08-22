using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constants
    {
        //the calculator will check these two numbers after three strings are passed in
        public int firstTerm = 0;
        public int secondTerm = 0;

        public bool exceptionCaught { get; set; }
        public string exceptionMessage { get; set; }
        public string constantEqualsOperationMessage { get; set; }

        public Dictionary<string, int> constants = new Dictionary<string, int>();

        public void AddToConstants(string key, int number)
        {
            constants[key.ToLower()] = number;
        }

        //this method takes three strings. if the operation is valid, it will set the FirstTerm and SecondTerm variables.
        public void EvaluateConstants(string firstTermString, string secondTermString, string operation)
        {
            bool isTheFirstTermAnInt = Int32.TryParse(firstTermString, out firstTerm);
            bool isTheSecondTermAnInt = Int32.TryParse(secondTermString, out secondTerm);

            bool isTheFirstTermInTheDictionary = constants.ContainsKey(firstTermString.ToLower());
            bool isTheSecondTermInTheDictionary = constants.ContainsKey(secondTermString.ToLower());

            try
            {
                //if the second term is not a number, it must be in the dictionary.
                if (!isTheSecondTermAnInt)
                {
                    if (!isTheSecondTermInTheDictionary)
                    {
                        throw new KeyNotFoundException("Second constant not found.");
                    }
                    secondTerm = constants[secondTermString.ToLower()];
                }
                //if the operator is equals, the first term must be a letter that is not in the dictionary
                if (operation == "=")
                {
                    if (!isTheFirstTermAnInt && !isTheFirstTermInTheDictionary)
                    {
                        AddToConstants(firstTermString, secondTerm);
                        constantEqualsOperationMessage = firstTermString.ToLower() + "=" + secondTerm ;
                    }
                    else
                    {
                        throw new KeyNotFoundException("Invalid operation. First term must be an unassigned constant.");
                    }
                }
                //if the first term is not a number, it must be in the dictionary.
                else if (!isTheFirstTermAnInt)
                {
                    if (!isTheFirstTermInTheDictionary)
                    {
                        throw new KeyNotFoundException("First constant not found.");
                    }
                    firstTerm = constants[firstTermString.ToLower()];
                }
            }
            catch(KeyNotFoundException e)
            {
                exceptionCaught = true;
                exceptionMessage = e.Message;
            }
        }
    }
}
