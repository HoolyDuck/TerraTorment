using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using TerraTorment.Systems;

namespace TerraTorment.Content.Hunger.HungerChanges.PassiveChanges.BuffChanges;

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