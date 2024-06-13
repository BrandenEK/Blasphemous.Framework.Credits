using Blasphemous.ModdingAPI;
using Gameplay.UI.Widgets;

namespace Blasphemous.Framework.Credits;

/// <summary>
/// Handles appending sections to the game credits
/// </summary>
public class CreditsFramework : BlasMod
{
    internal CreditsFramework() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    /// <summary>
    /// Appends all custom sections to the widget whenever it is loaded
    /// </summary>
    internal void ModifyCredits(CreditsWidget widget)
    {

    }

#if DEBUG
    /// <summary>
    /// Register test credits
    /// </summary>
    protected override void OnRegisterServices(ModServiceProvider provider)
    {
        provider.RegisterCredits(new TestCredits());
    }
#endif
}
