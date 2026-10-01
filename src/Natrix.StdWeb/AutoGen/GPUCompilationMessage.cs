// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUCompilationMessage: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUCompilationMessage>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUCompilationMessage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUCompilationMessage global::Natrix.JSCore.IJSObjectProxy<GPUCompilationMessage>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<GPUCompilationMessage>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Message
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "message");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUCompilationMessageType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUCompilationMessageType>.Get(JSObject, "type");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LineNum
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "lineNum");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong LinePos
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "linePos");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Offset
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "offset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Length
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "length");
    }
}

#nullable disable