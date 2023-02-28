using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;

namespace TerraTorment.Content.Hunger;

public class HungerPlayer : ModPlayer
{
    public float Hunger = 100;

    public float hungerChange;

    private int _timer;

    public override void ResetEffects()
    {
         hungerChange = -5f;

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

        if (_timer % (Main.dayLength / hungerChange / 10) == 0)
        {
            Hunger -= 1f;
            Main.NewText($"Current hunger: {Hunger}", Color.OrangeRed);
            _timer = 0;
        }
    }

}