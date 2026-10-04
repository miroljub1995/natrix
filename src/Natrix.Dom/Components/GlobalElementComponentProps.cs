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
    private static PropDescriptor<string?>? s_role;

    public IReadOnlySignal<string?>? Role
    {
        get => Get(s_role);
        init => Set(ref s_role, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Role = s.Value;
            },
            static (el, s) => el.SetNullableString("role", s)));
    }

    private static PropDescriptor<string?>? s_ariaActiveDescendant;

    public IReadOnlySignal<string?>? AriaActiveDescendant
    {
        get => Get(s_ariaActiveDescendant);
        init => Set(ref s_ariaActiveDescendant, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-activedescendant", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-activedescendant", s)));
    }

    private static PropDescriptor<bool>? s_ariaAtomic;

    public IReadOnlySignal<bool>? AriaAtomic
    {
        get => Get(s_ariaAtomic);
        init => Set(ref s_ariaAtomic, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaAtomic = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-atomic", s)));
    }

    private static PropDescriptor<string?>? s_ariaAutoComplete;

    public IReadOnlySignal<string?>? AriaAutoComplete
    {
        get => Get(s_ariaAutoComplete);
        init => Set(ref s_ariaAutoComplete, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaAutoComplete = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-autocomplete", s)));
    }

    private static PropDescriptor<string?>? s_ariaBrailleLabel;

    public IReadOnlySignal<string?>? AriaBrailleLabel
    {
        get => Get(s_ariaBrailleLabel);
        init => Set(ref s_ariaBrailleLabel, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-braillelabel", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-braillelabel", s)));
    }

    private static PropDescriptor<string?>? s_ariaBrailleRoleDescription;

    public IReadOnlySignal<string?>? AriaBrailleRoleDescription
    {
        get => Get(s_ariaBrailleRoleDescription);
        init => Set(ref s_ariaBrailleRoleDescription, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-brailleroledescription", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-brailleroledescription", s)));
    }

    private static PropDescriptor<bool>? s_ariaBusy;

    public IReadOnlySignal<bool>? AriaBusy
    {
        get => Get(s_ariaBusy);
        init => Set(ref s_ariaBusy, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaBusy = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-busy", s)));
    }

    private static PropDescriptor<string?>? s_ariaChecked;

    public IReadOnlySignal<string?>? AriaChecked
    {
        get => Get(s_ariaChecked);
        init => Set(ref s_ariaChecked, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaChecked = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-checked", s)));
    }

    private static PropDescriptor<int>? s_ariaColCount;

    public IReadOnlySignal<int>? AriaColCount
    {
        get => Get(s_ariaColCount);
        init => Set(ref s_ariaColCount, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaColCount = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-colcount", s)));
    }

    private static PropDescriptor<int>? s_ariaColIndex;

    public IReadOnlySignal<int>? AriaColIndex
    {
        get => Get(s_ariaColIndex);
        init => Set(ref s_ariaColIndex, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaColIndex = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-colindex", s)));
    }

    private static PropDescriptor<string?>? s_ariaColIndexText;

    public IReadOnlySignal<string?>? AriaColIndexText
    {
        get => Get(s_ariaColIndexText);
        init => Set(ref s_ariaColIndexText, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-colindextext", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-colindextext", s)));
    }

    private static PropDescriptor<int>? s_ariaColSpan;

    public IReadOnlySignal<int>? AriaColSpan
    {
        get => Get(s_ariaColSpan);
        init => Set(ref s_ariaColSpan, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaColSpan = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-colspan", s)));
    }

    private static PropDescriptor<string?>? s_ariaControls;

    public IReadOnlySignal<string?>? AriaControls
    {
        get => Get(s_ariaControls);
        init => Set(ref s_ariaControls, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-controls", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-controls", s)));
    }

    private static PropDescriptor<string?>? s_ariaCurrent;

    public IReadOnlySignal<string?>? AriaCurrent
    {
        get => Get(s_ariaCurrent);
        init => Set(ref s_ariaCurrent, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaCurrent = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-current", s)));
    }

    private static PropDescriptor<string?>? s_ariaDescribedBy;

    public IReadOnlySignal<string?>? AriaDescribedBy
    {
        get => Get(s_ariaDescribedBy);
        init => Set(ref s_ariaDescribedBy, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-describedby", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-describedby", s)));
    }

    private static PropDescriptor<string?>? s_ariaDescription;

    public IReadOnlySignal<string?>? AriaDescription
    {
        get => Get(s_ariaDescription);
        init => Set(ref s_ariaDescription, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-description", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-description", s)));
    }

    private static PropDescriptor<string?>? s_ariaDetails;

    public IReadOnlySignal<string?>? AriaDetails
    {
        get => Get(s_ariaDetails);
        init => Set(ref s_ariaDetails, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-details", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-details", s)));
    }

    private static PropDescriptor<bool>? s_ariaDisabled;

    public IReadOnlySignal<bool>? AriaDisabled
    {
        get => Get(s_ariaDisabled);
        init => Set(ref s_ariaDisabled, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaDisabled = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-disabled", s)));
    }

    private static PropDescriptor<string?>? s_ariaErrorMessage;

    public IReadOnlySignal<string?>? AriaErrorMessage
    {
        get => Get(s_ariaErrorMessage);
        init => Set(ref s_ariaErrorMessage, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-errormessage", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-errormessage", s)));
    }

    private static PropDescriptor<string?>? s_ariaExpanded;

    public IReadOnlySignal<string?>? AriaExpanded
    {
        get => Get(s_ariaExpanded);
        init => Set(ref s_ariaExpanded, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaExpanded = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-expanded", s)));
    }

    private static PropDescriptor<string?>? s_ariaFlowTo;

    public IReadOnlySignal<string?>? AriaFlowTo
    {
        get => Get(s_ariaFlowTo);
        init => Set(ref s_ariaFlowTo, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-flowto", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-flowto", s)));
    }

    private static PropDescriptor<string?>? s_ariaHasPopup;

    public IReadOnlySignal<string?>? AriaHasPopup
    {
        get => Get(s_ariaHasPopup);
        init => Set(ref s_ariaHasPopup, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaHasPopup = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-haspopup", s)));
    }

    private static PropDescriptor<bool>? s_ariaHidden;

    public IReadOnlySignal<bool>? AriaHidden
    {
        get => Get(s_ariaHidden);
        init => Set(ref s_ariaHidden, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaHidden = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-hidden", s)));
    }

    private static PropDescriptor<string?>? s_ariaInvalid;

    public IReadOnlySignal<string?>? AriaInvalid
    {
        get => Get(s_ariaInvalid);
        init => Set(ref s_ariaInvalid, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaInvalid = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-invalid", s)));
    }

    private static PropDescriptor<string?>? s_ariaKeyShortcuts;

    public IReadOnlySignal<string?>? AriaKeyShortcuts
    {
        get => Get(s_ariaKeyShortcuts);
        init => Set(ref s_ariaKeyShortcuts, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaKeyShortcuts = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-keyshortcuts", s)));
    }

    private static PropDescriptor<string?>? s_ariaLabel;

    public IReadOnlySignal<string?>? AriaLabel
    {
        get => Get(s_ariaLabel);
        init => Set(ref s_ariaLabel, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaLabel = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-label", s)));
    }

    private static PropDescriptor<string?>? s_ariaLabelledBy;

    public IReadOnlySignal<string?>? AriaLabelledBy
    {
        get => Get(s_ariaLabelledBy);
        init => Set(ref s_ariaLabelledBy, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-labelledby", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-labelledby", s)));
    }

    private static PropDescriptor<int>? s_ariaLevel;

    public IReadOnlySignal<int>? AriaLevel
    {
        get => Get(s_ariaLevel);
        init => Set(ref s_ariaLevel, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaLevel = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-level", s)));
    }

    private static PropDescriptor<string?>? s_ariaLive;

    public IReadOnlySignal<string?>? AriaLive
    {
        get => Get(s_ariaLive);
        init => Set(ref s_ariaLive, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaLive = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-live", s)));
    }

    private static PropDescriptor<bool>? s_ariaModal;

    public IReadOnlySignal<bool>? AriaModal
    {
        get => Get(s_ariaModal);
        init => Set(ref s_ariaModal, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaModal = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-modal", s)));
    }

    private static PropDescriptor<bool>? s_ariaMultiLine;

    public IReadOnlySignal<bool>? AriaMultiLine
    {
        get => Get(s_ariaMultiLine);
        init => Set(ref s_ariaMultiLine, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaMultiLine = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-multiline", s)));
    }

    private static PropDescriptor<bool>? s_ariaMultiSelectable;

    public IReadOnlySignal<bool>? AriaMultiSelectable
    {
        get => Get(s_ariaMultiSelectable);
        init => Set(ref s_ariaMultiSelectable, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaMultiSelectable = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-multiselectable", s)));
    }

    private static PropDescriptor<string?>? s_ariaOrientation;

    public IReadOnlySignal<string?>? AriaOrientation
    {
        get => Get(s_ariaOrientation);
        init => Set(ref s_ariaOrientation, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaOrientation = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-orientation", s)));
    }

    private static PropDescriptor<string?>? s_ariaOwns;

    public IReadOnlySignal<string?>? AriaOwns
    {
        get => Get(s_ariaOwns);
        init => Set(ref s_ariaOwns, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-owns", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-owns", s)));
    }

    private static PropDescriptor<string?>? s_ariaPlaceholder;

    public IReadOnlySignal<string?>? AriaPlaceholder
    {
        get => Get(s_ariaPlaceholder);
        init => Set(ref s_ariaPlaceholder, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaPlaceholder = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-placeholder", s)));
    }

    private static PropDescriptor<int>? s_ariaPosInSet;

    public IReadOnlySignal<int>? AriaPosInSet
    {
        get => Get(s_ariaPosInSet);
        init => Set(ref s_ariaPosInSet, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaPosInSet = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-posinset", s)));
    }

    private static PropDescriptor<string?>? s_ariaPressed;

    public IReadOnlySignal<string?>? AriaPressed
    {
        get => Get(s_ariaPressed);
        init => Set(ref s_ariaPressed, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaPressed = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-pressed", s)));
    }

    private static PropDescriptor<bool>? s_ariaReadOnly;

    public IReadOnlySignal<bool>? AriaReadOnly
    {
        get => Get(s_ariaReadOnly);
        init => Set(ref s_ariaReadOnly, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaReadOnly = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-readonly", s)));
    }

    private static PropDescriptor<string?>? s_ariaRelevant;

    public IReadOnlySignal<string?>? AriaRelevant
    {
        get => Get(s_ariaRelevant);
        init => Set(ref s_ariaRelevant, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-relevant", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-relevant", s)));
    }

    private static PropDescriptor<bool>? s_ariaRequired;

    public IReadOnlySignal<bool>? AriaRequired
    {
        get => Get(s_ariaRequired);
        init => Set(ref s_ariaRequired, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaRequired = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-required", s)));
    }

    private static PropDescriptor<string?>? s_ariaRoleDescription;

    public IReadOnlySignal<string?>? AriaRoleDescription
    {
        get => Get(s_ariaRoleDescription);
        init => Set(ref s_ariaRoleDescription, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaRoleDescription = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-roledescription", s)));
    }

    private static PropDescriptor<int>? s_ariaRowCount;

    public IReadOnlySignal<int>? AriaRowCount
    {
        get => Get(s_ariaRowCount);
        init => Set(ref s_ariaRowCount, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaRowCount = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-rowcount", s)));
    }

    private static PropDescriptor<int>? s_ariaRowIndex;

    public IReadOnlySignal<int>? AriaRowIndex
    {
        get => Get(s_ariaRowIndex);
        init => Set(ref s_ariaRowIndex, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaRowIndex = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-rowindex", s)));
    }

    private static PropDescriptor<string?>? s_ariaRowIndexText;

    public IReadOnlySignal<string?>? AriaRowIndexText
    {
        get => Get(s_ariaRowIndexText);
        init => Set(ref s_ariaRowIndexText, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) SetOrRemoveAttribute(el, "aria-rowindextext", s.Value);
            },
            static (el, s) => el.SetNullableString("aria-rowindextext", s)));
    }

    private static PropDescriptor<int>? s_ariaRowSpan;

    public IReadOnlySignal<int>? AriaRowSpan
    {
        get => Get(s_ariaRowSpan);
        init => Set(ref s_ariaRowSpan, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaRowSpan = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-rowspan", s)));
    }

    private static PropDescriptor<bool>? s_ariaSelected;

    public IReadOnlySignal<bool>? AriaSelected
    {
        get => Get(s_ariaSelected);
        init => Set(ref s_ariaSelected, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaSelected = s.Value ? "true" : "false";
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-selected", s)));
    }

    private static PropDescriptor<int>? s_ariaSetSize;

    public IReadOnlySignal<int>? AriaSetSize
    {
        get => Get(s_ariaSetSize);
        init => Set(ref s_ariaSetSize, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaSetSize = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetInt("aria-setsize", s)));
    }

    private static PropDescriptor<string?>? s_ariaSort;

    public IReadOnlySignal<string?>? AriaSort
    {
        get => Get(s_ariaSort);
        init => Set(ref s_ariaSort, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaSort = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-sort", s)));
    }

    private static PropDescriptor<double>? s_ariaValueMax;

    public IReadOnlySignal<double>? AriaValueMax
    {
        get => Get(s_ariaValueMax);
        init => Set(ref s_ariaValueMax, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaValueMax = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetDouble("aria-valuemax", s)));
    }

    private static PropDescriptor<double>? s_ariaValueMin;

    public IReadOnlySignal<double>? AriaValueMin
    {
        get => Get(s_ariaValueMin);
        init => Set(ref s_ariaValueMin, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaValueMin = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetDouble("aria-valuemin", s)));
    }

    private static PropDescriptor<double>? s_ariaValueNow;

    public IReadOnlySignal<double>? AriaValueNow
    {
        get => Get(s_ariaValueNow);
        init => Set(ref s_ariaValueNow, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaValueNow = s.Value.ToString(CultureInfo.InvariantCulture);
            },
            static (el, s) => el.SetDouble("aria-valuenow", s)));
    }

    private static PropDescriptor<string?>? s_ariaValueText;

    public IReadOnlySignal<string?>? AriaValueText
    {
        get => Get(s_ariaValueText);
        init => Set(ref s_ariaValueText, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AriaValueText = s.Value;
            },
            static (el, s) => el.SetNullableString("aria-valuetext", s)));
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
