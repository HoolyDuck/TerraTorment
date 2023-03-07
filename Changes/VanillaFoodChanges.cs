using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraTorment.Changes;

public class VanillaFoodChanges : GlobalItem
{
    public override void OnConsumeItem(Item item, Player player)
    {
        base.OnConsumeItem(item, player);
        HungerPlayer modPlayer = player.GetModPlayer<HungerPlayer>();
        ThirstPlayer thirstPlayer = player.GetModPlayer<ThirstPlayer>();
        

        //drink changes
        switch (item.type)
        {
            case ItemID.BottledWater:
            case ItemID.BananaDaiquiri:
            case ItemID.PeachSangria:
            case ItemID.PinaColada:
            case ItemID.Teacup:
            case ItemID.MilkCarton:
            case ItemID.Ale:
            case ItemID.Sake:
                thirstPlayer.Thirst += 5f;
                break;
            case ItemID.CoffeeCup:
            case ItemID.CreamSoda:
                thirstPlayer.Thirst += 10f;
                break;
            case ItemID.GrapeJuice:
            case ItemID.Milkshake:
                thirstPlayer.Thirst += 15f;
                break;
            default:
                if (item.buffType != 0 && item.buffType != BuffID.WellFed3
                                       && item.buffType != BuffID.WellFed
                                       && item.buffType != BuffID.WellFed2)
                {
                    thirstPlayer.potionThirstCooldown = 1000;
                }

                break;
        }
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
        switch (item.buffType)
        {
            case BuffID.WellFed:
                tooltips.Add(new TooltipLine(Mod, "Hunger + 5", "Makes you bit less hungry"));
                break;
            case BuffID.WellFed2:
                tooltips.Add(new TooltipLine(Mod, "Hunger + 10", "Makes you less hungry"));
                break;
            case BuffID.WellFed3:
                tooltips.Add(new TooltipLine(Mod, "Hunger + 15", "Makes you a lot less hungry"));
                break;
        }
    }
}