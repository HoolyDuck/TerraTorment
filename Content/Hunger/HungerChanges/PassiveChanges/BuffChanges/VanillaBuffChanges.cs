using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using TerraTorment.Systems;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;

public class VanillaBuffChanges : GlobalBuff
{
    public override void Update(int type, Player player, ref int buffIndex)
    {
        foreach (BuffChange buffChange in HungerSystem.BuffChanges) {
            if (type == buffChange.ActiveBuffId)
            {
                player.GetModPlayer<HungerPlayer>().hungerChange += buffChange.GetHungerChange;
            }
        }
    }
    
}