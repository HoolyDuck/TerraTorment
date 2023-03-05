using Terraria;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger;

namespace TerraTorment.Items;

public class GlobalItemChanges : GlobalItem
{
    public override bool? UseItem(Item item, Player player)
    {
        HungerPlayer modPlayer = player.GetModPlayer<HungerPlayer>();
        
        if (item.damage > 0)
        {
            modPlayer.hungerChange += 0.5f;
        }

        return base.UseItem(item, player);
    }
}