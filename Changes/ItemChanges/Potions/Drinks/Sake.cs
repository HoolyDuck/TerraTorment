using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class Sake : PotionChange
{
    
    public override int ItemId => ItemID.Sake;
    
    public override float GetThirstGain() => 4f;
    
}