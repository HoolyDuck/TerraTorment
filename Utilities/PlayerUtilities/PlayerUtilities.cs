using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using TerraTorment.Utilities;


namespace TerraTorment.Utilities.PlayerUtilities;

public static class PlayerUtilities
{
    /// <summary>
    /// Checks for lava around the player and increases temperature based on distance to lava tile
    /// </summary>
    /// <param name="left">Left border</param>
    /// <param name="right">Right border</param>
    /// <param name="top"> Top border</param>
    /// <param name="bottom">Bottom border</param>
    /// <param name="player">Player to check around</param>
    public static void CheckForLavaAround(
        int left,
        int right,
        int top,
        int bottom,
        Player player)
    {
        // Look around the player
        for (int i = left; i < right; i++)
        {
            for (int j = top; j < bottom; j++)
            {
                // Draw rectangle around player to know where to look for lava
                if (i == left || i == right - 1 || j == top || j == bottom - 1)
                    Dust.NewDustPerfect(player.position + new Vector2(i * 16, j * 16),
                        DustID.SpectreStaff,
                        Vector2.Zero, 40, Color.White, 1f);

                // Get tile
                Tile tile = Framing.GetTileSafely(player.position.ToTileCoordinates().X + i,
                    player.position.ToTileCoordinates().Y + j);

                // If tile is lava, increase temperature based on distance to lava tile
                if (tile.LiquidType == LiquidID.Lava)
                {
                    float distance =
                        MathUtilities.MathUtilities.DistanceToPlayer(i, j) == 0
                            ? 1
                            : MathUtilities.MathUtilities.DistanceToPlayer(i, j);

                    player.GetModPlayer<TemperaturePlayer>().environmentTemperature +=
                        15f / distance;
                }
            }
        }
    }

    public static void CheckForEvents(Player player)
    {
        if (Main.raining)
        {
            if (player.ZoneOverworldHeight)
            {
                player.GetModPlayer<TemperaturePlayer>().environmentTemperature -= 5f;
                player.GetModPlayer<TemperaturePlayer>().envHumidity += .2f;
            }
            
            if (player.ZoneSnow)
            {
                player.GetModPlayer<TemperaturePlayer>().environmentTemperature -= 10f;
                player.GetModPlayer<TemperaturePlayer>().envHumidity += .3f;
            }
        }
        
        if (Main.snowMoon)
        {
            player.GetModPlayer<TemperaturePlayer>().environmentTemperature -= 10f;
            player.GetModPlayer<TemperaturePlayer>().envHumidity += .2f;
        }
        
        if (Main.eclipse)
        {
            player.GetModPlayer<TemperaturePlayer>().environmentTemperature -= 10f;
        }
        
        if (Main.bloodMoon)
        {
            player.GetModPlayer<TemperaturePlayer>().environmentTemperature += 6f;
        }

        if (player.ZoneSandstorm)
        {
            player.GetModPlayer<TemperaturePlayer>().envHumidity -= .1f;
        }
        
        
 

    }
}