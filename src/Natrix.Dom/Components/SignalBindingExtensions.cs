using System.Runtime.Versioning;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Components;

public static class SignalBindingExtensions
{
    public static Action<InputEvent>? ToDomInputEvent(this ISignal<string> signal, bool reset = true)
    {
        if (!OperatingSystem.IsBrowser())
        {
            return null;
        }

        return CreateInputEventHandler(signal, reset);
    }

    public static Action<Event>? ToDomEvent(this ISignal<string> signal, bool reset = true)
    {
        if (!OperatingSystem.IsBrowser())
        {
            return null;
        }

        return CreateEventHandler(signal, reset);
    }

    /// <summary>
    /// Binds the selected values of a <see cref="Multiple"/> select to <paramref name="signal"/>, for
    /// <c>OnChange</c>. Each change assigns a new list.
    /// </summary>
    /// <param name="reset">Re-applies the signal's value to the options afterwards, so a value the
    /// signal rejects does not stay selected.</param>
    public static Action<Event>? ToDomEvent(this ISignal<IReadOnlyList<string>> signal, bool reset = true)
    {
        if (!OperatingSystem.IsBrowser())
        {
            return null;
        }

        return CreateSelectedValuesHandler(signal, reset);
    }

    [SupportedOSPlatform("browser")]
    private static Action<Event> CreateSelectedValuesHandler(ISignal<IReadOnlyList<string>> signal, bool reset)
    {
        return ev =>
        {
            if (ev.Target is not HTMLSelectElement select)
            {
                return;
            }

            var selected = select.SelectedOptions;
            var values = new string[selected.Length];
            for (uint i = 0; i < selected.Length; i++)
            {
                values[i] = ((HTMLOptionElement)selected.Item(i)!).Value;
            }

            signal.Value = values;

            if (reset)
            {
                SelectProps.SelectOptions(select, signal.Value);
            }
        };
    }

    [SupportedOSPlatform("browser")]
    private static Action<InputEvent> CreateInputEventHandler(ISignal<string> signal, bool reset)
    {
        return ev =>
        {
            var target = ev.Target;

            if (target is null)
            {
                return;
            }

            BindValue(target, signal, reset);
        };
    }

    [SupportedOSPlatform("browser")]
    private static Action<Event> CreateEventHandler(ISignal<string> signal, bool reset)
    {
        return ev =>
        {
            var target = ev.Target;

            if (target is null)
            {
                return;
            }

            BindValue(target, signal, reset);
        };
    }

    [SupportedOSPlatform("browser")]
    private static void BindValue(EventTarget target, ISignal<string> signal, bool reset)
    {
        if (target is HTMLInputElement input)
        {
            signal.Value = input.Value;

            if (reset)
            {
                input.Value = signal.Value;
            }
        }
        else if (target is HTMLTextAreaElement textArea)
        {
            signal.Value = textArea.Value;

            if (reset)
            {
                textArea.Value = signal.Value;
            }
        }
        else if (target is HTMLSelectElement select)
        {
            // The first selected option; bind a multiple select to a list instead.
            signal.Value = select.Value;

            // Assigning select.value would deselect every other option of a multiple select, and leave
            // none selected when nothing matches, so reset the way SelectProps.Value applies.
            if (reset && !select.Multiple)
            {
                SelectProps.SelectOption(select, signal.Value);
            }
        }
    }
}
