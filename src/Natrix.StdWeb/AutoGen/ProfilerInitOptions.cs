// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProfilerInitOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ProfilerInitOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerInitOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProfilerInitOptions global::Natrix.JSCore.IJSObjectProxy<ProfilerInitOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerInitOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double SampleInterval
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "sampleInterval");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "sampleInterval", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required uint MaxBufferSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "maxBufferSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "maxBufferSize", value);
    }
}

#nullable disable