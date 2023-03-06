using Terraria.ModLoader;

namespace TerraTorment;

public class TemperaturePlayer : ModPlayer
{
    // body temperature (duh)
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

        if (Player.ZoneCorrupt)
        {
            environmentTemperature = 0f;
        }

        if (Player.ZoneCrimson)
        {
            environmentTemperature = 33f;
        }

        if (Player.ZoneHallow)
        {
            environmentTemperature = 25f;
        }

        if (Player.ZoneBeach)
        {
            environmentTemperature = 28f;
        }

        if (Player.ZoneGlowshroom)
        {
            environmentTemperature = 20f;
        }

        if (Player.ZoneMeteor)
        {
            environmentTemperature = 55f;
        }

        if (Player.ZoneUnderworldHeight)
        {
            environmentTemperature = 60f;
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
        
    }
}