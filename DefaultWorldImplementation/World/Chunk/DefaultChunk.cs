using World.API.Block;
using World.API.Block.Implementation;
using World.API.Chunk;
using World.API.Coords;
using World.API.Data;
using World.API.Item;

namespace DefaultWorldImplementation.World.Chunk;

public class DefaultChunk : IChunk
{
    public void SetBlock(IBlock block, Location location)
    {
        ChunkData[location.BlockX, location.BlockY, location.BlockZ] = block;
    }

    public void SetBlock(IItem block, Location location)
    {
        SetBlock(block.PlaceableBlock, location);
    }

    public void RemoveBlock(Location location)
    {
        SetBlock(new SimpleBlock(Material.AIR, location), location);
    }

    public IBlock[,,] ChunkData { get; set; }
    public ChunkLocation Location { get; set; }
}