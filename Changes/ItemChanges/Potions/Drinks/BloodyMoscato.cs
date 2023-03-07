using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class BloodyMoscato : PotionChange
{
    
    public override int ItemId => ItemID.BloodyMoscato;
    
    public override float GetThirstGain() => 5f;
    
    public override void OnConsumeItem(Item item, Player player)
    {
        if (ItemId != item.type) return;
        base.OnConsumeItem(item, player);
        AddEffects(player);
    }
    
    private void AddEffects(Player player)
    {
        player.AddBuff(BuffID.Regeneration, 3600);
        player.AddBuff(BuffID.Lifeforce, 3600);
    }
    
}