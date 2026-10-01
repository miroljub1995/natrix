// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NDEFMessageInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<NDEFMessageInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NDEFMessageInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static NDEFMessageInit global::Natrix.JSCore.IJSObjectProxy<NDEFMessageInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NDEFMessageInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecordInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFRecordInit>> Records
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecordInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFRecordInit>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecordInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFRecordInit>>>>(JSObject, "records");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecordInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFRecordInit>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecordInit, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NDEFRecordInit>>>>(JSObject, "records", value);
    }
}

#nullable disable