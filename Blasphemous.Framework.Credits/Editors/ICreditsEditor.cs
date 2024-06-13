using UnityEngine;

namespace Blasphemous.Framework.Credits.Editors;

/// <summary>
/// Interface for adding elements to the credits scene
/// </summary>
public interface ICreditsEditor
{
    /// <summary>
    /// Adds a line of large red text
    /// </summary>
    void AddHeader(string text);

    /// <summary>
    /// Adds a line of regular text
    /// </summary>
    void AddSingle(string text);

    /// <summary>
    /// Adds a line of regular text with two parts
    /// </summary>
    void AddDouble(string left, string right);

    /// <summary>
    /// Adds an image
    /// </summary>
    void AddImage(Sprite sprite);

    /// <summary>
    /// Adds a single blank line
    /// </summary>
    void AddBlank();

    /// <summary>
    /// Adds a large blank space
    /// </summary>
    void AddDivider();
}
