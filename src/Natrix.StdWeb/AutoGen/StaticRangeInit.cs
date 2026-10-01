// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StaticRangeInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<StaticRangeInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StaticRangeInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static StaticRangeInit global::Natrix.JSCore.IJSObjectProxy<StaticRangeInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StaticRangeInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Node StartContainer
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "startContainer");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Set(JSObject, "startContainer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint StartOffset
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "startOffset");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "startOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Node EndContainer
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(JSObject, "endContainer");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Set(JSObject, "endContainer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint EndOffset
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "endOffset");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "endOffset", value);
    }
}

#nullable disable