using MantisEngine.Core;
using MantisEngine.Core.Plugin;

namespace TestPlugin
{
    public class ExamplePlugin : PluginBase
    {
        public PluginData Info { get 
            { 
                return new PluginData
                {
                    Name = "TestPlugin",
                    Description = "Test plugin description",
                    Version = "1.0.0"
                };
            } 
        }

        public void OnLoad()
        {
            Console.WriteLine("Hello World!");
            EngineSettings.SetBackgroundColor("#000000");
        }

        public void OnUnload()
        {
            Console.WriteLine("Bye!");
        }
    }
}
