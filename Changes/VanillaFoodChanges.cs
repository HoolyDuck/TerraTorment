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

        switch (item.buffType)
        {
            case BuffID.WellFed:
                modPlayer.Hunger += 5f;
                break;
            case BuffID.WellFed2:
                modPlayer.Hunger += 10f;
                break;
            case BuffID.WellFed3:
                modPlayer.Hunger += 15f;
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