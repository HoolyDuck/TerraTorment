using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using TerraTorment.Utilities.Enums;

namespace TerraTorment;

public class HungerPlayer : ModPlayer
{
    public float Hunger = 100;
    public float HungerLoss = 5f;
    
    public int tileMineCooldown = 0;
    public int weaponCooldown = 0;

    public override void ResetEffects()
    {
         HungerLoss = 5f;
    }


    private float hungerDecreaseCooldown = (float) CooldownEnum.HUNGER_DECREASE_COOLDOWN_DEFAULT;
    public override void PostUpdateMiscEffects()
    {
        if (Player.whoAmI == Main.myPlayer)
        {
            if (Player.velocity.X != 0)
            {
                HungerLoss += 0.5f;
            }

            if (Player.velocity.Y < 0)
            {
                HungerLoss += 1f;
            }
            
            if (tileMineCooldown > 0)
            {
                tileMineCooldown -= 1;
                HungerLoss += 2f;
            }
            
            if (weaponCooldown > 0)
            {
                weaponCooldown -= 1;
                HungerLoss += 1f;
            }
            
            
            hungerDecreaseCooldown -= HungerLoss;
            if (hungerDecreaseCooldown <= 0)
            {
                Hunger -= 1f;
                hungerDecreaseCooldown = (float)CooldownEnum.HUNGER_DECREASE_COOLDOWN_DEFAULT;
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