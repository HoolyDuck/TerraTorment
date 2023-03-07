using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class Ale : PotionChange
{
    
    public override int ItemId => ItemID.Ale;
    
    public override float GetThirstGain() => 3f;
    
    
}