using Terraria.ID;

namespace TerraTorment.Content.Hunger.HungerChanges.ActionChanges.FoodChanges;

public class BowlOfSoupChange: FoodChange
{
    public override int FoodItemId => ItemID.BowlofSoup;

    public override float AddHunger => 10f;
}
