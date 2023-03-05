using System;
using Terraria.ModLoader;
using TerraTorment.Systems;

namespace TerraTorment.Changes.BuffChanges;

public abstract class BuffChange : ILoadable
{
    private HungerSystem hungerSystem = new HungerSystem();
    public virtual int ActiveBuffId => -1;

    public virtual float GetHungerChange => 0f;
    
    public void Load(Mod mod)
    {
        BuffChange instance = (BuffChange)Activator.CreateInstance(GetType());
        HungerSystem.BuffChanges.Add(instance);
    }

    public void Unload() { }
    
}