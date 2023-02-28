using Terraria.ID;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Buffs;

public class PlentySatisfiedBuff : BuffChange
{
    public override int ActiveBuffId => BuffID.WellFed2;

    public override float GetHungerChange => 2f;
}