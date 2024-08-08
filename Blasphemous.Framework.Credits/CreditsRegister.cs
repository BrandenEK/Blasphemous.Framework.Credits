using Blasphemous.ModdingAPI;
using System.Collections.Generic;

namespace Blasphemous.Framework.Credits;

/// <summary> Registers a new credits section </summary>
public static class CreditsRegister
{
    private static readonly List<ModCredits> _credits = new();
    internal static IEnumerable<ModCredits> AllCredits => _credits;

    /// <summary> Registers a new credits section </summary>
    public static void RegisterCredits(this ModServiceProvider provider, ModCredits credits)
    {
        if (provider == null)
            return;

        _credits.Add(credits);
        ModLog.Info($"Registered credits section: {credits.GetType().Name}");
    }
}
