using World.API.Block.Implementation;
using World.API.Chunk;
using World.API.Coords;
using World.API.Data;
using World.API.World;

namespace DefaultWorldImplementation.World;

public class DefaultWorldGenerator : IWorldGenerator
{
    public IChunk GenerateChunkData(ref IChunk chunk)
    {

        for (int x = 0; x < 16; x++)
        {
            for (int z = 0; z < 16; z++)
            {
                Location location = new Location(x, 60, z);
                chunk.SetBlock(new SimpleBlock(Material.STONE, location), location);
            }
        }
        
        return chunk;
    }

    public long Seed { get; set; }
}