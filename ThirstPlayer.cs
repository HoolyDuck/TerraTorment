using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TerraTorment;

public class ThirstPlayer : ModPlayer
{
    public float Thirst = 100f;
    public float ThirstMax = 100f;
    public float ThirstLoss = 5f;

    public override void ResetEffects()
    {
        ThirstLoss = 5f;
    }

    private float thirstUpdateCooldown = 1000;
    public float potionThirstCooldown = 0;

    public override void PostUpdateMiscEffects()
    {
        if (Player.whoAmI == Main.myPlayer)
        {
            if (potionThirstCooldown > 0)
            {
                ThirstLoss += 3;
                potionThirstCooldown -= 1;
            }
            
            thirstUpdateCooldown -= ThirstLoss;
            if (thirstUpdateCooldown <= 0)
            {
                Thirst -= 1;
                thirstUpdateCooldown = 1000;
            }
         
        }
    }
}