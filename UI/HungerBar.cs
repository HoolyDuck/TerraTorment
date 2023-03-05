
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace TerraTorment.UI;

public class HungerBar : UIState
{
    public UIText hungerText;

    public override void OnInitialize()
    {
        hungerText = new UIText("Hunger: 100, HungerChange: 0");
        hungerText.Top.Set(20, 0f);
        hungerText.Left.Set(0, .7f);
        hungerText.Width.Set(200, 0f);
        hungerText.Height.Set(50, 0f);
        Append(hungerText);
    }
    
    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        var modPlayer = Main.LocalPlayer.GetModPlayer<HungerPlayer>();
        hungerText.SetText($"Hunger: {modPlayer.Hunger}, HungerChange: {modPlayer.hungerChange}");
        
    }
}