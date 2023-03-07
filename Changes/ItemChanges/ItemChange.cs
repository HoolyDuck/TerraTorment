using Terraria.ModLoader;

namespace TerraTorment.Changes.ItemChanges;

public abstract class ItemChange : GlobalItem, IChange
{
    public virtual int ItemId => -1;
    
    public virtual float GetHungerChange => 0f;
    
    public virtual float GetHungerGain => 0f;

    public virtual float GetThirstChange => 0f;
    
    public virtual float GetThirstGain => 0f;

    public virtual float GetTemperatureChange => 0f;

    public virtual float GetHumidityChange => 0f;
    
    
    
    
    
    

}