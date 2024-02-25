using DefaultWorldImplementation.World.Chunk;
using World.API.Block;
using World.API.Chunk;
using World.API.Coords;
using World.API.Item;
using World.API.World;

namespace DefaultWorldImplementation.World;

public class DefaultWorld : IWorld
{
    public void GenerateChunk(ChunkLocation location)
    {
        IChunk chunk = new DefaultChunk();
        Generator.GenerateChunkData(ref chunk);
    }

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

    public IChunk[,] Chunks { get; set; }
    public string WorldName { get; set; }
    public IWorldGenerator Generator { get; set; }
}