using Terraria.ID;

namespace TerraTorment.Changes.BuffChanges.Debuffs;

public class FeralBiteDebuff : BuffChange
{
    public override int ActiveBuffId => BuffID.Rabies;

    public override float GetHungerChange => 10f;
}