using World.API.Block;
using World.API.Chunk;
using World.API.Coords;
using World.API.Item;
using World.API.World;

namespace DefaultWorldImplementation.DefaultWorld.Level;

public class DefaultLevel : ILevel
{
    public void GenerateChunk(ChunkLocation location)
    {
        throw new NotImplementedException();
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
    public ILevelGenerator Generator { get; set; }
}