using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraTorment.Systems;

namespace TerraTorment.Content.Hunger.HungerChanges.ActionChanges;

public class VanillaFoodChanges : GlobalItem
{
    public override void OnConsumeItem(Item item, Player player)
    {
        base.OnConsumeItem(item, player);
        foreach (FoodChange foodChange in HungerSystem.FoodChanges) {
            if (item.type == foodChange.FoodItemId)
            {
                player.GetModPlayer<HungerPlayer>().Hunger += foodChange.AddHunger;
            }
        }
    }
}