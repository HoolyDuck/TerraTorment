using System;

namespace TerraTorment.Utilities.MathUtilities;

public static class MathUtilities
{
    public static float DistanceToPlayer(float x, float y)
    {
        return (float) Math.Sqrt(x * x + y * y);
    }
    
    
}