using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.InterfaceStuff
{
    public class TwoWayCommunication
    {
        public IInputProvider inputProvider;
        public IOutputProvider outputProvider;

        //public TwoWayCommunication()
        //{        }

        public TwoWayCommunication(IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            this.inputProvider = inputProvider;
            this.outputProvider = outputProvider;
        }

        public List<string> GetInput()
        {
            return inputProvider.ProvideInput();
        }

        public void PersistOutput(List<string> lines)
        {
            outputProvider.ProvideOutput(lines);
        }
    }
}
