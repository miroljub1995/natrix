// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLRankRange: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLRankRange>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLRankRange(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLRankRange global::Natrix.JSCore.IJSObjectProxy<MLRankRange>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLRankRange(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Min
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "min");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Max
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "max");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "max", value);
    }
}

#nullable disable