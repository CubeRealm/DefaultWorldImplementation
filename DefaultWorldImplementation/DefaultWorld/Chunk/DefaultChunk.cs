using World.API.Block;
using World.API.Chunk;
using World.API.Coords;
using World.API.Item;

namespace DefaultWorldImplementation.DefaultWorld.Chunk;

public class DefaultChunk : IChunk
{
    public void SetBlock(IBlock block, Location location)
    {
        throw new NotImplementedException();
    }

    public void SetBlock(IItem block, Location location)
    {
        throw new NotImplementedException();
    }

    public void RemoveBlock(Location location)
    {
        throw new NotImplementedException();
    }

    public IBlock[,,] ChunkData { get; set; }
    public ChunkLocation Location { get; set; }
}