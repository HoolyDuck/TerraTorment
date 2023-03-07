using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class PrismaticPunch : PotionChange
{
    
    public override int ItemId => ItemID.PrismaticPunch;
    
    public override float GetThirstGain => 5f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.Shine, 3600);
        player.AddBuff(BuffID.Panic, 3600);
    }
    
}