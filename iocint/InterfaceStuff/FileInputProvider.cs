using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.InterfaceStuff
{
    public class FileInputProvider : IInputProvider
    {
        public List<string> ProvideInput()
        {
            return File.ReadAllLines("input.txt").ToList();
        }
    }
}
