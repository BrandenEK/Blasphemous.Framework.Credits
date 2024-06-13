using Blasphemous.Framework.Credits.Editors;
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
        ICreditsEditor editor = new CreditsEditor(widget);
        int amount = 0;

        foreach (ModCredits credits in CreditsRegister.AllCredits)
        {
            try
            {
                credits.OnDisplay(editor);
                amount++;
            }
            catch (System.Exception e)
            {
                LogError(e);
            }
        }

        Log($"Added {amount} sections to the credits");
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
