using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Expression
    {
        string CaptureTerms = @"(\d+)[ ]*([+%=\-\/\*])[ ]*(\d+)";
        public int firstTerm { get; set; }
        public int secondTerm { get; set; }
        public string _operator { get; set; }
        public bool exceptionCaught { get; set; }

        public Expression(string userInput)
        {
            try
            {
                Match m = Regex.Match(userInput, CaptureTerms);

                if (m.Success)
                {
                    string firstTermString = m.Groups[1].Value;
                    string secondTermString = m.Groups[3].Value;

                    this.firstTerm = Int32.Parse(firstTermString);
                    this.secondTerm = Int32.Parse(secondTermString);
                    this._operator = m.Groups[2].Value;
                }
                else
                {
                    throw new InvalidOperationException("you messed up");
                }
            }
            catch (InvalidOperationException)
            {
                exceptionCaught = true;
            }
        }
    }
}
