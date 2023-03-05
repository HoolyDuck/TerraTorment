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

            case ItemID.BowlofSoup:
            case ItemID.Pho:
            case ItemID.CookedShrimp:
            case ItemID.Escargot:
            case ItemID.FroggleBunwich:
            case ItemID.GrubSoup:
            case ItemID.LobsterTail:
            case ItemID.MonsterLasagna:
            case ItemID.RoastedDuck:
            case ItemID.SeafoodDinner:
            case ItemID.PumpkinPie:
            case ItemID.Sashimi:
            case ItemID.Starfruit:
            case ItemID.BananaSplit:
            case ItemID.ChickenNugget:
            case ItemID.ChocolateChipCookie:
            case ItemID.FriedEgg:
            case ItemID.Fries:
            case ItemID.Hotdog:
            case ItemID.Grapes:
            case ItemID.IceCream:
            case ItemID.Nachos:
            case ItemID.ShrimpPoBoy:
            case ItemID.PadThai:
                modPlayer.Hunger += 15f;
                break;
            case ItemID.GoldenDelight:
            case ItemID.ApplePie:
            case ItemID.Bacon:
            case ItemID.BBQRibs:
            case ItemID.Burger:
            case ItemID.Pizza:
            case ItemID.Steak:
            case ItemID.ChristmasPudding:
            case ItemID.GingerbreadCookie:
            case ItemID.SugarCookie:
                modPlayer.Hunger += 20f;
                break;
        }
    }
}