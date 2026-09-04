# Natrix.Browser.TestHost

Lets a `browser-wasm` TUnit test project run through plain `dotnet test` and IDE
test explorers, with the tests executing in headless Chromium.

## Usage

Reference this project and hand it the entry point:

```csharp
// Program.cs
return await Natrix.Browser.TestHost.BrowserTestHost.RunAsync(args);
```

Then import `build/Natrix.Browser.TestHost.targets` (a package reference would
do this automatically). That is all; `dotnet test` and test explorers work.

## How it works

The same assembly runs on both sides:

- In the browser it is an ordinary TUnit test application.
- On the host (`dotnet test`, IDE test explorers) it is a Microsoft.Testing.Platform
  test framework that serves the wasm `AppBundle` to headless Chromium
  (ChromeForTesting, driven with PuppeteerSharp) and relays each result back as a
  test node. Discovery runs the assembly again on the host in engine mode,
  without a browser.

The targets file makes the wasm build output launchable on the host: it rewrites
the runtimeconfig to be framework-dependent, points `RunCommand` at the test
assembly instead of `WasmAppHost`, injects the discovery hook, and fetches Chrome
for the host runtime identifier.

An optional `test-extension-init.js` module deployed with the bundle is imported
and its `init()` awaited before the runtime starts, for JavaScript fixtures.

## Options

Pass them after `--`:

- `--browser-headed` opens a visible browser with DevTools and keeps it open
  until the window is closed.
- `--browser-console` forwards all browser console output; by default only
  warnings and errors are shown.
- `--treenode-filter` works as usual, e.g. `/*/*/IfTests/*`.

Environment equivalents, for IDE run configurations:
`NATRIX_BROWSER_TESTHOST_HEADED=1`, `NATRIX_BROWSER_TESTHOST_CONSOLE=1`.
`NATRIX_BROWSER_TESTHOST_CHROME` overrides the browser executable, and
`NATRIX_BROWSER_TESTHOST_BUNDLE` the bundle directory.
