using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.InterfaceStuff
{
    public class ConsoleOutputProvider : IOutputProvider
    {
        public void ProvideOutput(List<string> lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
