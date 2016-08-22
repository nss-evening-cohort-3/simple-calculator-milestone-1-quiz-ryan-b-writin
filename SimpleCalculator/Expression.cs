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
        //The calculator will check these variables after it runs an evaluation
        public string firstTerm { get; set; }
        public string secondTerm { get; set; }
        public string _operator { get; set; }

        //regex captures either a single letter or multiple digits, one of a specific set of operators,
        //then another single letter or multiple digits. spaces optional.
        string CaptureTerms = @"^[ ]*([\w]|\d+)[ ]*([+%=\-\/\*])[ ]*(\d+|[\w])$";

        public bool exceptionCaught { get; set; }
        public string exceptionMessage { get; set; }

        //checks user input against regex and sets three string variables with the two terms and operator
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
                    throw new InvalidOperationException("Invalid input. Use this format: _ + _");
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
