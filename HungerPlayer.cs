using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using TerraTorment.Utilities.Enums;

namespace TerraTorment;

public class HungerPlayer : ModPlayer
{
    public float Hunger = 100;

    public float hungerChange = 5f;
    
    public int tileMineCooldown = 0;
    public int weaponCooldown = 0;

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
            if (Player.velocity.X != 0)
            {
                hungerChange += 0.5f;
            }

            if (Player.velocity.Y < 0)
            {
                hungerChange += 1f;
            }
            
            if (tileMineCooldown > 0)
            {
                tileMineCooldown -= 1;
                hungerChange += 2f;
            }
            
            if (weaponCooldown > 0)
            {
                weaponCooldown -= 1;
                hungerChange += 1f;
            }
            
            
            hungerDecreaseCooldown -= hungerChange;
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