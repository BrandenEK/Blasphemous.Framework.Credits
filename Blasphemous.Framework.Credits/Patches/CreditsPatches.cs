using Gameplay.UI.Widgets;
using HarmonyLib;

namespace Blasphemous.Framework.Credits.Patches;

[HarmonyPatch(typeof(CreditsWidget), nameof(CreditsWidget.OnEnable))]
class CreditsWidget_OnEnable_Patch
{
    public static void Prefix(CreditsWidget __instance)
    {
        Main.CreditsFramework.ModifyCredits(__instance);
    }
}
