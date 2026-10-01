// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUBufferBindingLayout: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUBufferBindingLayout>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferBindingLayout(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUBufferBindingLayout global::Natrix.JSCore.IJSObjectProxy<GPUBufferBindingLayout>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUBufferBindingLayout(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUBufferBindingType Type
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBufferBindingType>.Get(JSObject, "type");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUBufferBindingType>.Set(JSObject, "type", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasDynamicOffset
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasDynamicOffset");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hasDynamicOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong MinBindingSize
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "minBindingSize");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "minBindingSize", value);
    }
}

#nullable disable