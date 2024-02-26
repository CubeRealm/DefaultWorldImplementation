using Microsoft.Extensions.Logging;
using NoiseGenerator;
using NoiseGenerator.Graphs;
using PluginAPI;

namespace DefaultWorldImplementation;

public class DefaultWorldImplementation(ILogger<DefaultWorldImplementation> logger, MathHelper mathHelper) : IPlugin
{
    public string Name { get; set; } = "DefaultWorldImplementation";
    public string Version { get; set; } = "0.1-SNAPSHOT";
    public string[] Authors { get; set; } = new[] { "CubeRealm" };
    
    private ILogger<DefaultWorldImplementation> Logger { get; } = logger;
    private MathHelper MathHelper { get; } = mathHelper;
    
    
    
    public void Load()
    {
        logger.LogDebug("World implementation loaded");
    }

    public void Enable()
    {
        logger.LogDebug("World implementation enabled");
        logger.LogDebug("Checking API...");
        logger.LogDebug((new SinCosGraph()).At(10, 10).ToString());
    }

    ~DefaultWorldImplementation()
    {
        logger.LogDebug("World implementation disabled");
    }
}