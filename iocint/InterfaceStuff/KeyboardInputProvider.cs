using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iocint.InterfaceStuff
{
    public class KeyboardInputProvider : IInputProvider
    {
        public List<string> ProvideInput()
        {
            List<string> lstInput = new List<string>();
            string input = string.Empty;

            while (!input.ToLower().StartsWith("zz"))
            {
                Console.Write("Enter a line of input ('zz' to quit): ");
                input = Console.ReadLine();
                if (!input.ToLower().StartsWith("zz"))
                {
                    lstInput.Add(input);
                }
            }
            return lstInput;
        }
    }
}
