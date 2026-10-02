using System.Diagnostics.CodeAnalysis;
using Natrix.Core.RenderRoot;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Client effects are only created behind OperatingSystem.IsBrowser().")]
public class GlobalHtmlComponentProps<TElement> : GlobalElementComponentProps<TElement>
    where TElement : HTMLElement
{
    private static readonly Func<object, SsrAttributeValue?> s_hiddenSelector =
        static obj => ((IReadOnlySignal<HiddenOption>)obj).Value switch
        {
            HiddenOption.True => new SsrAttributeValue(null),
            HiddenOption.False => null,
            HiddenOption.UntilFound => new SsrAttributeValue("until-found"),
            _ => throw new ArgumentOutOfRangeException(),
        };

    private static readonly object s_accessKeyKey = new();

    public IReadOnlySignal<string>? AccessKey
    {
        get => Get<IReadOnlySignal<string>>(s_accessKeyKey);
        init => Set(
            s_accessKeyKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.AccessKey = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("accesskey", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_autocapitalizeKey = new();

    public IReadOnlySignal<string>? Autocapitalize
    {
        get => Get<IReadOnlySignal<string>>(s_autocapitalizeKey);
        init => Set(
            s_autocapitalizeKey,
            value,
            // Safari has no autocapitalize property, but iOS Safari honours the attribute.
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.SetAttribute("autocapitalize", ((IReadOnlySignal<string>)s).Value)
                : null,
            static (el, s) => el.SetAttribute("autocapitalize", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_autocorrectKey = new();

    public IReadOnlySignal<bool>? Autocorrect
    {
        get => Get<IReadOnlySignal<bool>>(s_autocorrectKey);
        init => Set(
            s_autocorrectKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Autocorrect = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetEnumeratedBoolOnOff("autocorrect", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_autofocusKey = new();

    public IReadOnlySignal<bool>? Autofocus
    {
        get => Get<IReadOnlySignal<bool>>(s_autofocusKey);
        init => Set(
            s_autofocusKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Autofocus = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("autofocus", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_classKey = new();

    public IReadOnlySignal<string>? Class
    {
        get => Get<IReadOnlySignal<string>>(s_classKey);
        init => Set(
            s_classKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ClassList.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("class", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_contentEditableKey = new();

    public IReadOnlySignal<string>? ContentEditable
    {
        get => Get<IReadOnlySignal<string>>(s_contentEditableKey);
        init => Set(
            s_contentEditableKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.ContentEditable = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("contenteditable", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_dataKey = new();

    public IReadOnlySignal<IDictionary<string, string>>? Data
    {
        get => Get<IReadOnlySignal<IDictionary<string, string>>>(s_dataKey);
        init => Set(
            s_dataKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) =>
                {
                    var dict = ((IReadOnlySignal<IDictionary<string, string>>)s).Value;
                    var nextAttrNames = new HashSet<string>(dict.Count);

                    foreach (var kvp in dict)
                    {
                        var attrName = "data-" + kvp.Key;
                        nextAttrNames.Add(attrName);
                        el.SetAttribute(attrName, kvp.Value);
                    }

                    var attrNames = (string[])el.GetAttributeNames();
                    foreach (var attr in attrNames)
                    {
                        if (attr.StartsWith("data-") && !nextAttrNames.Contains(attr))
                            el.RemoveAttribute(attr);
                    }
                }
                : null,
            static (el, s) => el.SetDataAttributes((IReadOnlySignal<IDictionary<string, string>>)s));
    }

    private static readonly object s_dirKey = new();

    public IReadOnlySignal<string>? Dir
    {
        get => Get<IReadOnlySignal<string>>(s_dirKey);
        init => Set(
            s_dirKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Dir = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("dir", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_draggableKey = new();

    public IReadOnlySignal<bool>? Draggable
    {
        get => Get<IReadOnlySignal<bool>>(s_draggableKey);
        init => Set(
            s_draggableKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Draggable = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("draggable", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_enterKeyHintKey = new();

    public IReadOnlySignal<string>? EnterKeyHint
    {
        get => Get<IReadOnlySignal<string>>(s_enterKeyHintKey);
        init => Set(
            s_enterKeyHintKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.EnterKeyHint = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("enterkeyhint", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_hiddenKey = new();

    public IReadOnlySignal<HiddenOption>? Hidden
    {
        get => Get<IReadOnlySignal<HiddenOption>>(s_hiddenKey);
        init => Set(
            s_hiddenKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Hidden = ((IReadOnlySignal<HiddenOption>)s).Value switch
                {
                    HiddenOption.True => true,
                    HiddenOption.False => false,
                    HiddenOption.UntilFound => "until-found",
                    _ => throw new ArgumentOutOfRangeException(nameof(Hidden), ((IReadOnlySignal<HiddenOption>)s).Value, null),
                }
                : null,
            static (el, s) => el.SetAttribute("hidden", (IReadOnlySignal<HiddenOption>)s, s_hiddenSelector));
    }

    private static readonly object s_idKey = new();

    public IReadOnlySignal<string>? Id
    {
        get => Get<IReadOnlySignal<string>>(s_idKey);
        init => Set(
            s_idKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Id = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("id", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_inertKey = new();

    public IReadOnlySignal<bool>? Inert
    {
        get => Get<IReadOnlySignal<bool>>(s_inertKey);
        init => Set(
            s_inertKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Inert = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetBoolean("inert", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_inputModeKey = new();

    public IReadOnlySignal<string>? InputMode
    {
        get => Get<IReadOnlySignal<string>>(s_inputModeKey);
        init => Set(
            s_inputModeKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.InputMode = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("inputmode", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_langKey = new();

    public IReadOnlySignal<string>? Lang
    {
        get => Get<IReadOnlySignal<string>>(s_langKey);
        init => Set(
            s_langKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Lang = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("lang", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_nonceKey = new();

    public IReadOnlySignal<string>? Nonce
    {
        get => Get<IReadOnlySignal<string>>(s_nonceKey);
        init => Set(
            s_nonceKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Nonce = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("nonce", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_partKey = new();

    public IReadOnlySignal<string>? Part
    {
        get => Get<IReadOnlySignal<string>>(s_partKey);
        init => Set(
            s_partKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Part.Value = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("part", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_popoverKey = new();

    public IReadOnlySignal<string?>? Popover
    {
        get => Get<IReadOnlySignal<string?>>(s_popoverKey);
        init => Set(
            s_popoverKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Popover = ((IReadOnlySignal<string?>)s).Value
                : null,
            static (el, s) => el.SetNullableString("popover", (IReadOnlySignal<string?>)s));
    }

    private static readonly object s_slotKey = new();

    public IReadOnlySignal<string>? Slot
    {
        get => Get<IReadOnlySignal<string>>(s_slotKey);
        init => Set(
            s_slotKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Slot = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("slot", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_spellcheckKey = new();

    public IReadOnlySignal<bool>? Spellcheck
    {
        get => Get<IReadOnlySignal<bool>>(s_spellcheckKey);
        init => Set(
            s_spellcheckKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Spellcheck = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetEnumeratedBoolTrueFalse("spellcheck", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_styleKey = new();

    public IReadOnlySignal<string>? Style
    {
        get => Get<IReadOnlySignal<string>>(s_styleKey);
        init => Set(
            s_styleKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Style.CssText = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("style", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_tabIndexKey = new();

    public IReadOnlySignal<int>? TabIndex
    {
        get => Get<IReadOnlySignal<int>>(s_tabIndexKey);
        init => Set(
            s_tabIndexKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.TabIndex = ((IReadOnlySignal<int>)s).Value
                : null,
            static (el, s) => el.SetInt("tabindex", (IReadOnlySignal<int>)s));
    }

    private static readonly object s_titleKey = new();

    public IReadOnlySignal<string>? Title
    {
        get => Get<IReadOnlySignal<string>>(s_titleKey);
        init => Set(
            s_titleKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Title = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("title", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_translateKey = new();

    public IReadOnlySignal<bool>? Translate
    {
        get => Get<IReadOnlySignal<bool>>(s_translateKey);
        init => Set(
            s_translateKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.Translate = ((IReadOnlySignal<bool>)s).Value
                : null,
            static (el, s) => el.SetEnumeratedBoolYesNo("translate", (IReadOnlySignal<bool>)s));
    }

    private static readonly object s_virtualKeyboardPolicyKey = new();

    public IReadOnlySignal<string>? VirtualKeyboardPolicy
    {
        get => Get<IReadOnlySignal<string>>(s_virtualKeyboardPolicyKey);
        init => Set(
            s_virtualKeyboardPolicyKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.VirtualKeyboardPolicy = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("virtualkeyboardpolicy", (IReadOnlySignal<string>)s));
    }

    private static readonly object s_writingSuggestionsKey = new();

    public IReadOnlySignal<string>? WritingSuggestions
    {
        get => Get<IReadOnlySignal<string>>(s_writingSuggestionsKey);
        init => Set(
            s_writingSuggestionsKey,
            value,
            OperatingSystem.IsBrowser()
                ? static (el, s) => el.WritingSuggestions = ((IReadOnlySignal<string>)s).Value
                : null,
            static (el, s) => el.SetAttribute("writingsuggestions", (IReadOnlySignal<string>)s));
    }
}