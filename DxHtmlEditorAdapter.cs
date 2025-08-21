using DevExpress.ExpressApp.Blazor.Components;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Utils;
using AvTex.ExpressApp.Blazor.Editors.Models;
using AvTex.ExpressApp.Blazor.Editors.Renderers;
using Microsoft.AspNetCore.Components;

namespace AvTex.ExpressApp.Blazor.Editors.Adapters;

public sealed class DxHtmlEditorAdapter : ComponentAdapterBase
{
    public DxHtmlEditorAdapter(DxHtmlEditorModel componentModel)
    {
        ComponentModel = componentModel ?? throw new ArgumentNullException(nameof(componentModel));
        ComponentModel.MarkupChanged = EventCallback.Factory.Create<string>(this, (markup) =>
        {
            if (!componentModel.Markup.Equals(markup) && !ComponentModel.ReadOnly)
            {
                componentModel.Markup = markup;
                RaiseValueChanged();
            }
        });
    }

    public override DxHtmlEditorModel ComponentModel { get; }

    public override object GetValue()
    {
        return ComponentModel.Markup;
    }

    public override void SetAllowEdit(bool allowEdit)
    {
        ComponentModel.ReadOnly = !allowEdit;
    }

    public override void SetAllowNull(bool allowNull)
    {
    }

    public override void SetDisplayFormat(string displayFormat)
    {
    }

    public override void SetEditMask(string editMask)
    {
    }

    public override void SetEditMaskType(EditMaskType editMaskType)
    {
    }

    public override void SetErrorIcon(ImageInfo errorIcon)
    {
    }

    public override void SetErrorMessage(string errorMessage)
    {
    }

    public override void SetIsPassword(bool isPassword)
    {
    }

    public override void SetMaxLength(int maxLength)
    {
    }

    public override void SetNullText(string nullText)
    {
        ComponentModel.NullText = nullText;
    }

    public override void SetValue(object value)
    {
        ComponentModel.Markup = (string)value ?? string.Empty;
    }

    protected override RenderFragment CreateComponent()
    {
        return ComponentModelObserver.Create(ComponentModel, DxHtmlEditorRenderer.Create(ComponentModel));
    }
}
