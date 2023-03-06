using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraTorment;

public class TemperaturePlayer : ModPlayer
{
    // body temperature 
    public float bodyTemperature = 36.6f;

    // comfortable default temperature
    public float environmentTemperature = 22f;

    public override void ResetEffects()
    {
        environmentTemperature = 22f;
    }

    public override void PostUpdateMiscEffects()
    {
        UpdateTemperatureBasedOnBiome();
        UpdateTemperatureBasedOnLocation();
        UpdateTemperatureBasedOnTime();
        UpdateTemperatureBasedOnWeather();
        UpdatedTemperatureBasedOnAdjacency();
    }

    private void UpdateTemperatureBasedOnBiome()
    {
        // biome changes (🟥 to be refactored!)
        if (Player.ZoneSnow)
        {
            environmentTemperature = -10f;
        }

        if (Player.ZoneDesert)
        {
            environmentTemperature = 40f;
        }

        if (Player.ZoneJungle)
        {
            environmentTemperature = 30f;
        }

        if (Player.ZoneHallow)
        {
            environmentTemperature = 25f;
        }

        if (Player.ZoneBeach)
        {
            environmentTemperature = 28f;
        }

        if (Player.ZoneMeteor)
        {
            environmentTemperature = 55f;
        }

        if (Player.ZoneUnderworldHeight)
        {
            environmentTemperature = 60f;
        }
    }

    private void UpdateTemperatureBasedOnLocation()
    {
        if (Player.ZoneCorrupt)
        {
            environmentTemperature -= 10f;
        }

        if (Player.ZoneCrimson)
        {
            environmentTemperature += 5f;
        }

        if (Player.ZoneDirtLayerHeight)
        {
            environmentTemperature -= 5f;
        }

        if (Player.ZoneRockLayerHeight)
        {
            environmentTemperature -= 10f;
        }

        if (Player.ZoneSkyHeight)
        {
            environmentTemperature -= 15f;
        }

        if (Player.ZoneGlowshroom)
        {
            environmentTemperature += 7f;
        }
    }

    private void UpdateTemperatureBasedOnTime()
    {
        if (!Main.dayTime)
        {
            environmentTemperature -= 6f;
        }
    }

    private void UpdateTemperatureBasedOnWeather()
    {
        //if raining and player on surface
        if (Main.raining && Player.ZoneOverworldHeight)
        {
            environmentTemperature -= 5f;
        }
    }

    private void UpdatedTemperatureBasedOnAdjacency()
    {
        // check tiles around player
        for (int i = -3; i < 6; i++)
        {
            for (int j = -3; j < 7; j++)
            {
                //draw dust box around player only on edges
                if (i == -3 || i == 5 || j == -3 || j == 6)
                    Dust.NewDustPerfect(Player.position + new Vector2(i * 16, j * 16), DustID.SpectreStaff,
                        Vector2.Zero, 40, Color.White, 1f);

                // get tile
                Tile tile = Framing.GetTileSafely(Player.position.ToTileCoordinates().X + i,
                    Player.position.ToTileCoordinates().Y + j);

                // check if tile is lava
                if (tile.LiquidType == LiquidID.Lava)
                {
                    // the closer the player is to the lava, the more it will affect their temperature
                    environmentTemperature += 15f / Math.Abs(i) + Math.Abs(j) == 0 ? 15f : (Math.Abs(i) + Math.Abs(j));
                }
            }
        }
    }
}