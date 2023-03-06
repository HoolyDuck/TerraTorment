  
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace TerraTorment.UI;

public class HungerBar : UIState
{
    public UIText hungerText;
    public UIText thirstText;
    public UIText envTemperatureText;

    public override void OnInitialize()
    {
        hungerText = new UIText("Hunger: 100, HungerChange: 0");
        hungerText.Top.Set(20, 0f);
        hungerText.Left.Set(0, .7f);
        hungerText.Width.Set(200, 0f);
        hungerText.Height.Set(50, 0f);
        Append(hungerText);
        
        thirstText = new UIText("Thirst: 100, ThirstLoss: 0");
        thirstText.Top.Set(50, 0f);
        thirstText.Left.Set(0, .7f);
        thirstText.Width.Set(200, 0f);
        thirstText.Height.Set(50, 0f);
        Append(thirstText);
        
        // move elsewhere later
        envTemperatureText = new UIText("Environment Temperature: 22");
        envTemperatureText.Top.Set(80, 0f);
        envTemperatureText.Left.Set(0, .7f);
        envTemperatureText.Width.Set(200, 0f);
        envTemperatureText.Height.Set(50, 0f);
        Append(envTemperatureText);


    }
    
    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        var hungerPlayer = Main.LocalPlayer.GetModPlayer<HungerPlayer>();
        var thirstPlayer = Main.LocalPlayer.GetModPlayer<ThirstPlayer>();
        var temperaturePlayer = Main.LocalPlayer.GetModPlayer<TemperaturePlayer>();
        hungerText.SetText($"Hunger: {hungerPlayer.Hunger}, HungerChange: {hungerPlayer.hungerChange}");
        thirstText.SetText($"Thirst: {thirstPlayer.Thirst}, ThirstLoss: {thirstPlayer.ThirstLoss}");
        envTemperatureText.SetText($"Environment Temperature: {temperaturePlayer.environmentTemperature}");
        
    }
}