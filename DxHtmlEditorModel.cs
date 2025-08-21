using DevExpress.ExpressApp.Blazor.Components.Models;
using Microsoft.AspNetCore.Components;

namespace AvTex.ExpressApp.Blazor.Editors.Models;

public sealed class DxHtmlEditorModel : DxComponentModelBase
{
    public string Markup
    {
        get => GetPropertyValue<string>();
        set => SetPropertyValue(value);
    }

    public EventCallback<string> MarkupChanged
    {
        get => GetPropertyValue<EventCallback<string>>();
        set => SetPropertyValue(value);
    }

    public string NullText
    {
        get => GetPropertyValue<string>();
        set => SetPropertyValue(value);
    }
}
