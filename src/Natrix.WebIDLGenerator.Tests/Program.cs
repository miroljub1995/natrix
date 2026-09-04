// In the browser this is a TUnit test application. On the host (dotnet test, IDE
// test explorers) the same assembly launches headless Chromium and runs itself there.
return await Natrix.Browser.TestHost.BrowserTestHost.RunAsync(args);
