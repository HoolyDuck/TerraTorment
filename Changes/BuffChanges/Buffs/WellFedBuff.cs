using Terraria.ID;

namespace TerraTorment.Changes.BuffChanges.Buffs;

public class WellFedBuff : BuffChange
{
    public override int ActiveBuffId => BuffID.WellFed;

    public override float GetHungerChange => -1f;
}