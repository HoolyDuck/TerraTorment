using Terraria;
using Terraria.ModLoader;
using TerraTorment.Changes.BuffChanges;
using TerraTorment.Systems;

namespace TerraTorment.Changes;

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