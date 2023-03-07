using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class SmoothieofDarkness : PotionChange
{
    
    public override int ItemId => ItemID.SmoothieofDarkness;
    
    public override float GetThirstGain() => 6f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.ManaRegeneration, 3600);
        player.AddBuff(BuffID.MagicPower, 3600);
    }
    
}