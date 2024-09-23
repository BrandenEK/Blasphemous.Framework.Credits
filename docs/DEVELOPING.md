# Credits Framework documentation

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
