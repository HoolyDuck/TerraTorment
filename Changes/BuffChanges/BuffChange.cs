using Terraria;
using Terraria.ModLoader;

namespace TerraTorment.Changes.BuffChanges;

public abstract class BuffChange : GlobalBuff, IChange
{
    
    public virtual int ActiveBuffId => -1;

    public virtual float GetHungerChange => 0f;
    
    public virtual float GetThirstChange => 0f;
    
    public virtual float GetTemperatureChange => 0f;
    
    public virtual float GetHumidityChange => 0f;

    public override void Update(int type, Player player, ref int buffIndex)
    {
        if (type == ActiveBuffId)
        {
            player.GetModPlayer<HungerPlayer>().HungerLoss += GetHungerChange;
            player.GetModPlayer<ThirstPlayer>().ThirstLoss += GetThirstChange;
            player.GetModPlayer<TemperaturePlayer>().environmentTemperature += GetTemperatureChange;
            player.GetModPlayer<TemperaturePlayer>().envHumidity += GetHumidityChange;
        }
    }
}