using StructureMap;
using iocint.InterfaceStuff;

namespace iocint {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            //                x.For<IExample>().Use<Example>();
                            
                            //x.For<IInputProvider>().Use<KeyboardInputProvider>();
                            //x.For<IOutputProvider>().Use<ConsoleOutputProvider>();
                        });
            return ObjectFactory.Container;
        }
    }
}