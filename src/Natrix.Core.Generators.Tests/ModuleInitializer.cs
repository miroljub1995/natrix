using System.Runtime.CompilerServices;

namespace Natrix.Core.Generators.Tests;

public static class ModuleInitializer
{
    [ModuleInitializer]
    public static void Initialize() => VerifySourceGenerators.Initialize();
}
