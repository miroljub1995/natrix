using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Natrix.TailwindCss.Engine;

/// <summary>
/// Points ClearScript at the native V8 library shipped in the package payload.
/// </summary>
/// <remarks>
/// <see cref="Microsoft.ClearScript.HostSettings.AuxiliarySearchPath"/> is not
/// enough on its own: ClearScript uses it to decide whether the library exists,
/// but then loads it by bare name, which only ever finds the application
/// directory. Since the application here is the compiler host, the library has to
/// be injected into the P/Invoke resolution path explicitly.
/// </remarks>
internal static class NativeV8Loader
{
    private static int _installed;

    /// <summary>
    /// Makes <paramref name="nativeDir"/> the source for ClearScript's native
    /// library. Safe to call repeatedly; only the first call takes effect, which
    /// is also all the underlying APIs permit.
    /// </summary>
    internal static void Install(string nativeDir)
    {
        if (string.IsNullOrEmpty(nativeDir) || Interlocked.Exchange(ref _installed, 1) != 0)
            return;

#if NETFRAMEWORK
        // Windows returns the already-loaded module for any later LoadLibrary
        // call with the same base name, so loading it here by full path is
        // enough to satisfy ClearScript's DllImports.
        foreach (var file in Directory.GetFiles(nativeDir, "ClearScriptV8.*.dll"))
            LoadLibrary(file);
#else
        var clearScriptV8 = typeof(Microsoft.ClearScript.V8.V8ScriptEngine).Assembly;

        NativeLibrary.SetDllImportResolver(clearScriptV8, (libraryName, _, _) =>
        {
            var path = Path.Combine(nativeDir, libraryName);
            return File.Exists(path) ? NativeLibrary.Load(path) : IntPtr.Zero;
        });
#endif
    }

#if NETFRAMEWORK
    [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern IntPtr LoadLibrary(string path);
#endif
}
