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
        string CaptureTerms = @"([\w]|\d+)[ ]*([+%=\-\/\*])[ ]*(\d+|[\w])";
        public string firstTerm { get; set; }
        public string secondTerm { get; set; }
        public string _operator { get; set; }
        public bool exceptionCaught { get; set; }
        public string exceptionMessage { get; set; }

        public Expression(string userInput)
        {
            try
            {
                Match m = Regex.Match(userInput, CaptureTerms);

                if (m.Success)
                {
                    firstTerm = m.Groups[1].Value;
                    secondTerm = m.Groups[3].Value;
                    _operator = m.Groups[2].Value;
                }
                else
                {
                    throw new InvalidOperationException("Invalid input");
                }
            }
            catch (InvalidOperationException e)
            {
                exceptionCaught = true;
                exceptionMessage = e.Message;
            }
        }
    }
}
