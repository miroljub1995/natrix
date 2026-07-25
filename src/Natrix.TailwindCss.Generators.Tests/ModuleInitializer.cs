using System.Runtime.CompilerServices;

namespace Natrix.TailwindCss.Generators.Tests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize() => VerifySourceGenerators.Initialize();
}
