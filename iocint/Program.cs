using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;
using iocint.HardcodedStuff;
using iocint.InterfaceStuff;
using iocint.App_Start;

namespace iocint
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region HardCoded Stuff

            /*
            KeyboardGetter input = new KeyboardGetter();
            List<string> lstInput = input.GetInput();


            ConsoleWriter output = new ConsoleWriter();
            output.WriteOutput(lstInput);
            */



            /*
            BidirectionalCommunication comm = new BidirectionalCommunication();
            List<string> lstInput = comm.GetInput();
            comm.WriteOutput(lstInput);
            */

            #endregion





            #region Interface Stuff

            //TwoWayCommunication communicator = new TwoWayCommunication(
            //    new KeyboardInputProvider(),
            //    new ConsoleOutputProvider());

            //TwoWayCommunication communicator = new TwoWayCommunication(
            //    new FileInputProvider(),
            //    new ConsoleOutputProvider());

            //TwoWayCommunication communicator = new TwoWayCommunication(
            //    new FileInputProvider(),
            //    new FileOutputProvider());


            //communicator.PersistOutput(communicator.GetInput());
            
            #endregion





            #region StructureMap Stuff

            //  no longer do something like this ....
            //TwoWayCommunication communicator = new TwoWayCommunication();


            //var container = new Container();

            //container.Configure(x => x.For<IInputProvider>().Use<KeyboardInputProvider>());
            //container.Configure(x => x.For<IOutputProvider>().Use<ConsoleOutputProvider>());


            //container.Configure(x => x.For<IInputProvider>().Use<FileInputProvider>());
            //container.Configure(x => x.For<IOutputProvider>().Use<FileOutputProvider>());


            //var communicator = container.GetInstance<TwoWayCommunication>();

            //List<string> lstInput = communicator.GetInput();
            //communicator.PersistOutput(lstInput);


            #endregion


            Console.WriteLine("Press <ENTER> to quit the program");
            Console.ReadKey();
        }
    }
}
