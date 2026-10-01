// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PositionOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PositionOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PositionOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PositionOptions global::Natrix.JSCore.IJSObjectProxy<PositionOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PositionOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool EnableHighAccuracy
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "enableHighAccuracy");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "enableHighAccuracy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Timeout
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "timeout");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "timeout", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaximumAge
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "maximumAge");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "maximumAge", value);
    }
}

#nullable disable