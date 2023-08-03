**Download builds** : [![API on NuGet](https://img.shields.io/nuget/v/MantisEngine.Core.svg?label=MantisEngine.Core&color=blue&logo=nuget&logoColor=white&link=https://www.nuget.org/packages/MantisEngine.Core/)](https://www.nuget.org/packages/MantisEngine.Core/)

**Attention! This library is only used to create plugins for the Mantis Engine and no more!**

### Examples:


**Register new plugin**
```csharp
public class ExamplePlugin : PluginBase
{

public PluginData Info
{
get 
    { 
        return new PluginData
        {
            Name = "ExamplePlugin",
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
```

**Adding new programming language**
```csharp
    //Creating wrapper class
    internal class ExampleLanguage : ProgrammingLanguage
    {
        public ProgrammingLanguage.Info LanguageInfo => new ProgrammingLanguage.Info
        {
            FileFormats = new string[] { ".py" },
            LanguageName = "Python"
        };

        public void RunScript(string path)
        {
            ...
        }
    }
```


```csharp
public void OnLoad()
{
    EngineSettings.RegisterProgrammingLanguage(new ExampleProgrammingLanguage())
}
```

### Release notes 1.0.1:

This release introduces a number of new features that make it easier to create plugins, including support for registering programming languages and engine events.

Plugins can now register programming languages with the system, allowing them to provide syntax highlighting, autocompletion, and other language-specific functionality. Additionally, plugins can register to receive notifications when certain engine events occur, such as the start and end of a game session, allowing them to perform custom actions in response to these events.

Other improvements in this release include:

- Improved performance when loading and unloading plugins
- Better error handling and logging for plugins
- Expanded documentation and examples for plugin development
- Changed: ```void SetClearColor(...) -> void SetBackgroundColor(...)```, ```Color GetClearColor() -> Color GetBackgroundColor()```
- Added: ```void RegisterProgrammingLanguage(ProgrammingLanguage language) ```
- Bug fixes and stability improvements

Overall, this release should make it easier for developers to extend the functionality of the system and create more powerful plugins.
