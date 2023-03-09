using System.Collections.Generic;
using Terraria.ID;

namespace TerraTorment.Utilities.Lists;

public static class TileProximityChanges
{
    public static Dictionary<int, float> tileProximityTemperatureChanges = new()
    {
        { TileID.Furnaces, 3f },
        { TileID.Hellforge, 5f },
        { TileID.AdamantiteForge, 6f },
        { TileID.Hellstone, 2f },
        { TileID.HellstoneBrick, 1f },
        { TileID.Meteorite, 3f },
        { TileID.MeteoriteBrick, .4f },
        { TileID.LihzahrdFurnace, 2f },
        { TileID.SnowBlock, -0.4f },
        { TileID.IceBlock, -0.5f },
        { TileID.LivingFire, 1.5f},
        { TileID.LivingCursedFire, 2f},
        { TileID.LivingDemonFire, 2f},
        { TileID.LivingIchor, 2f},
        { TileID.LivingUltrabrightFire, 2.5f}
    };
}