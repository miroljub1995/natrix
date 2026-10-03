using System.Diagnostics.CodeAnalysis;
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
[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class GlobalElementComponentProps<TElement> : BaseDomComponentProps<TElement>
    where TElement : Element
{
    private static readonly PropDescriptor<string?> s_role = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.Role = s.Value
            : null,
        static (el, s) => el.SetNullableString("role", s));

    public IReadOnlySignal<string?>? Role
    {
        get => Get(s_role);
        init => Set(s_role, value);
    }

    private static readonly PropDescriptor<string?> s_ariaActiveDescendant = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-activedescendant", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-activedescendant", s));

    public IReadOnlySignal<string?>? AriaActiveDescendant
    {
        get => Get(s_ariaActiveDescendant);
        init => Set(s_ariaActiveDescendant, value);
    }

    private static readonly PropDescriptor<bool> s_ariaAtomic = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaAtomic = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-atomic", s));

    public IReadOnlySignal<bool>? AriaAtomic
    {
        get => Get(s_ariaAtomic);
        init => Set(s_ariaAtomic, value);
    }

    private static readonly PropDescriptor<string?> s_ariaAutoComplete = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaAutoComplete = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-autocomplete", s));

    public IReadOnlySignal<string?>? AriaAutoComplete
    {
        get => Get(s_ariaAutoComplete);
        init => Set(s_ariaAutoComplete, value);
    }

    private static readonly PropDescriptor<string?> s_ariaBrailleLabel = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-braillelabel", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-braillelabel", s));

    public IReadOnlySignal<string?>? AriaBrailleLabel
    {
        get => Get(s_ariaBrailleLabel);
        init => Set(s_ariaBrailleLabel, value);
    }

    private static readonly PropDescriptor<string?> s_ariaBrailleRoleDescription = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-brailleroledescription", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-brailleroledescription", s));

    public IReadOnlySignal<string?>? AriaBrailleRoleDescription
    {
        get => Get(s_ariaBrailleRoleDescription);
        init => Set(s_ariaBrailleRoleDescription, value);
    }

    private static readonly PropDescriptor<bool> s_ariaBusy = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaBusy = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-busy", s));

    public IReadOnlySignal<bool>? AriaBusy
    {
        get => Get(s_ariaBusy);
        init => Set(s_ariaBusy, value);
    }

    private static readonly PropDescriptor<string?> s_ariaChecked = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaChecked = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-checked", s));

    public IReadOnlySignal<string?>? AriaChecked
    {
        get => Get(s_ariaChecked);
        init => Set(s_ariaChecked, value);
    }

    private static readonly PropDescriptor<int> s_ariaColCount = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaColCount = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-colcount", s));

    public IReadOnlySignal<int>? AriaColCount
    {
        get => Get(s_ariaColCount);
        init => Set(s_ariaColCount, value);
    }

    private static readonly PropDescriptor<int> s_ariaColIndex = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaColIndex = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-colindex", s));

    public IReadOnlySignal<int>? AriaColIndex
    {
        get => Get(s_ariaColIndex);
        init => Set(s_ariaColIndex, value);
    }

    private static readonly PropDescriptor<string?> s_ariaColIndexText = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-colindextext", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-colindextext", s));

    public IReadOnlySignal<string?>? AriaColIndexText
    {
        get => Get(s_ariaColIndexText);
        init => Set(s_ariaColIndexText, value);
    }

    private static readonly PropDescriptor<int> s_ariaColSpan = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaColSpan = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-colspan", s));

    public IReadOnlySignal<int>? AriaColSpan
    {
        get => Get(s_ariaColSpan);
        init => Set(s_ariaColSpan, value);
    }

    private static readonly PropDescriptor<string?> s_ariaControls = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-controls", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-controls", s));

    public IReadOnlySignal<string?>? AriaControls
    {
        get => Get(s_ariaControls);
        init => Set(s_ariaControls, value);
    }

    private static readonly PropDescriptor<string?> s_ariaCurrent = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaCurrent = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-current", s));

    public IReadOnlySignal<string?>? AriaCurrent
    {
        get => Get(s_ariaCurrent);
        init => Set(s_ariaCurrent, value);
    }

    private static readonly PropDescriptor<string?> s_ariaDescribedBy = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-describedby", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-describedby", s));

    public IReadOnlySignal<string?>? AriaDescribedBy
    {
        get => Get(s_ariaDescribedBy);
        init => Set(s_ariaDescribedBy, value);
    }

    private static readonly PropDescriptor<string?> s_ariaDescription = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-description", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-description", s));

    public IReadOnlySignal<string?>? AriaDescription
    {
        get => Get(s_ariaDescription);
        init => Set(s_ariaDescription, value);
    }

    private static readonly PropDescriptor<string?> s_ariaDetails = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-details", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-details", s));

    public IReadOnlySignal<string?>? AriaDetails
    {
        get => Get(s_ariaDetails);
        init => Set(s_ariaDetails, value);
    }

    private static readonly PropDescriptor<bool> s_ariaDisabled = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaDisabled = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-disabled", s));

    public IReadOnlySignal<bool>? AriaDisabled
    {
        get => Get(s_ariaDisabled);
        init => Set(s_ariaDisabled, value);
    }

    private static readonly PropDescriptor<string?> s_ariaErrorMessage = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-errormessage", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-errormessage", s));

    public IReadOnlySignal<string?>? AriaErrorMessage
    {
        get => Get(s_ariaErrorMessage);
        init => Set(s_ariaErrorMessage, value);
    }

    private static readonly PropDescriptor<string?> s_ariaExpanded = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaExpanded = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-expanded", s));

    public IReadOnlySignal<string?>? AriaExpanded
    {
        get => Get(s_ariaExpanded);
        init => Set(s_ariaExpanded, value);
    }

    private static readonly PropDescriptor<string?> s_ariaFlowTo = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-flowto", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-flowto", s));

    public IReadOnlySignal<string?>? AriaFlowTo
    {
        get => Get(s_ariaFlowTo);
        init => Set(s_ariaFlowTo, value);
    }

    private static readonly PropDescriptor<string?> s_ariaHasPopup = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaHasPopup = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-haspopup", s));

    public IReadOnlySignal<string?>? AriaHasPopup
    {
        get => Get(s_ariaHasPopup);
        init => Set(s_ariaHasPopup, value);
    }

    private static readonly PropDescriptor<bool> s_ariaHidden = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaHidden = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-hidden", s));

    public IReadOnlySignal<bool>? AriaHidden
    {
        get => Get(s_ariaHidden);
        init => Set(s_ariaHidden, value);
    }

    private static readonly PropDescriptor<string?> s_ariaInvalid = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaInvalid = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-invalid", s));

    public IReadOnlySignal<string?>? AriaInvalid
    {
        get => Get(s_ariaInvalid);
        init => Set(s_ariaInvalid, value);
    }

    private static readonly PropDescriptor<string?> s_ariaKeyShortcuts = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaKeyShortcuts = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-keyshortcuts", s));

    public IReadOnlySignal<string?>? AriaKeyShortcuts
    {
        get => Get(s_ariaKeyShortcuts);
        init => Set(s_ariaKeyShortcuts, value);
    }

    private static readonly PropDescriptor<string?> s_ariaLabel = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaLabel = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-label", s));

    public IReadOnlySignal<string?>? AriaLabel
    {
        get => Get(s_ariaLabel);
        init => Set(s_ariaLabel, value);
    }

    private static readonly PropDescriptor<string?> s_ariaLabelledBy = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-labelledby", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-labelledby", s));

    public IReadOnlySignal<string?>? AriaLabelledBy
    {
        get => Get(s_ariaLabelledBy);
        init => Set(s_ariaLabelledBy, value);
    }

    private static readonly PropDescriptor<int> s_ariaLevel = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaLevel = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-level", s));

    public IReadOnlySignal<int>? AriaLevel
    {
        get => Get(s_ariaLevel);
        init => Set(s_ariaLevel, value);
    }

    private static readonly PropDescriptor<string?> s_ariaLive = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaLive = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-live", s));

    public IReadOnlySignal<string?>? AriaLive
    {
        get => Get(s_ariaLive);
        init => Set(s_ariaLive, value);
    }

    private static readonly PropDescriptor<bool> s_ariaModal = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaModal = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-modal", s));

    public IReadOnlySignal<bool>? AriaModal
    {
        get => Get(s_ariaModal);
        init => Set(s_ariaModal, value);
    }

    private static readonly PropDescriptor<bool> s_ariaMultiLine = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaMultiLine = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-multiline", s));

    public IReadOnlySignal<bool>? AriaMultiLine
    {
        get => Get(s_ariaMultiLine);
        init => Set(s_ariaMultiLine, value);
    }

    private static readonly PropDescriptor<bool> s_ariaMultiSelectable = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaMultiSelectable = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-multiselectable", s));

    public IReadOnlySignal<bool>? AriaMultiSelectable
    {
        get => Get(s_ariaMultiSelectable);
        init => Set(s_ariaMultiSelectable, value);
    }

    private static readonly PropDescriptor<string?> s_ariaOrientation = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaOrientation = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-orientation", s));

    public IReadOnlySignal<string?>? AriaOrientation
    {
        get => Get(s_ariaOrientation);
        init => Set(s_ariaOrientation, value);
    }

    private static readonly PropDescriptor<string?> s_ariaOwns = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-owns", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-owns", s));

    public IReadOnlySignal<string?>? AriaOwns
    {
        get => Get(s_ariaOwns);
        init => Set(s_ariaOwns, value);
    }

    private static readonly PropDescriptor<string?> s_ariaPlaceholder = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaPlaceholder = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-placeholder", s));

    public IReadOnlySignal<string?>? AriaPlaceholder
    {
        get => Get(s_ariaPlaceholder);
        init => Set(s_ariaPlaceholder, value);
    }

    private static readonly PropDescriptor<int> s_ariaPosInSet = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaPosInSet = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-posinset", s));

    public IReadOnlySignal<int>? AriaPosInSet
    {
        get => Get(s_ariaPosInSet);
        init => Set(s_ariaPosInSet, value);
    }

    private static readonly PropDescriptor<string?> s_ariaPressed = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaPressed = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-pressed", s));

    public IReadOnlySignal<string?>? AriaPressed
    {
        get => Get(s_ariaPressed);
        init => Set(s_ariaPressed, value);
    }

    private static readonly PropDescriptor<bool> s_ariaReadOnly = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaReadOnly = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-readonly", s));

    public IReadOnlySignal<bool>? AriaReadOnly
    {
        get => Get(s_ariaReadOnly);
        init => Set(s_ariaReadOnly, value);
    }

    private static readonly PropDescriptor<string?> s_ariaRelevant = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-relevant", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-relevant", s));

    public IReadOnlySignal<string?>? AriaRelevant
    {
        get => Get(s_ariaRelevant);
        init => Set(s_ariaRelevant, value);
    }

    private static readonly PropDescriptor<bool> s_ariaRequired = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaRequired = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-required", s));

    public IReadOnlySignal<bool>? AriaRequired
    {
        get => Get(s_ariaRequired);
        init => Set(s_ariaRequired, value);
    }

    private static readonly PropDescriptor<string?> s_ariaRoleDescription = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaRoleDescription = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-roledescription", s));

    public IReadOnlySignal<string?>? AriaRoleDescription
    {
        get => Get(s_ariaRoleDescription);
        init => Set(s_ariaRoleDescription, value);
    }

    private static readonly PropDescriptor<int> s_ariaRowCount = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaRowCount = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-rowcount", s));

    public IReadOnlySignal<int>? AriaRowCount
    {
        get => Get(s_ariaRowCount);
        init => Set(s_ariaRowCount, value);
    }

    private static readonly PropDescriptor<int> s_ariaRowIndex = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaRowIndex = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-rowindex", s));

    public IReadOnlySignal<int>? AriaRowIndex
    {
        get => Get(s_ariaRowIndex);
        init => Set(s_ariaRowIndex, value);
    }

    private static readonly PropDescriptor<string?> s_ariaRowIndexText = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => SetOrRemoveAttribute(el, "aria-rowindextext", s.Value)
            : null,
        static (el, s) => el.SetNullableString("aria-rowindextext", s));

    public IReadOnlySignal<string?>? AriaRowIndexText
    {
        get => Get(s_ariaRowIndexText);
        init => Set(s_ariaRowIndexText, value);
    }

    private static readonly PropDescriptor<int> s_ariaRowSpan = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaRowSpan = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-rowspan", s));

    public IReadOnlySignal<int>? AriaRowSpan
    {
        get => Get(s_ariaRowSpan);
        init => Set(s_ariaRowSpan, value);
    }

    private static readonly PropDescriptor<bool> s_ariaSelected = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaSelected = s.Value ? "true" : "false"
            : null,
        static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-selected", s));

    public IReadOnlySignal<bool>? AriaSelected
    {
        get => Get(s_ariaSelected);
        init => Set(s_ariaSelected, value);
    }

    private static readonly PropDescriptor<int> s_ariaSetSize = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaSetSize = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetInt("aria-setsize", s));

    public IReadOnlySignal<int>? AriaSetSize
    {
        get => Get(s_ariaSetSize);
        init => Set(s_ariaSetSize, value);
    }

    private static readonly PropDescriptor<string?> s_ariaSort = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaSort = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-sort", s));

    public IReadOnlySignal<string?>? AriaSort
    {
        get => Get(s_ariaSort);
        init => Set(s_ariaSort, value);
    }

    private static readonly PropDescriptor<double> s_ariaValueMax = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaValueMax = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetDouble("aria-valuemax", s));

    public IReadOnlySignal<double>? AriaValueMax
    {
        get => Get(s_ariaValueMax);
        init => Set(s_ariaValueMax, value);
    }

    private static readonly PropDescriptor<double> s_ariaValueMin = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaValueMin = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetDouble("aria-valuemin", s));

    public IReadOnlySignal<double>? AriaValueMin
    {
        get => Get(s_ariaValueMin);
        init => Set(s_ariaValueMin, value);
    }

    private static readonly PropDescriptor<double> s_ariaValueNow = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaValueNow = s.Value.ToString(CultureInfo.InvariantCulture)
            : null,
        static (el, s) => el.SetDouble("aria-valuenow", s));

    public IReadOnlySignal<double>? AriaValueNow
    {
        get => Get(s_ariaValueNow);
        init => Set(s_ariaValueNow, value);
    }

    private static readonly PropDescriptor<string?> s_ariaValueText = new(
        OperatingSystem.IsBrowser()
            ? static (el, s) => el.AriaValueText = s.Value
            : null,
        static (el, s) => el.SetNullableString("aria-valuetext", s));

    public IReadOnlySignal<string?>? AriaValueText
    {
        get => Get(s_ariaValueText);
        init => Set(s_ariaValueText, value);
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
