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
    private static readonly object s_roleKey = new();

    public IReadOnlySignal<string?>? Role
    {
        get => Get<IReadOnlySignal<string?>>(s_roleKey);
        init => Set(
            s_roleKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Role = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("role", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaActiveDescendantKey = new();

    public IReadOnlySignal<string?>? AriaActiveDescendant
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaActiveDescendantKey);
        init => Set(
            s_ariaActiveDescendantKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-activedescendant", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-activedescendant", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaAtomicKey = new();

    public IReadOnlySignal<bool>? AriaAtomic
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaAtomicKey);
        init => Set(
            s_ariaAtomicKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaAtomic = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-atomic", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaAutoCompleteKey = new();

    public IReadOnlySignal<string?>? AriaAutoComplete
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaAutoCompleteKey);
        init => Set(
            s_ariaAutoCompleteKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaAutoComplete = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-autocomplete", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaBrailleLabelKey = new();

    public IReadOnlySignal<string?>? AriaBrailleLabel
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaBrailleLabelKey);
        init => Set(
            s_ariaBrailleLabelKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-braillelabel", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-braillelabel", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaBrailleRoleDescriptionKey = new();

    public IReadOnlySignal<string?>? AriaBrailleRoleDescription
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaBrailleRoleDescriptionKey);
        init => Set(
            s_ariaBrailleRoleDescriptionKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-brailleroledescription", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-brailleroledescription", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaBusyKey = new();

    public IReadOnlySignal<bool>? AriaBusy
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaBusyKey);
        init => Set(
            s_ariaBusyKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaBusy = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-busy", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaCheckedKey = new();

    public IReadOnlySignal<string?>? AriaChecked
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaCheckedKey);
        init => Set(
            s_ariaCheckedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaChecked = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-checked", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaColCountKey = new();

    public IReadOnlySignal<int>? AriaColCount
    {
        get => Get<IReadOnlySignal<int>>(s_ariaColCountKey);
        init => Set(
            s_ariaColCountKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaColCount = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-colcount", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaColIndexKey = new();

    public IReadOnlySignal<int>? AriaColIndex
    {
        get => Get<IReadOnlySignal<int>>(s_ariaColIndexKey);
        init => Set(
            s_ariaColIndexKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaColIndex = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-colindex", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaColIndexTextKey = new();

    public IReadOnlySignal<string?>? AriaColIndexText
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaColIndexTextKey);
        init => Set(
            s_ariaColIndexTextKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-colindextext", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-colindextext", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaColSpanKey = new();

    public IReadOnlySignal<int>? AriaColSpan
    {
        get => Get<IReadOnlySignal<int>>(s_ariaColSpanKey);
        init => Set(
            s_ariaColSpanKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaColSpan = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-colspan", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaControlsKey = new();

    public IReadOnlySignal<string?>? AriaControls
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaControlsKey);
        init => Set(
            s_ariaControlsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-controls", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-controls", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaCurrentKey = new();

    public IReadOnlySignal<string?>? AriaCurrent
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaCurrentKey);
        init => Set(
            s_ariaCurrentKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaCurrent = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-current", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaDescribedByKey = new();

    public IReadOnlySignal<string?>? AriaDescribedBy
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaDescribedByKey);
        init => Set(
            s_ariaDescribedByKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-describedby", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-describedby", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaDescriptionKey = new();

    public IReadOnlySignal<string?>? AriaDescription
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaDescriptionKey);
        init => Set(
            s_ariaDescriptionKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-description", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-description", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaDetailsKey = new();

    public IReadOnlySignal<string?>? AriaDetails
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaDetailsKey);
        init => Set(
            s_ariaDetailsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-details", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-details", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaDisabledKey = new();

    public IReadOnlySignal<bool>? AriaDisabled
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaDisabledKey);
        init => Set(
            s_ariaDisabledKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaDisabled = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-disabled", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaErrorMessageKey = new();

    public IReadOnlySignal<string?>? AriaErrorMessage
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaErrorMessageKey);
        init => Set(
            s_ariaErrorMessageKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-errormessage", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-errormessage", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaExpandedKey = new();

    public IReadOnlySignal<string?>? AriaExpanded
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaExpandedKey);
        init => Set(
            s_ariaExpandedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaExpanded = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-expanded", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaFlowToKey = new();

    public IReadOnlySignal<string?>? AriaFlowTo
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaFlowToKey);
        init => Set(
            s_ariaFlowToKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-flowto", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-flowto", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaHasPopupKey = new();

    public IReadOnlySignal<string?>? AriaHasPopup
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaHasPopupKey);
        init => Set(
            s_ariaHasPopupKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaHasPopup = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-haspopup", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaHiddenKey = new();

    public IReadOnlySignal<bool>? AriaHidden
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaHiddenKey);
        init => Set(
            s_ariaHiddenKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaHidden = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-hidden", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaInvalidKey = new();

    public IReadOnlySignal<string?>? AriaInvalid
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaInvalidKey);
        init => Set(
            s_ariaInvalidKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaInvalid = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-invalid", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaKeyShortcutsKey = new();

    public IReadOnlySignal<string?>? AriaKeyShortcuts
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaKeyShortcutsKey);
        init => Set(
            s_ariaKeyShortcutsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaKeyShortcuts = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-keyshortcuts", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaLabelKey = new();

    public IReadOnlySignal<string?>? AriaLabel
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaLabelKey);
        init => Set(
            s_ariaLabelKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaLabel = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-label", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaLabelledByKey = new();

    public IReadOnlySignal<string?>? AriaLabelledBy
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaLabelledByKey);
        init => Set(
            s_ariaLabelledByKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-labelledby", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-labelledby", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaLevelKey = new();

    public IReadOnlySignal<int>? AriaLevel
    {
        get => Get<IReadOnlySignal<int>>(s_ariaLevelKey);
        init => Set(
            s_ariaLevelKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaLevel = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-level", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaLiveKey = new();

    public IReadOnlySignal<string?>? AriaLive
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaLiveKey);
        init => Set(
            s_ariaLiveKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaLive = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-live", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaModalKey = new();

    public IReadOnlySignal<bool>? AriaModal
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaModalKey);
        init => Set(
            s_ariaModalKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaModal = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-modal", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaMultiLineKey = new();

    public IReadOnlySignal<bool>? AriaMultiLine
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaMultiLineKey);
        init => Set(
            s_ariaMultiLineKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaMultiLine = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-multiline", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaMultiSelectableKey = new();

    public IReadOnlySignal<bool>? AriaMultiSelectable
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaMultiSelectableKey);
        init => Set(
            s_ariaMultiSelectableKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaMultiSelectable = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-multiselectable", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaOrientationKey = new();

    public IReadOnlySignal<string?>? AriaOrientation
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaOrientationKey);
        init => Set(
            s_ariaOrientationKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaOrientation = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-orientation", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaOwnsKey = new();

    public IReadOnlySignal<string?>? AriaOwns
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaOwnsKey);
        init => Set(
            s_ariaOwnsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-owns", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-owns", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaPlaceholderKey = new();

    public IReadOnlySignal<string?>? AriaPlaceholder
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaPlaceholderKey);
        init => Set(
            s_ariaPlaceholderKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaPlaceholder = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-placeholder", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaPosInSetKey = new();

    public IReadOnlySignal<int>? AriaPosInSet
    {
        get => Get<IReadOnlySignal<int>>(s_ariaPosInSetKey);
        init => Set(
            s_ariaPosInSetKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaPosInSet = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-posinset", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaPressedKey = new();

    public IReadOnlySignal<string?>? AriaPressed
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaPressedKey);
        init => Set(
            s_ariaPressedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaPressed = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-pressed", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaReadOnlyKey = new();

    public IReadOnlySignal<bool>? AriaReadOnly
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaReadOnlyKey);
        init => Set(
            s_ariaReadOnlyKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaReadOnly = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-readonly", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaRelevantKey = new();

    public IReadOnlySignal<string?>? AriaRelevant
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaRelevantKey);
        init => Set(
            s_ariaRelevantKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-relevant", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-relevant", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaRequiredKey = new();

    public IReadOnlySignal<bool>? AriaRequired
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaRequiredKey);
        init => Set(
            s_ariaRequiredKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaRequired = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-required", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaRoleDescriptionKey = new();

    public IReadOnlySignal<string?>? AriaRoleDescription
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaRoleDescriptionKey);
        init => Set(
            s_ariaRoleDescriptionKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaRoleDescription = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-roledescription", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaRowCountKey = new();

    public IReadOnlySignal<int>? AriaRowCount
    {
        get => Get<IReadOnlySignal<int>>(s_ariaRowCountKey);
        init => Set(
            s_ariaRowCountKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaRowCount = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-rowcount", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaRowIndexKey = new();

    public IReadOnlySignal<int>? AriaRowIndex
    {
        get => Get<IReadOnlySignal<int>>(s_ariaRowIndexKey);
        init => Set(
            s_ariaRowIndexKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaRowIndex = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-rowindex", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaRowIndexTextKey = new();

    public IReadOnlySignal<string?>? AriaRowIndexText
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaRowIndexTextKey);
        init => Set(
            s_ariaRowIndexTextKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => SetOrRemoveAttribute(el, "aria-rowindextext", ((IReadOnlySignal<string?>)s).Value)
                : null,
            static (el, s) => el.SetNullableString("aria-rowindextext", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaRowSpanKey = new();

    public IReadOnlySignal<int>? AriaRowSpan
    {
        get => Get<IReadOnlySignal<int>>(s_ariaRowSpanKey);
        init => Set(
            s_ariaRowSpanKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaRowSpan = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-rowspan", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaSelectedKey = new();

    public IReadOnlySignal<bool>? AriaSelected
    {
        get => Get<IReadOnlySignal<bool>>(s_ariaSelectedKey);
        init => Set(
            s_ariaSelectedKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaSelected = ((IReadOnlySignal<bool>)s).Value ? "true" : "false"
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("aria-selected", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_ariaSetSizeKey = new();

    public IReadOnlySignal<int>? AriaSetSize
    {
        get => Get<IReadOnlySignal<int>>(s_ariaSetSizeKey);
        init => Set(
            s_ariaSetSizeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaSetSize = ((IReadOnlySignal<int>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetInt("aria-setsize", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_ariaSortKey = new();

    public IReadOnlySignal<string?>? AriaSort
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaSortKey);
        init => Set(
            s_ariaSortKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaSort = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-sort", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_ariaValueMaxKey = new();

    public IReadOnlySignal<double>? AriaValueMax
    {
        get => Get<IReadOnlySignal<double>>(s_ariaValueMaxKey);
        init => Set(
            s_ariaValueMaxKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaValueMax = ((IReadOnlySignal<double>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetDouble("aria-valuemax", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_ariaValueMinKey = new();

    public IReadOnlySignal<double>? AriaValueMin
    {
        get => Get<IReadOnlySignal<double>>(s_ariaValueMinKey);
        init => Set(
            s_ariaValueMinKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaValueMin = ((IReadOnlySignal<double>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetDouble("aria-valuemin", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_ariaValueNowKey = new();

    public IReadOnlySignal<double>? AriaValueNow
    {
        get => Get<IReadOnlySignal<double>>(s_ariaValueNowKey);
        init => Set(
            s_ariaValueNowKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaValueNow = ((IReadOnlySignal<double>)s).Value.ToString(CultureInfo.InvariantCulture)
                : null,
            static (el, s) => el.SetDouble("aria-valuenow", (IReadOnlySignal<double>)s));
    }

    private static readonly object s_ariaValueTextKey = new();

    public IReadOnlySignal<string?>? AriaValueText
    {
        get => Get<IReadOnlySignal<string?>>(s_ariaValueTextKey);
        init => Set(
            s_ariaValueTextKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AriaValueText = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("aria-valuetext", (IReadOnlySignal<string?>)s));
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
