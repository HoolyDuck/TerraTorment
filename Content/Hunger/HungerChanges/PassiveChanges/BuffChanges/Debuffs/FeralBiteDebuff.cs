using Terraria.ID;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Debuffs;

public class FeralBiteDebuff : BuffChange
{
    public override int ActiveBuffId => BuffID.Rabies;

    public override float GetHungerChange => 10f;
}