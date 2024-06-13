﻿using BepInEx;

namespace Blasphemous.Framework.Credits;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "0.1.0")]
internal class Main : BaseUnityPlugin
{
    public static Credits Credits { get; private set; }

    private void Start()
    {
        Credits = new Credits();
    }
}
