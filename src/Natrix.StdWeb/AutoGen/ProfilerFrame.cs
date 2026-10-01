// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProfilerFrame: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ProfilerFrame>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerFrame(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProfilerFrame global::Natrix.JSCore.IJSObjectProxy<ProfilerFrame>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerFrame(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong ResourceId
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "resourceId");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "resourceId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Line
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "line");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "line", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong Column
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "column");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "column", value);
    }
}

#nullable disable