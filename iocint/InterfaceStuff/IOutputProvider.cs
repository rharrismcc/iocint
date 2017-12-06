using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.InterfaceStuff
{
    public interface IOutputProvider
    {
        void ProvideOutput(List<string> input);
    }
}
