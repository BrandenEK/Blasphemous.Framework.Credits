using Gameplay.UI.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace Blasphemous.Framework.Credits.Editors;

/// <summary>
/// Creates copies of existing elements and modifies their properties
/// </summary>
public class CreditsEditor : ICreditsEditor
{
    private readonly GameObject _header;
    private readonly GameObject _single;
    private readonly GameObject _double;
    private readonly GameObject _image;
    private readonly GameObject _blank;
    private readonly GameObject _divider;
    private int _insertIdx;

    /// <summary>
    /// Finds base objects and initializes the insert idx
    /// </summary>
    public CreditsEditor(CreditsWidget widget)
    {
        Transform content = widget.transform.GetChild(0).GetChild(0);

        _header = content.Find("<N> Creative Direction").gameObject;
        _single = content.Find("<T> Enrique Cabeza").gameObject;
        _double = content.Find("CAST LINE - Deogracias").gameObject;
        _image = content.Find("<IMG> TGK Logo").gameObject;
        _blank = content.Find("<br>").gameObject;
        _divider = content.Find("_divider_new -----------------------------------").gameObject;
        _insertIdx = content.Find("<N> A Game By").transform.GetSiblingIndex();
    }

    private GameObject CreateBaseObject(GameObject obj)
    {
        GameObject newObj = Object.Instantiate(obj, obj.transform.parent);
        newObj.transform.SetSiblingIndex(_insertIdx++);
        return newObj;
    }

    /// <inheritdoc/>
    public void AddHeader(string text)
    {
        GameObject obj = CreateBaseObject(_header);
        obj.GetComponent<Text>().text = text;
    }

    /// <inheritdoc/>
    public void AddSingle(string text)
    {
        GameObject obj = CreateBaseObject(_single);
        obj.GetComponent<Text>().text = text;
    }

    /// <inheritdoc/>
    public void AddDouble(string left, string right)
    {
        GameObject obj = CreateBaseObject(_double);
        obj.transform.GetChild(0).GetComponent<Text>().text = left;
        obj.transform.GetChild(1).GetComponent<Text>().text = right;
    }

    /// <inheritdoc/>
    public void AddImage(Sprite sprite)
    {
        GameObject obj = CreateBaseObject(_image);
        obj.GetComponent<Image>().sprite = sprite;
    }

    /// <inheritdoc/>
    public void AddBlank()
    {
        CreateBaseObject(_blank);
    }

    /// <inheritdoc/>
    public void AddDivider()
    {
        CreateBaseObject(_divider);
    }
}
