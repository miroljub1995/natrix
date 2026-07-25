---
description: "Use when running, debugging, or writing tests for Natrix.Browser.Tests or Natrix.WebIDLGenerator.Tests. Covers how browser-wasm tests must be executed via BrowserTestsRunner."
applyTo: "src/Natrix.Browser.Tests/**,src/Natrix.WebIDLGenerator.Tests/**,src/Natrix.BrowserTestsRunner/**"
---

# Running Browser-WASM Tests

Do **not** use `dotnet test` — `browser-wasm` tests require a real browser. Use `Natrix.BrowserTestsRunner`, which serves the compiled WASM `AppBundle` and runs tests in headless Chromium via PuppeteerSharp.

To run tests, use the following command from the workspace root — it will automatically build the test project and run the tests:

```bash
dotnet run --project src/Natrix.BrowserTestsRunner -f <tfm> --launch-profile <profile>
```

The `-f` flag is required because `Natrix.BrowserTestsRunner` multi-targets; the tests run on both `net9.0` and `net10.0`, and the runner serves the bundle built for the chosen TFM.

Available profiles:
- `Natrix.Browser.Tests`
- `Natrix.WebIDLGenerator.Tests`
