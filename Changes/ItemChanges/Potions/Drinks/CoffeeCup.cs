using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class CoffeeCup : PotionChange
{
    
    public override int ItemId => ItemID.CoffeeCup;
    
    public override float GetThirstGain() => 3f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.Swiftness, 3600 * 5);
        player.AddBuff(BuffID.NightOwl, 3600 * 5);
        player.AddBuff(BuffID.Warmth, 3600);
    }
}