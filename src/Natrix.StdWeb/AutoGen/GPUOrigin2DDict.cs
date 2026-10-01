// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUOrigin2DDict: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUOrigin2DDict>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUOrigin2DDict(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUOrigin2DDict global::Natrix.JSCore.IJSObjectProxy<GPUOrigin2DDict>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUOrigin2DDict(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint X
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Y
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "y", value);
    }
}

#nullable disable