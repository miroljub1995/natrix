// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HashChangeEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<HashChangeEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HashChangeEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HashChangeEventInit global::Natrix.JSCore.IJSObjectProxy<HashChangeEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HashChangeEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string OldURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "oldURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "oldURL", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string NewURL
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "newURL");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "newURL", value);
    }
}

#nullable disable