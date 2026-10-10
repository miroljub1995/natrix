using Natrix.Core.Features.Routing;
using Natrix.Signals;

namespace Natrix.Browser.Tests.TestUtils;

public sealed class FakeNavigationFeature : INavigationFeature
{
    private readonly Signal<string> _currentPath;

    public FakeNavigationFeature(string initialPath)
    {
        _currentPath = new Signal<string>(initialPath);
        History = [initialPath];
    }

    /// <summary>The paths navigated through, oldest first, as the browser's history would hold them.</summary>
    public List<string> History { get; }

    public IReadOnlySignal<string> CurrentPath => _currentPath;

    // History is written before the signal, as ClientNavigationFeature writes the browser's: setting
    // the signal re-renders synchronously, and a redirect route replaces the entry while it does.
    public Task PushAsync(string path)
    {
        History.Add(path);
        _currentPath.Value = path;
        return Task.CompletedTask;
    }

    public Task ReplaceAsync(string path)
    {
        History[^1] = path;
        _currentPath.Value = path;
        return Task.CompletedTask;
    }
}
