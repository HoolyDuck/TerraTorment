using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;
using TerraTorment.Systems;
using TerraTorment.Utilities.Enums;

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


    private float hungerDecreaseCooldown = (float) CooldownEnum.HUNGER_DECREASE_COOLDOWN_DEFAULT;
    public override void PostUpdateMiscEffects()
    {
        if (Player.whoAmI == Main.myPlayer)
        {
            hungerDecreaseCooldown -= hungerChange;
            if (hungerDecreaseCooldown <= 0)
            {
                Hunger -= 1f;
                Main.NewText($"Current hunger: {Hunger}, hungerChange: {hungerChange}", Color.OrangeRed);
                hungerDecreaseCooldown = (float)CooldownEnum.HUNGER_DECREASE_COOLDOWN_DEFAULT;
            }

            if (Player.velocity.X != 0)
            {
                hungerChange += 0.5f;
            }

            if (Player.velocity.Y < 0)
            {
                hungerChange += 1f;
            }
        }
    }

    public override void UpdateDead()
    {
        Hunger = 50;
    }

    public override void PostUpdate()
    {
       
    }
    
}