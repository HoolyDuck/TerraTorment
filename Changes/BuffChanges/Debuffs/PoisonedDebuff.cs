using Terraria.ID;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Debuffs;

public class PoisonedDebuff : BuffChange
{
    public override int ActiveBuffId => BuffID.Poisoned;

    public override float GetHungerChange => 1f;
}