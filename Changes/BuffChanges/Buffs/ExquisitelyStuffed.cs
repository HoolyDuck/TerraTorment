using Terraria.ID;

namespace TerraTorment.Changes.BuffChanges.Buffs;

public class ExquisitelyStuffed : BuffChange
{
    public override int ActiveBuffId => BuffID.WellFed3;

    public override float GetHungerChange => -3f;
}