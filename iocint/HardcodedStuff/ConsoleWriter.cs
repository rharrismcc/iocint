using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.HardcodedStuff
{
    public class ConsoleWriter
    {
        public ConsoleWriter()
        {
        }

        public void WriteOutput(List<string> lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
