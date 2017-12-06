using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.HardcodedStuff
{
    public class BidirectionalCommunication
    {
        private KeyboardGetter input;
        private ConsoleWriter output;
        
        public BidirectionalCommunication()
        {
            input = new KeyboardGetter();
            output = new ConsoleWriter();
        }

        public List<string> GetInput()
        {
            return input.GetInput();
        }

        public void WriteOutput(List<string> lstInput)
        {
            output.WriteOutput(lstInput);
        }
    }
}
