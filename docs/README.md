# Blasphemous Credits Framework

<img src="https://img.shields.io/github/downloads/BrandenEK/Blasphemous.Framework.Credits/total?color=6495ED&style=for-the-badge">

---

## Usage
- Allows other mods to declare text/image sections that will be added to the credits scene

## Development
Example credits section:
```cs
internal class TestCredits : ModCredits
{
    protected internal override void OnDisplay(ICreditsEditor editor)
    {
        editor.AddHeader("Test section title");
        editor.AddSingle("Test person one");
        editor.AddSingle("Test person two");
        editor.AddSingle("Test person three");
        editor.AddBlank();

        editor.AddDivider();
        editor.AddBlank();
    }
}
```

## Installation
This mod is available for download through the [Blasphemous Mod Installer](https://github.com/BrandenEK/Blasphemous.Modding.Installer)
- Required dependencies: Modding API
