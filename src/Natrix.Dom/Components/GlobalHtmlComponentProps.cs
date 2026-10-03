using Natrix.Core.RenderRoot;
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

    private static readonly PropDescriptor<string> s_accessKey = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.AccessKey = s.Value;
        },
        static (el, s) => el.SetAttribute("accesskey", s));

    public IReadOnlySignal<string>? AccessKey
    {
        get => Get(s_accessKey);
        init => Set(s_accessKey, value);
    }

    private static readonly PropDescriptor<string> s_autocapitalize = new(
        // Safari has no autocapitalize property, but iOS Safari honours the attribute.
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.SetAttribute("autocapitalize", s.Value);
        },
        static (el, s) => el.SetAttribute("autocapitalize", s));

    public IReadOnlySignal<string>? Autocapitalize
    {
        get => Get(s_autocapitalize);
        init => Set(s_autocapitalize, value);
    }

    private static readonly PropDescriptor<bool> s_autocorrect = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Autocorrect = s.Value;
        },
        static (el, s) => el.SetEnumeratedBoolOnOff("autocorrect", s));

    public IReadOnlySignal<bool>? Autocorrect
    {
        get => Get(s_autocorrect);
        init => Set(s_autocorrect, value);
    }

    private static readonly PropDescriptor<bool> s_autofocus = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Autofocus = s.Value;
        },
        static (el, s) => el.SetBoolean("autofocus", s));

    public IReadOnlySignal<bool>? Autofocus
    {
        get => Get(s_autofocus);
        init => Set(s_autofocus, value);
    }

    private static readonly PropDescriptor<string> s_class = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.ClassList.Value = s.Value;
        },
        static (el, s) => el.SetAttribute("class", s));

    public IReadOnlySignal<string>? Class
    {
        get => Get(s_class);
        init => Set(s_class, value);
    }

    private static readonly PropDescriptor<string> s_contentEditable = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.ContentEditable = s.Value;
        },
        static (el, s) => el.SetAttribute("contenteditable", s));

    public IReadOnlySignal<string>? ContentEditable
    {
        get => Get(s_contentEditable);
        init => Set(s_contentEditable, value);
    }

    private static readonly PropDescriptor<IDictionary<string, string>> s_data = new(
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
        static (el, s) => el.SetDataAttributes(s));

    public IReadOnlySignal<IDictionary<string, string>>? Data
    {
        get => Get(s_data);
        init => Set(s_data, value);
    }

    private static readonly PropDescriptor<string> s_dir = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Dir = s.Value;
        },
        static (el, s) => el.SetAttribute("dir", s));

    public IReadOnlySignal<string>? Dir
    {
        get => Get(s_dir);
        init => Set(s_dir, value);
    }

    private static readonly PropDescriptor<bool> s_draggable = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Draggable = s.Value;
        },
        static (el, s) => el.SetEnumeratedBoolTrueFalse("draggable", s));

    public IReadOnlySignal<bool>? Draggable
    {
        get => Get(s_draggable);
        init => Set(s_draggable, value);
    }

    private static readonly PropDescriptor<string> s_enterKeyHint = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.EnterKeyHint = s.Value;
        },
        static (el, s) => el.SetAttribute("enterkeyhint", s));

    public IReadOnlySignal<string>? EnterKeyHint
    {
        get => Get(s_enterKeyHint);
        init => Set(s_enterKeyHint, value);
    }

    private static readonly PropDescriptor<HiddenOption> s_hidden = new(
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
        static (el, s) => el.SetAttribute("hidden", s, s_hiddenSelector));

    public IReadOnlySignal<HiddenOption>? Hidden
    {
        get => Get(s_hidden);
        init => Set(s_hidden, value);
    }

    private static readonly PropDescriptor<string> s_id = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Id = s.Value;
        },
        static (el, s) => el.SetAttribute("id", s));

    public IReadOnlySignal<string>? Id
    {
        get => Get(s_id);
        init => Set(s_id, value);
    }

    private static readonly PropDescriptor<bool> s_inert = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Inert = s.Value;
        },
        static (el, s) => el.SetBoolean("inert", s));

    public IReadOnlySignal<bool>? Inert
    {
        get => Get(s_inert);
        init => Set(s_inert, value);
    }

    private static readonly PropDescriptor<string> s_inputMode = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.InputMode = s.Value;
        },
        static (el, s) => el.SetAttribute("inputmode", s));

    public IReadOnlySignal<string>? InputMode
    {
        get => Get(s_inputMode);
        init => Set(s_inputMode, value);
    }

    private static readonly PropDescriptor<string> s_lang = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Lang = s.Value;
        },
        static (el, s) => el.SetAttribute("lang", s));

    public IReadOnlySignal<string>? Lang
    {
        get => Get(s_lang);
        init => Set(s_lang, value);
    }

    private static readonly PropDescriptor<string> s_nonce = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Nonce = s.Value;
        },
        static (el, s) => el.SetAttribute("nonce", s));

    public IReadOnlySignal<string>? Nonce
    {
        get => Get(s_nonce);
        init => Set(s_nonce, value);
    }

    private static readonly PropDescriptor<string> s_part = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Part.Value = s.Value;
        },
        static (el, s) => el.SetAttribute("part", s));

    public IReadOnlySignal<string>? Part
    {
        get => Get(s_part);
        init => Set(s_part, value);
    }

    private static readonly PropDescriptor<string?> s_popover = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Popover = s.Value;
        },
        static (el, s) => el.SetNullableString("popover", s));

    public IReadOnlySignal<string?>? Popover
    {
        get => Get(s_popover);
        init => Set(s_popover, value);
    }

    private static readonly PropDescriptor<string> s_slot = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Slot = s.Value;
        },
        static (el, s) => el.SetAttribute("slot", s));

    public IReadOnlySignal<string>? Slot
    {
        get => Get(s_slot);
        init => Set(s_slot, value);
    }

    private static readonly PropDescriptor<bool> s_spellcheck = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Spellcheck = s.Value;
        },
        static (el, s) => el.SetEnumeratedBoolTrueFalse("spellcheck", s));

    public IReadOnlySignal<bool>? Spellcheck
    {
        get => Get(s_spellcheck);
        init => Set(s_spellcheck, value);
    }

    private static readonly PropDescriptor<string> s_style = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Style.CssText = s.Value;
        },
        static (el, s) => el.SetAttribute("style", s));

    public IReadOnlySignal<string>? Style
    {
        get => Get(s_style);
        init => Set(s_style, value);
    }

    private static readonly PropDescriptor<int> s_tabIndex = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.TabIndex = s.Value;
        },
        static (el, s) => el.SetInt("tabindex", s));

    public IReadOnlySignal<int>? TabIndex
    {
        get => Get(s_tabIndex);
        init => Set(s_tabIndex, value);
    }

    private static readonly PropDescriptor<string> s_title = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Title = s.Value;
        },
        static (el, s) => el.SetAttribute("title", s));

    public IReadOnlySignal<string>? Title
    {
        get => Get(s_title);
        init => Set(s_title, value);
    }

    private static readonly PropDescriptor<bool> s_translate = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.Translate = s.Value;
        },
        static (el, s) => el.SetEnumeratedBoolYesNo("translate", s));

    public IReadOnlySignal<bool>? Translate
    {
        get => Get(s_translate);
        init => Set(s_translate, value);
    }

    private static readonly PropDescriptor<string> s_virtualKeyboardPolicy = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.VirtualKeyboardPolicy = s.Value;
        },
        static (el, s) => el.SetAttribute("virtualkeyboardpolicy", s));

    public IReadOnlySignal<string>? VirtualKeyboardPolicy
    {
        get => Get(s_virtualKeyboardPolicy);
        init => Set(s_virtualKeyboardPolicy, value);
    }

    private static readonly PropDescriptor<string> s_writingSuggestions = new(
        static (el, s) =>
        {
            if (OperatingSystem.IsBrowser()) el.WritingSuggestions = s.Value;
        },
        static (el, s) => el.SetAttribute("writingsuggestions", s));

    public IReadOnlySignal<string>? WritingSuggestions
    {
        get => Get(s_writingSuggestions);
        init => Set(s_writingSuggestions, value);
    }
}