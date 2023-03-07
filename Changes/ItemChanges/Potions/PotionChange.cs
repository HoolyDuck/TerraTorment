using Terraria;

namespace TerraTorment.Changes.ItemChanges.Potions;

public abstract class PotionChange : ItemChange
{
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId == item.type)
        {
            player.GetModPlayer<HungerPlayer>().Hunger += GetHungerGain;
            player.GetModPlayer<ThirstPlayer>().Thirst += GetThirstGain;
        }
    }


}