using System.Runtime.InteropServices.JavaScript;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Dom.Browser.Tests;

/// <summary>
/// Handlers receiving the events the browser fires itself, whose type is not always the most
/// specific one an event name suggests.
/// </summary>
public class EventTests
{
    [Test]
    public async Task Runs_input_handler_for_a_checkbox()
    {
        string? received = null;
        var (container, host) = DomRenderer.Mount(() => new Input
        {
            Props = new InputProps { Type = new Signal<string>("checkbox") },
            Events = new InputEvents { OnInput = ev => received = ev.GetType().Name },
        });
        using var _ = host;
        // Disconnected inputs fire no input event.
        using var attached = Attach(container);

        ((HTMLInputElement)container.FirstElementChild!).Click();

        await Assert.That(received).IsEqualTo(nameof(Event));
    }

    [Test]
    public async Task Passes_an_input_event_to_the_input_handler_when_text_is_typed()
    {
        string? received = null;
        var (container, host) = DomRenderer.Mount(() => new Input
        {
            Events = new InputEvents { OnInput = ev => received = ev.GetType().Name },
        });
        using var _ = host;
        using var attached = Attach(container);

        ((HTMLInputElement)container.FirstElementChild!).Focus();
        Document.ExecCommand("insertText", false, "x");

        await Assert.That(received).IsEqualTo(nameof(InputEvent));
    }

    [Test]
    public async Task Binds_a_select_through_its_input_event()
    {
        var value = new Signal<string>("a");
        var (container, host) = DomRenderer.Mount(() => new Select
        {
            Props = new SelectProps { Value = value },
            Events = new SelectEvents { OnInput = value.ToDomEvent() },
            Children = [Option("a"), Option("b")],
        });
        using var _ = host;

        var select = (HTMLSelectElement)container.FirstElementChild!;
        ((HTMLOptionElement)select.Options.Item(1)!).Selected = true;
        select.DispatchEvent(Event.New("input"));

        await Assert.That(value.Value).IsEqualTo("b");
    }

    [Test]
    public async Task Runs_error_handler_for_an_image_that_fails_to_load()
    {
        var failed = new TaskCompletionSource<string>();
        var (_, host) = DomRenderer.Mount(() => new Img
        {
            Props = new ImgProps { Src = new Signal<string>("data:image/png;base64,AAAA") },
            Events = new ImgEvents { OnError = ev => failed.TrySetResult(ev.GetType().Name) },
        });
        using var _ = host;

        await Assert.That(await failed.Task.WaitAsync(TimeSpan.FromSeconds(5))).IsEqualTo(nameof(Event));
    }

    private static Document Document => JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis).Document;

    /// <summary>
    /// Connects the container to the page, for what needs focus or a connected element; disconnects it
    /// on dispose.
    /// </summary>
    private static IDisposable Attach(Element container)
    {
        Document.Body!.AppendChild(container);
        return new Detach(container);
    }

    private sealed class Detach(Element container) : IDisposable
    {
        public void Dispose() => container.Remove();
    }

    private static Option Option(string value) => new()
    {
        Props = new OptionProps { Value = new Signal<string>(value) },
        Children = [new DomText { Text = new Signal<string>(value) }],
    };
}
