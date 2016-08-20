using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constants
    {
        public int firstTerm = 0;
        public int secondTerm = 0;
        public bool exceptionCaught { get; set; }
        public string constantEqualsOperationMessage { get; set; }
        private Dictionary<string, int> constants = new Dictionary<string, int>();
        public void AddToConstants(string key, int number)
        {
            constants[key] = number;
        }
        public void EvaluateConstants(string firstTermString, string secondTermString, string operation)
        {
            bool isTheFirstTermAnInt = Int32.TryParse(firstTermString, out firstTerm);
            bool isTheSecondTermAnInt = Int32.TryParse(secondTermString, out secondTerm);
            bool isTheFirstTermInTheDictionary = constants.ContainsKey(firstTermString);
            bool isTheSecondTermInTheDictionary = constants.ContainsKey(secondTermString);

            try
            {
                //if the second term is not a number, it must be in the dictionary.
                if (!isTheSecondTermAnInt)
                {
                    if (!isTheSecondTermInTheDictionary)
                    {
                        throw new KeyNotFoundException("second key not found");
                    }
                    secondTerm = constants[secondTermString];
                }
                //if the operator is equals, the first term must be a letter that is not in the dictionary
                if (operation == "=")
                {
                    if (!isTheFirstTermAnInt && !isTheFirstTermInTheDictionary)
                    {
                        AddToConstants(firstTermString, secondTerm);
                        constantEqualsOperationMessage = firstTermString + "=" + secondTerm ;
                    }
                    else
                    {
                        throw new KeyNotFoundException("first term is invalid");
                    }
                }
                //if the first term is not a number, it must be in the dictionary.
                else if (!isTheFirstTermAnInt)
                {
                    if (!isTheFirstTermInTheDictionary)
                    {
                        throw new KeyNotFoundException("first key not found");
                    }
                    firstTerm = constants[firstTermString];
                }
            }
            catch(KeyNotFoundException e)
            {
                exceptionCaught = true;
                Console.WriteLine(e.Message);
            }

        }
    }
}
