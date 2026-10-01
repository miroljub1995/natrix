// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BlobEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<BlobEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BlobEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BlobEventInit global::Natrix.JSCore.IJSObjectProxy<BlobEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BlobEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.Blob Data
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Blob>.Set(JSObject, "data", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Timecode
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "timecode");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "timecode", value);
    }
}

#nullable disable