using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraTorment.Utilities.PlayerUtilities;

namespace TerraTorment;

public class TemperaturePlayer : ModPlayer
{
    // body temperature 
    public float bodyTemperature = 36.6f;

    public float modifiedBodyTemperature = 36.6f;

    public float temperatureChangeResistance = 0f;

    public float windSpeed;

    // comfortable default temperature
    public float environmentTemperature = 22f;

    public float envHumidity;


    public override void ResetEffects()
    {
        environmentTemperature = 22f;
        envHumidity = .4f;
    }

    public override void PostUpdate()
    {
        envHumidity = Math.Clamp(envHumidity, 0f, 1f);
        // if it's too hot, humidity is 0
        if (environmentTemperature >= 100) envHumidity = 0f;
        
        windSpeed = Math.Clamp(Main.windSpeedCurrent, -30f, 30f);
        bool isOverworldOutside = Player.ZoneOverworldHeight && !Player.behindBackWall;

        temperatureChangeResistance = Math.Clamp(temperatureChangeResistance, 0f, 1f);
        modifiedBodyTemperature = Math.Clamp(modifiedBodyTemperature, 30f, 50f);
        // "feels like" temperature
        modifiedBodyTemperature = (float)calculateHeatIndex(
            environmentTemperature,
            envHumidity
            , isOverworldOutside ? windSpeed : 0f);
        float difference = modifiedBodyTemperature - bodyTemperature;
        bodyTemperature += difference / 60f / 1000f * (1f - temperatureChangeResistance);
    }

    private double calculateHeatIndex(float temperature, float humidity, float windSpeed)
    {
        // formula from here
        // https://en.wikipedia.org/wiki/Wind_chill#Australian_apparent_temperature
        // add wind chill later
        return environmentTemperature + 0.33 *
            humidity * 6.105 *
            (float)Math.Exp(17.27 * temperature / (237.7 + temperature)) - Math.Abs(0.7f * windSpeed) - 4;
    }


    public override void PostUpdateMiscEffects()
    {
        UpdateTemperatureBasedOnBiome();
        UpdateTemperatureBasedOnLocation();
        UpdateTemperatureBasedOnTime();
        UpdateTemperatureBasedOnWeather();
        UpdatedTemperatureBasedOnAdjacency();

        if (Player.lavaWet)
        {
            environmentTemperature += 700;
        }
    }

    private void UpdateTemperatureBasedOnBiome()
    {
        // biome changes (🟥 to be refactored!)
        if (Player.ZoneSnow)
        {
            environmentTemperature = -10f;
            envHumidity = .03f;
        }

        if (Player.ZoneDesert)
        {
            environmentTemperature = 40f;
            envHumidity = .25f;
        }

        if (Player.ZoneJungle)
        {
            environmentTemperature = 30f;
            envHumidity = .9f;
        }

        if (Player.ZoneHallow)
        {
            environmentTemperature = 25f;
            envHumidity = .5f;
        }

        if (Player.ZoneBeach)
        {
            environmentTemperature = 28f;
            envHumidity = .45f;
        }

        if (Player.ZoneMeteor)
        {
            environmentTemperature = 55f;
            envHumidity = .02f;
        }

        if (Player.ZoneUnderworldHeight)
        {
            environmentTemperature = 60f;
            envHumidity = 0f;
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

        if (Player.ZoneNormalSpace)
        {
            environmentTemperature -= 15f;
        }
    }

    private void UpdateTemperatureBasedOnTime()
    {
        if (!Main.dayTime && Player.ZoneOverworldHeight)
        {
            environmentTemperature -= 6f;
        }
    }

    private void UpdateTemperatureBasedOnWeather()
    {
        PlayerUtilities.CheckForEvents(Player);
    }

    private void UpdatedTemperatureBasedOnAdjacency()
    {
        PlayerUtilities.CheckForLavaAround(-10, 12, -13, 10, Player);
        PlayerUtilities.CheckForTilesAround(-4, 4, -4, 4, Player);
    }
}