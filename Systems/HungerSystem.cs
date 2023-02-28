using System.Collections.Generic;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Buffs;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges.Debuffs;

namespace TerraTorment.Systems;

public class HungerSystem : ModSystem
{

    public static List<BuffChange> buffChanges = new();

    public override void Load()
    {
     
    }
    

    public override void Unload()
    {
        buffChanges = null;
    }
}