using System.Collections.Generic;
using Terraria.ModLoader;
using TerraTorment.Changes.BuffChanges;


namespace TerraTorment.Systems;

public class HungerSystem : ModSystem
{
    private static List<BuffChange> BuffChanges;
    
    public static void addBuffChange(BuffChange buffChange)
    {
        if (BuffChanges == null)
        {
            BuffChanges = new List<BuffChange>();
        }
        BuffChanges.Add(buffChange);
    }
    
    public static List<BuffChange> getBuffChanges()
    {
        return BuffChanges;
    }
    
    public override void Load()
    {
    }


    public override void Unload()
    {
        BuffChanges = null;
    }
}