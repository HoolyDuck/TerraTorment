using Terraria;
using Terraria.ModLoader;
using TerraTorment.Content.Hunger;

namespace TerraTorment.Items;

public class GlobalTileChanges : GlobalTile
{

    public override bool CanKillTile(int i, int j, int type, ref bool blockDamaged)
    {
        HungerPlayer modPlayer = Main.LocalPlayer.GetModPlayer<HungerPlayer>();
        if (modPlayer.tileMineCooldown <= 0)
        {
            modPlayer.tileMineCooldown = 60;

        }
  
        return base.CanKillTile(i, j, type, ref blockDamaged);
    }
    
}