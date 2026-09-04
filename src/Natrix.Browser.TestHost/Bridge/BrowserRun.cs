using System.Runtime.Versioning;
using System.Text.Json;
using System.Threading.Channels;
using Natrix.Browser.TestHost.Protocol;
using PuppeteerSharp;

namespace Natrix.Browser.TestHost.Bridge;

[UnsupportedOSPlatform("browser")]
internal sealed class BrowserRunOptions
{
    public bool Headed { get; init; }
    public bool ForwardAllConsole { get; init; }
}

/// <summary>
/// One execution of the wasm test application in a fresh browser.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal static class BrowserRun
{
    /// <returns>The exit code of the test application inside the browser.</returns>
    public static async Task<int> ExecuteAsync(
        string bundleDirectory,
        IReadOnlyList<string> engineArguments,
        BrowserRunOptions options,
        Func<TestEvent, Task> onTestEvent,
        Func<string, Task> onOutput,
        CancellationToken cancellationToken)
    {
        using var server = BundleServer.Start(bundleDirectory);

        await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
        {
            ExecutablePath = HostPaths.ChromePath,
            Headless = !options.Headed,
            Devtools = options.Headed,
            DefaultViewport = options.Headed ? null : ViewPortOptions.Default,
            Args = ["--no-sandbox", "--no-zygote", "--disable-dev-shm-usage"],
        });

        var page = (await browser.PagesAsync()).SingleOrDefault() ?? await browser.NewPageAsync();

        // Browser callbacks arrive on PuppeteerSharp's dispatch loop. They are queued
        // here and replayed in order on the caller's side, so publishing to the test
        // platform never blocks the protocol connection.
        var relay = Channel.CreateUnbounded<Func<Task>>(new UnboundedChannelOptions { SingleReader = true });

        page.Console += (_, e) =>
        {
            var type = e.Message.Type.ToString().ToLowerInvariant();
            if (options.ForwardAllConsole || e.Message.Type is ConsoleType.Error or ConsoleType.Warning or ConsoleType.Assert)
            {
                relay.Writer.TryWrite(() => onOutput($"[browser:{type}] {e.Message.Text}"));
            }
        };
        page.PageError += (_, e) => relay.Writer.TryWrite(() => onOutput("[browser:exception] " + e.Message));
        page.RequestFailed += (_, e) =>
        {
            // Aborted requests are the browser's own cancellations (navigation, probes), not failures.
            if (e.Request.FailureText is not "net::ERR_ABORTED")
            {
                relay.Writer.TryWrite(() => onOutput($"[browser:network] {e.Request.Url}: {e.Request.FailureText}"));
            }
        };

        await page.ExposeFunctionAsync<string, bool>(Wire.SinkBinding, json =>
        {
            if (JsonSerializer.Deserialize(json, ProtocolJsonContext.Default.TestEvent) is { } testEvent)
            {
                relay.Writer.TryWrite(() => onTestEvent(testEvent));
            }

            return true;
        });

        var replay = Task.Run(async () =>
        {
            await foreach (var callback in relay.Reader.ReadAllAsync(cancellationToken))
            {
                await callback();
            }
        }, cancellationToken);

        int exitCode;
        try
        {
            await page.GoToAsync(server.BaseUrl + "index.html", WaitUntilNavigation.Load);
            // Passed as a literal: EvaluateFunctionAsync would spread an array into separate parameters.
            var arguments = JsonSerializer.Serialize(engineArguments.ToArray(), ProtocolJsonContext.Default.StringArray);
            exitCode = await page.EvaluateExpressionAsync<int>($"run({arguments})");

            if (options.Headed)
            {
                await onOutput("The browser window stays open; close it to finish the run.");
                await WaitForCloseAsync(page, browser, cancellationToken);
            }
        }
        finally
        {
            relay.Writer.Complete();
        }

        await replay;
        return exitCode;
    }

    private static async Task WaitForCloseAsync(IPage page, IBrowser browser, CancellationToken cancellationToken)
    {
        var closed = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        page.Close += (_, _) => closed.TrySetResult();
        browser.Closed += (_, _) => closed.TrySetResult();
        browser.Disconnected += (_, _) => closed.TrySetResult();

        if (page.IsClosed || !browser.IsConnected)
        {
            return;
        }

        await closed.Task.WaitAsync(cancellationToken);
    }
}
