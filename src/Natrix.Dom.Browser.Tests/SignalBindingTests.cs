using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Browser.Tests;

/// <summary>
/// <see cref="SignalBindingExtensions"/> on a select, round-tripping through <see cref="SelectProps"/>.
/// </summary>
public class SignalBindingTests
{
    [Test]
    public async Task Binds_selected_values_of_a_multiple_select()
    {
        var values = new Signal<IReadOnlyList<string>>(["a"]);
        var (container, host) = Mount(new SelectProps { Multiple = new Signal<bool>(true), Values = values }, values.ToDomEvent());
        using var _ = host;

        var select = Select(container);
        Option(select, 1).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(string.Join(",", values.Value)).IsEqualTo("a,b");
    }

    [Test]
    public async Task Restores_selected_values_the_signal_rejects()
    {
        var values = new Signal<IReadOnlyList<string>>(["a"], new RejectAll<IReadOnlyList<string>>());
        var (container, host) = Mount(new SelectProps { Multiple = new Signal<bool>(true), Values = values }, values.ToDomEvent());
        using var _ = host;

        var select = Select(container);
        Option(select, 0).Selected = false;
        Option(select, 2).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(SelectedValues(select)).IsEqualTo("a");
    }

    [Test]
    public async Task Binds_value_of_a_single_select()
    {
        var value = new Signal<string>("a");
        var (container, host) = Mount(new SelectProps { Value = value }, value.ToDomEvent());
        using var _ = host;

        var select = Select(container);
        Option(select, 2).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(value.Value).IsEqualTo("c");
    }

    [Test]
    public async Task Restores_value_the_signal_rejects()
    {
        var value = new Signal<string>("b", new RejectAll<string>());
        var (container, host) = Mount(new SelectProps { Value = value }, value.ToDomEvent());
        using var _ = host;

        var select = Select(container);
        Option(select, 2).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(SelectedValues(select)).IsEqualTo("b");
    }

    [Test]
    public async Task Resets_to_first_enabled_option_when_value_matches_none()
    {
        var value = new Signal<string>("z", new RejectAll<string>());
        var (container, host) = Mount(new SelectProps { Value = value }, value.ToDomEvent());
        using var _ = host;

        var select = Select(container);
        Option(select, 2).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(SelectedValues(select)).IsEqualTo("a");
    }

    [Test]
    public async Task Keeps_other_selections_when_a_multiple_select_is_bound_to_a_string()
    {
        var value = new Signal<string>("");
        var (container, host) = Mount(new SelectProps { Multiple = new Signal<bool>(true) }, value.ToDomEvent());
        using var _ = host;

        var select = Select(container);
        Option(select, 0).Selected = true;
        Option(select, 2).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(value.Value).IsEqualTo("a");
        await Assert.That(SelectedValues(select)).IsEqualTo("a,c");
    }

    [Test]
    public async Task Round_trips_options_without_a_value_through_their_text()
    {
        var value = new Signal<string>("Green");
        var (container, host) = DomRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Value = value },
            Events = new SelectEvents { OnChange = value.ToDomEvent() },
            Children = [TextOption("Red"), TextOption("Green"), TextOption("Blue")],
        });
        using var _ = host;

        var select = Select(container);
        await Assert.That(select.Value).IsEqualTo("Green");

        Option(select, 2).Selected = true;
        select.DispatchEvent(Event.New("change"));

        await Assert.That(value.Value).IsEqualTo("Blue");
        await Assert.That(select.Value).IsEqualTo("Blue");
    }

    private static (Element Container, IDisposable Host) Mount(SelectProps props, Action<Event>? onChange) =>
        DomRenderer.Mount(() => new Select
        {
            Props = props,
            Events = new SelectEvents { OnChange = onChange },
            Children = [ValueOption("a"), ValueOption("b"), ValueOption("c")],
        });

    private static HTMLSelectElement Select(Element container) =>
        JSObjectProxyFactory.GetProxy<HTMLSelectElement>(container.FirstElementChild!.JSObject);

    private static HTMLOptionElement Option(HTMLSelectElement select, uint index) =>
        (HTMLOptionElement)select.Options.Item(index)!;

    private static string SelectedValues(HTMLSelectElement select)
    {
        var selected = select.SelectedOptions;
        var values = new string[selected.Length];
        for (uint i = 0; i < selected.Length; i++)
        {
            values[i] = ((HTMLOptionElement)selected.Item(i)!).Value;
        }

        return string.Join(",", values);
    }

    private static Option ValueOption(string value) => new()
    {
        Props = new OptionProps { Value = new Signal<string>(value) },
        Children = [Text(value)],
    };

    private static Option TextOption(string text) => new() { Children = [Text(text)] };

    private static DomText Text(string text) => new() { Text = new Signal<string>(text) };

    /// <summary>Treats every value as equal to the current one, so assigning never changes the signal.</summary>
    private sealed class RejectAll<T> : IEqualityComparer<T>
    {
        public bool Equals(T? x, T? y) => true;

        public int GetHashCode(T obj) => 0;
    }
}
