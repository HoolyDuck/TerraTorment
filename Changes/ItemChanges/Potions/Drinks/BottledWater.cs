using Terraria;
using Terraria.ID;

namespace TerraTorment.Changes.ItemChanges.Potions.Drinks;

public class BottledWater : PotionChange
{
    
    public override int ItemId => ItemID.BottledWater;
    
    public override float GetThirstGain() => 4f;
}