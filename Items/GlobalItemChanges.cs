using Terraria;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger;

namespace TerraTorment.Items;

public class GlobalItemChanges : GlobalItem
{
    public override bool? UseItem(Item item, Player player)
    {
        HungerPlayer modPlayer = player.GetModPlayer<HungerPlayer>();

        if (item.pick > 0 || item.axe > 0 || item.hammer > 0)
        {
            modPlayer.hungerChange += 1f;
        }
        
        if (item.damage > 0)
        {
            modPlayer.hungerChange += 0.5f;
        }

        return base.UseItem(item, player);
    }
}