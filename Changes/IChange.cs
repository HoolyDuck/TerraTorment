namespace TerraTorment.Changes;

public interface IChange
{
    public float GetHungerChange => 0f;

    public float GetThirstChange => 0f;

    public float GetTemperatureChange => 0f;

    public float GetHumidityChange => 0f;
}