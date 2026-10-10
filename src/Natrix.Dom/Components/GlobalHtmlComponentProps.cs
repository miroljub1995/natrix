using Natrix.Core.RenderRoot;
using Natrix.JSCore.Generics;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

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

    private static PropDescriptor<string>? s_accessKey;

    public IReadOnlySignal<string>? AccessKey
    {
        get => Get(s_accessKey);
        init => Set(ref s_accessKey, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.AccessKey = s.Value;
            },
            static (el, s) => el.SetAttribute("accesskey", s)));
    }

    private static PropDescriptor<string>? s_autocapitalize;

    public IReadOnlySignal<string>? Autocapitalize
    {
        get => Get(s_autocapitalize);
        init => Set(ref s_autocapitalize, value, static () => new(
            // Safari has no autocapitalize property, but iOS Safari honours the attribute.
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.SetAttribute("autocapitalize", s.Value);
            },
            static (el, s) => el.SetAttribute("autocapitalize", s)));
    }

    private static PropDescriptor<bool>? s_autocorrect;

    public IReadOnlySignal<bool>? Autocorrect
    {
        get => Get(s_autocorrect);
        init => Set(ref s_autocorrect, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Autocorrect = s.Value;
            },
            static (el, s) => el.SetEnumeratedBoolOnOff("autocorrect", s)));
    }

    private static PropDescriptor<bool>? s_autofocus;

    public IReadOnlySignal<bool>? Autofocus
    {
        get => Get(s_autofocus);
        init => Set(ref s_autofocus, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Autofocus = s.Value;
            },
            static (el, s) => el.SetBoolean("autofocus", s)));
    }

    private static PropDescriptor<string>? s_class;

    public IReadOnlySignal<string>? Class
    {
        get => Get(s_class);
        init => Set(ref s_class, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ClassList.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("class", s)));
    }

    private static PropDescriptor<string>? s_contentEditable;

    public IReadOnlySignal<string>? ContentEditable
    {
        get => Get(s_contentEditable);
        init => Set(ref s_contentEditable, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.ContentEditable = s.Value;
            },
            static (el, s) => el.SetAttribute("contenteditable", s)));
    }

    private static PropDescriptor<IDictionary<string, string>>? s_data;

    public IReadOnlySignal<IDictionary<string, string>>? Data
    {
        get => Get(s_data);
        init => Set(ref s_data, value, static () => new(
            static (el, s) =>
            {
                if (!OperatingSystem.IsBrowser())
                {
                    return;
                }

                var dict = s.Value;
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
            },
            static (el, s) => el.SetDataAttributes(s)));
    }

    private static PropDescriptor<string>? s_dir;

    public IReadOnlySignal<string>? Dir
    {
        get => Get(s_dir);
        init => Set(ref s_dir, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Dir = s.Value;
            },
            static (el, s) => el.SetAttribute("dir", s)));
    }

    private static PropDescriptor<bool>? s_draggable;

    public IReadOnlySignal<bool>? Draggable
    {
        get => Get(s_draggable);
        init => Set(ref s_draggable, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Draggable = s.Value;
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("draggable", s)));
    }

    private static PropDescriptor<string>? s_enterKeyHint;

    public IReadOnlySignal<string>? EnterKeyHint
    {
        get => Get(s_enterKeyHint);
        init => Set(ref s_enterKeyHint, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.EnterKeyHint = s.Value;
            },
            static (el, s) => el.SetAttribute("enterkeyhint", s)));
    }

    private static PropDescriptor<HiddenOption>? s_hidden;

    public IReadOnlySignal<HiddenOption>? Hidden
    {
        get => Get(s_hidden);
        init => Set(ref s_hidden, value, static () => new(
            static (el, s) =>
            {
                if (!OperatingSystem.IsBrowser())
                {
                    return;
                }

                el.Hidden = s.Value switch
                {
                    HiddenOption.True => true,
                    HiddenOption.False => false,
                    HiddenOption.UntilFound => "until-found",
                    _ => throw new ArgumentOutOfRangeException(nameof(Hidden), s.Value, null),
                };
            },
            static (el, s) => el.SetAttribute("hidden", s, s_hiddenSelector)));
    }

    private static PropDescriptor<string>? s_id;

    public IReadOnlySignal<string>? Id
    {
        get => Get(s_id);
        init => Set(ref s_id, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Id = s.Value;
            },
            static (el, s) => el.SetAttribute("id", s)));
    }

    private static PropDescriptor<bool>? s_inert;

    public IReadOnlySignal<bool>? Inert
    {
        get => Get(s_inert);
        init => Set(ref s_inert, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Inert = s.Value;
            },
            static (el, s) => el.SetBoolean("inert", s)));
    }

    private static PropDescriptor<string>? s_inputMode;

    public IReadOnlySignal<string>? InputMode
    {
        get => Get(s_inputMode);
        init => Set(ref s_inputMode, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.InputMode = s.Value;
            },
            static (el, s) => el.SetAttribute("inputmode", s)));
    }

    private static PropDescriptor<string>? s_lang;

    public IReadOnlySignal<string>? Lang
    {
        get => Get(s_lang);
        init => Set(ref s_lang, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Lang = s.Value;
            },
            static (el, s) => el.SetAttribute("lang", s)));
    }

    private static PropDescriptor<string>? s_nonce;

    public IReadOnlySignal<string>? Nonce
    {
        get => Get(s_nonce);
        init => Set(ref s_nonce, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Nonce = s.Value;
            },
            static (el, s) => el.SetAttribute("nonce", s)));
    }

    private static PropDescriptor<string>? s_part;

    public IReadOnlySignal<string>? Part
    {
        get => Get(s_part);
        init => Set(ref s_part, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Part.Value = s.Value;
            },
            static (el, s) => el.SetAttribute("part", s)));
    }

    private static PropDescriptor<string?>? s_popover;

    public IReadOnlySignal<string?>? Popover
    {
        get => Get(s_popover);
        init => Set(ref s_popover, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Popover = s.Value;
            },
            static (el, s) => el.SetNullableString("popover", s)));
    }

    private static PropDescriptor<string>? s_slot;

    public IReadOnlySignal<string>? Slot
    {
        get => Get(s_slot);
        init => Set(ref s_slot, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Slot = s.Value;
            },
            static (el, s) => el.SetAttribute("slot", s)));
    }

    private static PropDescriptor<bool>? s_spellcheck;

    public IReadOnlySignal<bool>? Spellcheck
    {
        get => Get(s_spellcheck);
        init => Set(ref s_spellcheck, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Spellcheck = s.Value;
            },
            static (el, s) => el.SetEnumeratedBoolTrueFalse("spellcheck", s)));
    }

    private static PropDescriptor<string>? s_style;

    public IReadOnlySignal<string>? Style
    {
        get => Get(s_style);
        init => Set(ref s_style, value, static () => new(
            // The generated binding types `style` as CSSStyleProperties, but Chrome still returns a
            // CSSStyleDeclaration, which the typed accessor refuses. Read it as its base type instead.
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser())
                {
                    ProxyAccessor<CSSStyleDeclaration>.Get(el.JSObject, "style").CssText = s.Value;
                }
            },
            static (el, s) => el.SetAttribute("style", s)));
    }

    private static PropDescriptor<int>? s_tabIndex;

    public IReadOnlySignal<int>? TabIndex
    {
        get => Get(s_tabIndex);
        init => Set(ref s_tabIndex, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.TabIndex = s.Value;
            },
            static (el, s) => el.SetInt("tabindex", s)));
    }

    private static PropDescriptor<string>? s_title;

    public IReadOnlySignal<string>? Title
    {
        get => Get(s_title);
        init => Set(ref s_title, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Title = s.Value;
            },
            static (el, s) => el.SetAttribute("title", s)));
    }

    private static PropDescriptor<bool>? s_translate;

    public IReadOnlySignal<bool>? Translate
    {
        get => Get(s_translate);
        init => Set(ref s_translate, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.Translate = s.Value;
            },
            static (el, s) => el.SetEnumeratedBoolYesNo("translate", s)));
    }

    private static PropDescriptor<string>? s_virtualKeyboardPolicy;

    public IReadOnlySignal<string>? VirtualKeyboardPolicy
    {
        get => Get(s_virtualKeyboardPolicy);
        init => Set(ref s_virtualKeyboardPolicy, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.VirtualKeyboardPolicy = s.Value;
            },
            static (el, s) => el.SetAttribute("virtualkeyboardpolicy", s)));
    }

    private static PropDescriptor<string>? s_writingSuggestions;

    public IReadOnlySignal<string>? WritingSuggestions
    {
        get => Get(s_writingSuggestions);
        init => Set(ref s_writingSuggestions, value, static () => new(
            static (el, s) =>
            {
                if (OperatingSystem.IsBrowser()) el.WritingSuggestions = s.Value;
            },
            static (el, s) => el.SetAttribute("writingsuggestions", s)));
    }
}