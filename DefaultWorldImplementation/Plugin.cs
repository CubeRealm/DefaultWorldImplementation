using Microsoft.Extensions.Logging;
using PluginAPI;

namespace DefaultWorldImplementation;

public class Plugin(ILogger<Plugin> logger) : IPlugin
{
    public string Name { get; set; } = "DefaultWorldImplementation";
    public string Version { get; set; } = "0.1-SNAPSHOT";
    public string[] Authors { get; set; } = new[] { "CubeRealm" };
    
    private ILogger<Plugin> Logger { get; } = logger;
    
    public void Load()
    {
        logger.LogDebug("World implementation loaded");
    }

    public void Enable()
    {
        logger.LogDebug("World implementation enabled");
    }

    ~Plugin()
    {
        logger.LogDebug("World implementation disabled");
    }
}