// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUVertexAttribute: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUVertexAttribute>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexAttribute(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUVertexAttribute global::Natrix.JSCore.IJSObjectProxy<GPUVertexAttribute>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUVertexAttribute(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUVertexFormat Format
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUVertexFormat>.Get(JSObject, "format");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUVertexFormat>.Set(JSObject, "format", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required ulong Offset
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "offset");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "offset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint ShaderLocation
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "shaderLocation");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "shaderLocation", value);
    }
}

#nullable disable