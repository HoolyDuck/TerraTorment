using Terraria.ID;

namespace TerraTorment.Changes.BuffChanges.Buffs;

public class PlentySatisfiedBuff : BuffChange
{
    public override int ActiveBuffId => BuffID.WellFed2;

    public override float GetHungerChange() => -2f;
}