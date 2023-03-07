namespace TerraTorment.Changes;

public interface IChange
{
    public float GetHungerChange();
    
    public float GetHungerGain();

    public float GetThirstChange ();
    
    public float GetThirstGain ();

    public float GetTemperatureChange ();

    public float GetHumidityChange ();
}