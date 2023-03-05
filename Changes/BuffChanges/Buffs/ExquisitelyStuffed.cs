using Terraria.ID;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Buffs;

public class ExquisitelyStuffed : BuffChange
{
    public override int ActiveBuffId => BuffID.WellFed3;

    public override float GetHungerChange => -3f;
}