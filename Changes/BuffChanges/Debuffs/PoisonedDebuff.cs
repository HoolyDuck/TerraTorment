using Terraria.ID;

namespace TerraTorment.Changes.BuffChanges.Debuffs;

public class PoisonedDebuff : BuffChange
{
    public override int ActiveBuffId => BuffID.Poisoned;

    public override float GetHungerChange => 1f;
}