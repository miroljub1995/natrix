# Running Browser-WASM Tests

`Natrix.Browser.Tests` and `Natrix.WebIDLGenerator.Tests` are compiled for
`browser-wasm` and need a real browser, but they run through the normal command:

```bash
dotnet test src/Natrix.Browser.Tests/Natrix.Browser.Tests.csproj -f <tfm>
```

`-f` is required because the projects multi-target `net9.0` and `net10.0`.

## How it works

The test projects reference `Natrix.Browser.TestHost` and call
`BrowserTestHost.RunAsync` from `Program.cs`. The same assembly then runs on both
sides:

- In the browser it is an ordinary TUnit test application.
- On the host (`dotnet test`, IDE test explorers) it is a Microsoft.Testing.Platform
  test framework that serves the wasm `AppBundle` to headless Chromium
  (ChromeForTesting, driven with PuppeteerSharp) and relays each result
  back as a test node. Discovery runs the assembly again on the host in engine
  mode, without a browser.

`src/Natrix.Browser.TestHost/build/Natrix.Browser.TestHost.targets` makes the
build output launchable on the host: it rewrites the runtimeconfig to be
framework-dependent and points `RunCommand` at the test assembly instead of
`WasmAppHost`.

## Options

Pass options after `--`:

- `--browser-headed` opens a visible browser with DevTools and keeps it open
  until the window is closed.
- `--browser-console` forwards all browser console output; by default only
  warnings and errors are shown.
- `--treenode-filter` works as usual, e.g. `/*/*/IfTests/*`.

Environment equivalents for IDE run configurations:
`NATRIX_BROWSER_TESTHOST_HEADED=1`, `NATRIX_BROWSER_TESTHOST_CONSOLE=1`.
`NATRIX_BROWSER_TESTHOST_CHROME` overrides the browser executable.
