// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUMultisampleState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUMultisampleState>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUMultisampleState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUMultisampleState global::Natrix.JSCore.IJSObjectProxy<GPUMultisampleState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUMultisampleState(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Count
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "count");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "count", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Mask
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "mask");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "mask", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AlphaToCoverageEnabled
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "alphaToCoverageEnabled");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "alphaToCoverageEnabled", value);
    }
}

#nullable disable