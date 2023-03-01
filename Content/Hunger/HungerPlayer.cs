using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;
using TerraTorment.Systems;

namespace TerraTorment.Content.Hunger;

public class HungerPlayer : ModPlayer
{
    public float Hunger = 100;

    public float hungerChange = 5f;

    private int _timer;

    public override void ResetEffects()
    {
         hungerChange = 5f;
    }
    
    public override void PostUpdateMiscEffects()
    {

     
    }

    public override void UpdateDead()
    {
        Hunger = 50;
    }

    public override void PostUpdate()
    {
        _timer++;
        if (_timer % (Main.dayLength / 20 / Math.Max(hungerChange, 1) ) == 0)
        {
            Hunger -= 1f;
            Main.NewText($"Current hunger: {Hunger}, hungerChange: {hungerChange}", Color.OrangeRed);
            _timer = 0;
        }
    }
    
}