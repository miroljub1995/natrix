// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ExtendableMessageEventInit: global::Natrix.StdWeb.ExtendableEventInit, global::Natrix.JSCore.IJSObjectProxy<ExtendableMessageEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ExtendableMessageEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ExtendableMessageEventInit global::Natrix.JSCore.IJSObjectProxy<ExtendableMessageEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ExtendableMessageEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>? Data
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.StringAccessor, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.JSObjectAccessor, global::Natrix.JSCore.Generics.ObjectAccessor>>.Set(JSObject, "data", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "origin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LastEventId
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "lastEventId");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "lastEventId", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Client>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>? Source
    {
        get => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Client>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Get(JSObject, "source");
        set => global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Client>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ServiceWorker>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Set(JSObject, "source", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>> Ports
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Get(JSObject, "ports");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.MessagePort, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MessagePort>>>.Set(JSObject, "ports", value);
    }
}

#nullable disable