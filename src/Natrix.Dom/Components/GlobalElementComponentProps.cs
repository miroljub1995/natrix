using System.Globalization;
using System.Runtime.Versioning;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

/// <summary>
/// Props for attributes every element supports, whatever its namespace: <c>role</c> and the
/// <c>aria-*</c> attributes. HTML-only global attributes live in <see cref="GlobalHtmlComponentProps{TElement}"/>.
/// </summary>
/// <remarks>
/// On the client most of these go through the reflected <c>ariaX</c> properties, like the other
/// props. Two groups use <c>setAttribute</c> instead:
/// <list type="bullet">
/// <item>ID-reference attributes (<c>aria-labelledby</c>, <c>aria-controls</c>, ...). They take
/// space-separated ids, since element references cannot be rendered on the server, and their reflected
/// properties (<c>ariaLabelledByElements</c>, ...) take elements, not ids.</item>
/// <item>Attributes whose reflected property is recent or non-standard (<c>aria-braillelabel</c>,
/// <c>aria-brailleroledescription</c>, <c>aria-colindextext</c>, <c>aria-rowindextext</c>,
/// <c>aria-description</c>, <c>aria-relevant</c>). Assigning a property the browser lacks is a silent
/// no-op, while the attribute works everywhere.</item>
/// </list>
/// </remarks>
public class GlobalElementComponentProps<TElement> : BaseDomComponentProps<TElement>
    where TElement : Element
{
    public IReadOnlySignal<string?>? Role { get; init; }
    public IReadOnlySignal<string?>? AriaActiveDescendant { get; init; }
    public IReadOnlySignal<bool>? AriaAtomic { get; init; }
    public IReadOnlySignal<string?>? AriaAutoComplete { get; init; }
    public IReadOnlySignal<string?>? AriaBrailleLabel { get; init; }
    public IReadOnlySignal<string?>? AriaBrailleRoleDescription { get; init; }
    public IReadOnlySignal<bool>? AriaBusy { get; init; }
    public IReadOnlySignal<string?>? AriaChecked { get; init; }
    public IReadOnlySignal<int>? AriaColCount { get; init; }
    public IReadOnlySignal<int>? AriaColIndex { get; init; }
    public IReadOnlySignal<string?>? AriaColIndexText { get; init; }
    public IReadOnlySignal<int>? AriaColSpan { get; init; }
    public IReadOnlySignal<string?>? AriaControls { get; init; }
    public IReadOnlySignal<string?>? AriaCurrent { get; init; }
    public IReadOnlySignal<string?>? AriaDescribedBy { get; init; }
    public IReadOnlySignal<string?>? AriaDescription { get; init; }
    public IReadOnlySignal<string?>? AriaDetails { get; init; }
    public IReadOnlySignal<bool>? AriaDisabled { get; init; }
    public IReadOnlySignal<string?>? AriaErrorMessage { get; init; }
    public IReadOnlySignal<string?>? AriaExpanded { get; init; }
    public IReadOnlySignal<string?>? AriaFlowTo { get; init; }
    public IReadOnlySignal<string?>? AriaHasPopup { get; init; }
    public IReadOnlySignal<bool>? AriaHidden { get; init; }
    public IReadOnlySignal<string?>? AriaInvalid { get; init; }
    public IReadOnlySignal<string?>? AriaKeyShortcuts { get; init; }
    public IReadOnlySignal<string?>? AriaLabel { get; init; }
    public IReadOnlySignal<string?>? AriaLabelledBy { get; init; }
    public IReadOnlySignal<int>? AriaLevel { get; init; }
    public IReadOnlySignal<string?>? AriaLive { get; init; }
    public IReadOnlySignal<bool>? AriaModal { get; init; }
    public IReadOnlySignal<bool>? AriaMultiLine { get; init; }
    public IReadOnlySignal<bool>? AriaMultiSelectable { get; init; }
    public IReadOnlySignal<string?>? AriaOrientation { get; init; }
    public IReadOnlySignal<string?>? AriaOwns { get; init; }
    public IReadOnlySignal<string?>? AriaPlaceholder { get; init; }
    public IReadOnlySignal<int>? AriaPosInSet { get; init; }
    public IReadOnlySignal<string?>? AriaPressed { get; init; }
    public IReadOnlySignal<bool>? AriaReadOnly { get; init; }
    public IReadOnlySignal<string?>? AriaRelevant { get; init; }
    public IReadOnlySignal<bool>? AriaRequired { get; init; }
    public IReadOnlySignal<string?>? AriaRoleDescription { get; init; }
    public IReadOnlySignal<int>? AriaRowCount { get; init; }
    public IReadOnlySignal<int>? AriaRowIndex { get; init; }
    public IReadOnlySignal<string?>? AriaRowIndexText { get; init; }
    public IReadOnlySignal<int>? AriaRowSpan { get; init; }
    public IReadOnlySignal<bool>? AriaSelected { get; init; }
    public IReadOnlySignal<int>? AriaSetSize { get; init; }
    public IReadOnlySignal<string?>? AriaSort { get; init; }
    public IReadOnlySignal<double>? AriaValueMax { get; init; }
    public IReadOnlySignal<double>? AriaValueMin { get; init; }
    public IReadOnlySignal<double>? AriaValueNow { get; init; }
    public IReadOnlySignal<string?>? AriaValueText { get; init; }

    [SupportedOSPlatform("browser")]
    protected internal override void RegisterClientEffects(Action<Action<TElement>> register)
    {
        base.RegisterClientEffects(register);

        if (Role != null)
        {
            register(el => el.Role = Role.Value);
        }

        if (AriaActiveDescendant != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-activedescendant", AriaActiveDescendant.Value));
        }

        if (AriaAtomic != null)
        {
            register(el => el.AriaAtomic = AriaAtomic.Value ? "true" : "false");
        }

        if (AriaAutoComplete != null)
        {
            register(el => el.AriaAutoComplete = AriaAutoComplete.Value);
        }

        if (AriaBrailleLabel != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-braillelabel", AriaBrailleLabel.Value));
        }

        if (AriaBrailleRoleDescription != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-brailleroledescription", AriaBrailleRoleDescription.Value));
        }

        if (AriaBusy != null)
        {
            register(el => el.AriaBusy = AriaBusy.Value ? "true" : "false");
        }

        if (AriaChecked != null)
        {
            register(el => el.AriaChecked = AriaChecked.Value);
        }

        if (AriaColCount != null)
        {
            register(el => el.AriaColCount = AriaColCount.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaColIndex != null)
        {
            register(el => el.AriaColIndex = AriaColIndex.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaColIndexText != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-colindextext", AriaColIndexText.Value));
        }

        if (AriaColSpan != null)
        {
            register(el => el.AriaColSpan = AriaColSpan.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaControls != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-controls", AriaControls.Value));
        }

        if (AriaCurrent != null)
        {
            register(el => el.AriaCurrent = AriaCurrent.Value);
        }

        if (AriaDescribedBy != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-describedby", AriaDescribedBy.Value));
        }

        if (AriaDescription != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-description", AriaDescription.Value));
        }

        if (AriaDetails != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-details", AriaDetails.Value));
        }

        if (AriaDisabled != null)
        {
            register(el => el.AriaDisabled = AriaDisabled.Value ? "true" : "false");
        }

        if (AriaErrorMessage != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-errormessage", AriaErrorMessage.Value));
        }

        if (AriaExpanded != null)
        {
            register(el => el.AriaExpanded = AriaExpanded.Value);
        }

        if (AriaFlowTo != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-flowto", AriaFlowTo.Value));
        }

        if (AriaHasPopup != null)
        {
            register(el => el.AriaHasPopup = AriaHasPopup.Value);
        }

        if (AriaHidden != null)
        {
            register(el => el.AriaHidden = AriaHidden.Value ? "true" : "false");
        }

        if (AriaInvalid != null)
        {
            register(el => el.AriaInvalid = AriaInvalid.Value);
        }

        if (AriaKeyShortcuts != null)
        {
            register(el => el.AriaKeyShortcuts = AriaKeyShortcuts.Value);
        }

        if (AriaLabel != null)
        {
            register(el => el.AriaLabel = AriaLabel.Value);
        }

        if (AriaLabelledBy != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-labelledby", AriaLabelledBy.Value));
        }

        if (AriaLevel != null)
        {
            register(el => el.AriaLevel = AriaLevel.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaLive != null)
        {
            register(el => el.AriaLive = AriaLive.Value);
        }

        if (AriaModal != null)
        {
            register(el => el.AriaModal = AriaModal.Value ? "true" : "false");
        }

        if (AriaMultiLine != null)
        {
            register(el => el.AriaMultiLine = AriaMultiLine.Value ? "true" : "false");
        }

        if (AriaMultiSelectable != null)
        {
            register(el => el.AriaMultiSelectable = AriaMultiSelectable.Value ? "true" : "false");
        }

        if (AriaOrientation != null)
        {
            register(el => el.AriaOrientation = AriaOrientation.Value);
        }

        if (AriaOwns != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-owns", AriaOwns.Value));
        }

        if (AriaPlaceholder != null)
        {
            register(el => el.AriaPlaceholder = AriaPlaceholder.Value);
        }

        if (AriaPosInSet != null)
        {
            register(el => el.AriaPosInSet = AriaPosInSet.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaPressed != null)
        {
            register(el => el.AriaPressed = AriaPressed.Value);
        }

        if (AriaReadOnly != null)
        {
            register(el => el.AriaReadOnly = AriaReadOnly.Value ? "true" : "false");
        }

        if (AriaRelevant != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-relevant", AriaRelevant.Value));
        }

        if (AriaRequired != null)
        {
            register(el => el.AriaRequired = AriaRequired.Value ? "true" : "false");
        }

        if (AriaRoleDescription != null)
        {
            register(el => el.AriaRoleDescription = AriaRoleDescription.Value);
        }

        if (AriaRowCount != null)
        {
            register(el => el.AriaRowCount = AriaRowCount.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaRowIndex != null)
        {
            register(el => el.AriaRowIndex = AriaRowIndex.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaRowIndexText != null)
        {
            register(el => SetOrRemoveAttribute(el, "aria-rowindextext", AriaRowIndexText.Value));
        }

        if (AriaRowSpan != null)
        {
            register(el => el.AriaRowSpan = AriaRowSpan.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaSelected != null)
        {
            register(el => el.AriaSelected = AriaSelected.Value ? "true" : "false");
        }

        if (AriaSetSize != null)
        {
            register(el => el.AriaSetSize = AriaSetSize.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaSort != null)
        {
            register(el => el.AriaSort = AriaSort.Value);
        }

        if (AriaValueMax != null)
        {
            register(el => el.AriaValueMax = AriaValueMax.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaValueMin != null)
        {
            register(el => el.AriaValueMin = AriaValueMin.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaValueNow != null)
        {
            register(el => el.AriaValueNow = AriaValueNow.Value.ToString(CultureInfo.InvariantCulture));
        }

        if (AriaValueText != null)
        {
            register(el => el.AriaValueText = AriaValueText.Value);
        }
    }

    protected internal override void RegisterServerEffects(SsrElementNode el)
    {
        base.RegisterServerEffects(el);

        if (Role != null)
        {
            el.SetNullableString("role", Role);
        }

        if (AriaActiveDescendant != null)
        {
            el.SetNullableString("aria-activedescendant", AriaActiveDescendant);
        }

        if (AriaAtomic != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-atomic", AriaAtomic);
        }

        if (AriaAutoComplete != null)
        {
            el.SetNullableString("aria-autocomplete", AriaAutoComplete);
        }

        if (AriaBrailleLabel != null)
        {
            el.SetNullableString("aria-braillelabel", AriaBrailleLabel);
        }

        if (AriaBrailleRoleDescription != null)
        {
            el.SetNullableString("aria-brailleroledescription", AriaBrailleRoleDescription);
        }

        if (AriaBusy != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-busy", AriaBusy);
        }

        if (AriaChecked != null)
        {
            el.SetNullableString("aria-checked", AriaChecked);
        }

        if (AriaColCount != null)
        {
            el.SetInt("aria-colcount", AriaColCount);
        }

        if (AriaColIndex != null)
        {
            el.SetInt("aria-colindex", AriaColIndex);
        }

        if (AriaColIndexText != null)
        {
            el.SetNullableString("aria-colindextext", AriaColIndexText);
        }

        if (AriaColSpan != null)
        {
            el.SetInt("aria-colspan", AriaColSpan);
        }

        if (AriaControls != null)
        {
            el.SetNullableString("aria-controls", AriaControls);
        }

        if (AriaCurrent != null)
        {
            el.SetNullableString("aria-current", AriaCurrent);
        }

        if (AriaDescribedBy != null)
        {
            el.SetNullableString("aria-describedby", AriaDescribedBy);
        }

        if (AriaDescription != null)
        {
            el.SetNullableString("aria-description", AriaDescription);
        }

        if (AriaDetails != null)
        {
            el.SetNullableString("aria-details", AriaDetails);
        }

        if (AriaDisabled != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-disabled", AriaDisabled);
        }

        if (AriaErrorMessage != null)
        {
            el.SetNullableString("aria-errormessage", AriaErrorMessage);
        }

        if (AriaExpanded != null)
        {
            el.SetNullableString("aria-expanded", AriaExpanded);
        }

        if (AriaFlowTo != null)
        {
            el.SetNullableString("aria-flowto", AriaFlowTo);
        }

        if (AriaHasPopup != null)
        {
            el.SetNullableString("aria-haspopup", AriaHasPopup);
        }

        if (AriaHidden != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-hidden", AriaHidden);
        }

        if (AriaInvalid != null)
        {
            el.SetNullableString("aria-invalid", AriaInvalid);
        }

        if (AriaKeyShortcuts != null)
        {
            el.SetNullableString("aria-keyshortcuts", AriaKeyShortcuts);
        }

        if (AriaLabel != null)
        {
            el.SetNullableString("aria-label", AriaLabel);
        }

        if (AriaLabelledBy != null)
        {
            el.SetNullableString("aria-labelledby", AriaLabelledBy);
        }

        if (AriaLevel != null)
        {
            el.SetInt("aria-level", AriaLevel);
        }

        if (AriaLive != null)
        {
            el.SetNullableString("aria-live", AriaLive);
        }

        if (AriaModal != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-modal", AriaModal);
        }

        if (AriaMultiLine != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-multiline", AriaMultiLine);
        }

        if (AriaMultiSelectable != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-multiselectable", AriaMultiSelectable);
        }

        if (AriaOrientation != null)
        {
            el.SetNullableString("aria-orientation", AriaOrientation);
        }

        if (AriaOwns != null)
        {
            el.SetNullableString("aria-owns", AriaOwns);
        }

        if (AriaPlaceholder != null)
        {
            el.SetNullableString("aria-placeholder", AriaPlaceholder);
        }

        if (AriaPosInSet != null)
        {
            el.SetInt("aria-posinset", AriaPosInSet);
        }

        if (AriaPressed != null)
        {
            el.SetNullableString("aria-pressed", AriaPressed);
        }

        if (AriaReadOnly != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-readonly", AriaReadOnly);
        }

        if (AriaRelevant != null)
        {
            el.SetNullableString("aria-relevant", AriaRelevant);
        }

        if (AriaRequired != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-required", AriaRequired);
        }

        if (AriaRoleDescription != null)
        {
            el.SetNullableString("aria-roledescription", AriaRoleDescription);
        }

        if (AriaRowCount != null)
        {
            el.SetInt("aria-rowcount", AriaRowCount);
        }

        if (AriaRowIndex != null)
        {
            el.SetInt("aria-rowindex", AriaRowIndex);
        }

        if (AriaRowIndexText != null)
        {
            el.SetNullableString("aria-rowindextext", AriaRowIndexText);
        }

        if (AriaRowSpan != null)
        {
            el.SetInt("aria-rowspan", AriaRowSpan);
        }

        if (AriaSelected != null)
        {
            el.SetEnumeratedBoolTrueFalse("aria-selected", AriaSelected);
        }

        if (AriaSetSize != null)
        {
            el.SetInt("aria-setsize", AriaSetSize);
        }

        if (AriaSort != null)
        {
            el.SetNullableString("aria-sort", AriaSort);
        }

        if (AriaValueMax != null)
        {
            el.SetDouble("aria-valuemax", AriaValueMax);
        }

        if (AriaValueMin != null)
        {
            el.SetDouble("aria-valuemin", AriaValueMin);
        }

        if (AriaValueNow != null)
        {
            el.SetDouble("aria-valuenow", AriaValueNow);
        }

        if (AriaValueText != null)
        {
            el.SetNullableString("aria-valuetext", AriaValueText);
        }
    }

    [SupportedOSPlatform("browser")]
    private static void SetOrRemoveAttribute(TElement el, string name, string? value)
    {
        if (value is null)
        {
            el.RemoveAttribute(name);
        }
        else
        {
            el.SetAttribute(name, value);
        }
    }
}
