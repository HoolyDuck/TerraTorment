using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class Milkshake : PotionChange
{
    
    public override int ItemId => ItemID.Milkshake;
    
    public override float GetThirstGain() => 10f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.RapidHealing, 3600 / 2);
    }
}