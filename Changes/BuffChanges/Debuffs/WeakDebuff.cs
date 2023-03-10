using Terraria.ID;

namespace TerraTorment.Changes.BuffChanges.Debuffs;

public class WeakDebuff : BuffChange
{
    public override int ActiveBuffId => BuffID.Weak;

    public override float GetHungerChange() => 1.5f;
}