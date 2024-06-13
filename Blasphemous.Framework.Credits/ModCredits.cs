
namespace Blasphemous.Framework.Credits;

/// <summary>
/// Contains functionality for appending info to the credits scene
/// </summary>
public abstract class ModCredits
{
    /// <summary>
    /// Called whenever the credits scene is loaded and modifications are ready to be made
    /// </summary>
    protected internal abstract void OnDisplay(ICreditsEditor editor);
}
