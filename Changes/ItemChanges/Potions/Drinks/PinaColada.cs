using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class PinaColada : PotionChange
{
    
    public override int ItemId => ItemID.PinaColada;
    
    public override float GetThirstGain => 6f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.Crate, 3600);
        player.AddBuff(BuffID.Fishing, 3600);
    }
}