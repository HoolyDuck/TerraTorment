using System;
using Terraria.ModLoader;
using TerraTorment.Systems;

namespace TerraTorment.Content.Hunger.HungerChanges.ActionChanges;

public abstract class FoodChange : ILoadable
{
    public virtual int FoodItemId => 0;

    public virtual float AddHunger => 0f;
    
    public void Load(Mod mod)
    {
        FoodChange instance = (FoodChange)Activator.CreateInstance(GetType());
        HungerSystem.FoodChanges.Add(instance);
    }

    public void Unload()
    {
        
    }
    
    
}