using Blasphemous.ModdingAPI;

namespace Blasphemous.Framework.Credits;

/// <summary>
/// Handles appending sections to the game credits
/// </summary>
public class CreditsFramework : BlasMod
{
    internal CreditsFramework() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

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
