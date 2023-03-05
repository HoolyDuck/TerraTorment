using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TerraTorment.Systems;

namespace TerraTorment.Content.Hunger.HungerChanges.ActionChanges;

public class VanillaFoodChanges : GlobalItem
{
    public override void OnConsumeItem(Item item, Player player)
    {
        base.OnConsumeItem(item, player);
        HungerPlayer modPlayer = player.GetModPlayer<HungerPlayer>();

        switch (item.type)
        {
            case ItemID.Apple:
            case ItemID.Banana:
            case ItemID.Grapes:
            case ItemID.Lemon:
            case ItemID.Apricot:
            case ItemID.BlackCurrant:
            case ItemID.BloodOrange:
            case ItemID.Cherry:
            case ItemID.Coconut:
            case ItemID.Grapefruit:
            case ItemID.Mango:
            case ItemID.Peach:
            case ItemID.Pineapple:
            case ItemID.Plum:
            case ItemID.Elderberry:
            case ItemID.Rambutan:
            case ItemID.ShuckedOyster:
            case ItemID.Marshmallow:
                modPlayer.Hunger += 5f;
                break;

            case ItemID.CookedMarshmallow:
            case ItemID.BunnyStew:
            case ItemID.CookedFish:
            case ItemID.FruitSalad:
            case ItemID.GrilledSquirrel:
            case ItemID.RoastedBird:
            case ItemID.SauteedFrogLegs:
            case ItemID.PotatoChips:
                modPlayer.Hunger += 10f;
                break;
        }
    }
}