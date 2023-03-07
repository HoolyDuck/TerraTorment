using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class Teacup : PotionChange
{
    
    public override int ItemId => ItemID.Teacup;
    
    public override float GetThirstGain => 5f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.NightOwl, 3600 * 2);
        player.AddBuff(BuffID.Warmth, 3600 );
    }
}