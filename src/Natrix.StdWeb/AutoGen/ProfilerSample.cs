// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProfilerSample: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ProfilerSample>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerSample(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProfilerSample global::Natrix.JSCore.IJSObjectProxy<ProfilerSample>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerSample(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Timestamp
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "timestamp");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "timestamp", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ulong StackId
    {
        get => global::Natrix.JSCore.Generics.UInt64Accessor.Get(JSObject, "stackId");
        set => global::Natrix.JSCore.Generics.UInt64Accessor.Set(JSObject, "stackId", value);
    }
}

#nullable disable