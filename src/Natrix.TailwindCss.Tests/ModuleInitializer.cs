using System.Runtime.CompilerServices;

namespace Natrix.TailwindCss.Tests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize() => VerifySourceGenerators.Initialize();
}
