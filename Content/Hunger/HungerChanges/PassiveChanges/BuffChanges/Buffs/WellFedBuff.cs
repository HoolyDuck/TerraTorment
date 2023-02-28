using Terraria.ID;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Buffs;

public class WellFedBuff : BuffChange
{
    public override int ActiveBuffId => BuffID.WellFed;

    public override float GetHungerChange => 1f;
}