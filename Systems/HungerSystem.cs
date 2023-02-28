using System.Collections.Generic;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;


namespace TerraTorment.Systems;

public class HungerSystem : ModSystem
{

    public static List<BuffChange> BuffChanges = new();

    public override void Load()
    {
     
    }
    

    public override void Unload()
    {
        BuffChanges = null;
    }
}