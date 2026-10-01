// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NDEFReadingEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<NDEFReadingEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NDEFReadingEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NDEFReadingEventInit global::Natrix.JSCore.IJSObjectProxy<NDEFReadingEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NDEFReadingEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SerialNumber
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "serialNumber");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "serialNumber", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.NDEFMessageInit Message
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFMessageInit>.Get(JSObject, "message");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFMessageInit>.Set(JSObject, "message", value);
    }
}

#nullable disable