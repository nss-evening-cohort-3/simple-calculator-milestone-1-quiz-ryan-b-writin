using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class PreviousCommands
    {
        public Stack<string> prevCommand = new Stack<string>();
        public Stack<string> prevResult = new Stack<string>();

        public string GetPrevCommand()
        {
            if (prevCommand.Count > 0)
            {
                return prevCommand.Pop();
            }
            else
            {
                return "no previous commands!";
            }
        }
        public string GetPrevResult()
        {
            if (prevResult.Count > 0)
            {
                return prevResult.Pop();
            }
            else
            {
                return "no previous commands!";
            }
        }
    }
}
