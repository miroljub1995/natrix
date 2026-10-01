// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BufferedChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<BufferedChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BufferedChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BufferedChangeEventInit global::Natrix.JSCore.IJSObjectProxy<BufferedChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BufferedChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TimeRanges AddedRanges
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Get(JSObject, "addedRanges");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Set(JSObject, "addedRanges", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TimeRanges RemovedRanges
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Get(JSObject, "removedRanges");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TimeRanges>.Set(JSObject, "removedRanges", value);
    }
}

#nullable disable