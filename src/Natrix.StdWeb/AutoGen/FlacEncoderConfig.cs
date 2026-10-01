// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FlacEncoderConfig: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FlacEncoderConfig>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FlacEncoderConfig(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FlacEncoderConfig global::Natrix.JSCore.IJSObjectProxy<FlacEncoderConfig>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FlacEncoderConfig(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint BlockSize
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "blockSize");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "blockSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint CompressLevel
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "compressLevel");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "compressLevel", value);
    }
}

#nullable disable