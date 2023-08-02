using MantisEngine.Core;
using MantisEngine.Core.Plugin;


namespace ExamplePlugin
{
    public class ExamplePlugin : IPlugin
    {
        public PluginData Info { get 
            { 
                return new PluginData
                {
                    Name = "ExamplePlugin",
                    Description = "Plugin description",
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
