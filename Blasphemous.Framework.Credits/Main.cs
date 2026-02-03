using BepInEx;

namespace Blasphemous.Framework.Credits;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "3.0.0")]
internal class Main : BaseUnityPlugin
{
    public static CreditsFramework CreditsFramework { get; private set; }

    private void Start()
    {
        CreditsFramework = new CreditsFramework();
    }
}
