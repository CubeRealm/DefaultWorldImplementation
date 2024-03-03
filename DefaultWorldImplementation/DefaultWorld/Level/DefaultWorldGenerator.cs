using NoiseGenerator.Graphs;
using World.API;
using World.API.Block.Implementation;
using World.API.Chunk;
using World.API.Coords;
using World.API.Data;
using World.API.World;

namespace DefaultWorldImplementation.DefaultWorld.Level;

public class DefaultWorldGenerator : ILevelGenerator
{
    public long Seed { get; set; }
    
    private SinCosGraph SinCosGraph;
    
    public DefaultWorldGenerator(long seed)
    {
        Seed = seed;
        SinCosGraph = new SinCosGraph();
    }
    
    
    public IChunk GenerateChunkData(ref IChunk chunk)
    {
        for (int localX = 0; localX < 16; localX++)
        {
            for (int localZ = 0; localZ < 16; localZ++)
            {
                int globalX = chunk.Location.X + localX;
                int globalZ = chunk.Location.Z + localZ;

                Location location = new Location(globalX, SinCosGraph.At(globalX, globalZ), globalZ);

                chunk.SetBlock(new SimpleBlock(Material.STONE, location), location);
            }
        }
        
        return chunk;
    }
}