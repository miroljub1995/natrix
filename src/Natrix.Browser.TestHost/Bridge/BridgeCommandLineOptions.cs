using Microsoft.Testing.Platform.CommandLine;
using Microsoft.Testing.Platform.Extensions;
using Microsoft.Testing.Platform.Extensions.CommandLine;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

[UnsupportedOSPlatform("browser")]
internal sealed class BridgeCommandLineOptions : ICommandLineOptionsProvider
{
    public const string HeadedOption = "browser-headed";
    public const string ConsoleOption = "browser-console";

    /// <summary>
    /// The platform only registers this option for frameworks that opt in through an
    /// internal service, so the bridge declares it itself and forwards it verbatim.
    /// </summary>
    public const string TreeNodeFilterOption = "treenode-filter";

    /// <summary>Environment equivalents, for IDE run configurations that cannot pass arguments.</summary>
    public const string HeadedVariable = "NATRIX_BROWSER_TESTHOST_HEADED";
    public const string ConsoleVariable = "NATRIX_BROWSER_TESTHOST_CONSOLE";

    public string Uid => "Natrix.Browser.TestHost.Bridge.CommandLine";
    public string Version => "1.0.0";
    public string DisplayName => "Natrix browser test host";
    public string Description => "Options controlling the browser the tests run in.";

    public Task<bool> IsEnabledAsync() => Task.FromResult(true);

    public IReadOnlyCollection<CommandLineOption> GetCommandLineOptions() =>
    [
        new CommandLineOption(HeadedOption,
            "Run in a visible browser window with DevTools open, and keep it open after the run until the window is closed.",
            ArgumentArity.Zero, isHidden: false),
        new CommandLineOption(ConsoleOption,
            "Forward all browser console output. By default only warnings and errors are shown.",
            ArgumentArity.Zero, isHidden: false),
        new CommandLineOption(TreeNodeFilterOption,
            "Run only the tests matching the tree node filter, e.g. /*/*/ClassName/*.",
            ArgumentArity.ExactlyOne, isHidden: false),
    ];

    public Task<ValidationResult> ValidateOptionArgumentsAsync(CommandLineOption commandOption, string[] arguments) =>
        ValidationResult.ValidTask;

    public Task<ValidationResult> ValidateCommandLineOptionsAsync(ICommandLineOptions commandLineOptions) =>
        ValidationResult.ValidTask;

    public static bool IsSet(ICommandLineOptions options, string option, string variable) =>
        options.IsOptionSet(option) || Environment.GetEnvironmentVariable(variable) is "1" or "true";
}
