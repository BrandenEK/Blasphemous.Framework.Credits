using Blasphemous.ModdingAPI;

namespace Blasphemous.Framework.Credits;

public class Credits : BlasMod
{
    internal Credits() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    protected override void OnInitialize()
    {
        // Perform initialization here
    }
}
