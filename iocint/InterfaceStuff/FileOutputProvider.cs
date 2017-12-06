using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.InterfaceStuff
{
    public class FileOutputProvider : IOutputProvider
    {
        public void ProvideOutput(List<string> input)
        {
            File.WriteAllLines("output.txt", input);
        }
    }
}
