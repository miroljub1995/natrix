using System.Diagnostics;
using ChromeForTesting;
using Microsoft.Extensions.FileProviders;
using PuppeteerSharp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("index.html",
    () => Results.File(Path.Join(AppDomain.CurrentDomain.BaseDirectory, "./index.html"), "text/html; charset=utf-8")
);

var appBundlePath = app.Configuration["RunnerBundlePath"] ?? throw new Exception("RunnerBundlePath is not set.");
// The runner and the test bundle are built for the same target framework, so
// resolve the "{tfm}" placeholder from the runner's own output folder (e.g.
// ".../bin/Debug/net9.0/") to serve the matching bundle.
var tfm = new DirectoryInfo(AppContext.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar)).Name;
appBundlePath = appBundlePath.Replace("{tfm}", tfm);
var appBundleFullPath = Path.GetFullPath(Path.Join(AppDomain.CurrentDomain.BaseDirectory, appBundlePath));

app.UseStaticFiles(new StaticFileOptions
{
    ServeUnknownFileTypes = true,
    FileProvider = new PhysicalFileProvider(appBundleFullPath)
});

var appStarted = new TaskCompletionSource();
app.Lifetime.ApplicationStarted.Register(appStarted.SetResult);

var appRunTask = app.RunAsync("https://127.0.0.1:0");
await appStarted.Task;

var url = new Uri(app.Urls.Single());

var isDebug = Debugger.IsAttached;

LaunchOptions options = new()
{
    ExecutablePath = ChromeForTestingInstance.ChromePath,
    Args =
    [
        "--no-sandbox",
        "--no-zygote",
        // "--disable-web-security",
    ],
    DumpIO = true,
    Headless = !isDebug,
    Devtools = isDebug,
    DefaultViewport = isDebug ? null : ViewPortOptions.Default,
    AcceptInsecureCerts = true,
};

await using var browser = await Puppeteer.LaunchAsync(options, app.Services.GetRequiredService<ILoggerFactory>());

var pages = await browser.PagesAsync();
var page = pages.Single();

page.Console += (_, args) =>
{
    switch (args.Message.Type)
    {
        case ConsoleType.Error:
            app.Logger.LogError(args.Message.Text);
            break;
        case ConsoleType.Warning:
            app.Logger.LogWarning(args.Message.Text);
            break;
        case ConsoleType.Log:
            app.Logger.LogInformation(args.Message.Text);
            break;
        case ConsoleType.Trace:
            app.Logger.LogTrace(args.Message.Text);
            break;
    }
};

await page.GoToAsync($"https://127.0.0.1:{url.Port}/index.html");
await page.WaitForExpressionAsync("!!globalThis.run");
var exitCode = await page.EvaluateExpressionAsync<int>("run();");

if (isDebug)
{
    var closeTaskSource = new TaskCompletionSource();
    page.Close += (_, _) => { closeTaskSource.SetResult(); };
    await closeTaskSource.Task;
}

await app.StopAsync();
await appRunTask;

Environment.Exit(exitCode);