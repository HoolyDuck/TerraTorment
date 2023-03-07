using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class CreamSoda : PotionChange
{
    
    public override int ItemId => ItemID.CreamSoda;
    
    public override float GetThirstGain => 7f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.Featherfall, 3600);
    }
}