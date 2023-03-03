using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using TerraTorment.UI;

namespace TerraTorment.Systems;

public class UISystem : ModSystem
{
    
    private HungerBar HungerBar;
    private UserInterface UserInterface;
    public override void Load()
    {
        HungerBar = new HungerBar();
        HungerBar.Activate();
        UserInterface = new UserInterface();
        UserInterface.SetState(HungerBar);
    }
		
    public override void Unload()
    {
        HungerBar = null;
        UserInterface = null;
    }
		
    public override void UpdateUI(GameTime gameTime)
    {
        UserInterface?.Update(gameTime);
    }
    
    public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
    {
        var inventoryLayer = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
        if (inventoryLayer != -1)
        {
            layers.Insert(inventoryLayer, new LegacyGameInterfaceLayer(
                "TerraTorment: HungerBar",
                delegate
                {
                    HungerBar.Draw(Main.spriteBatch);
                    return true;
                },
                InterfaceScaleType.UI)
            );
        }
    }
}