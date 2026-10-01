// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Location: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Location>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Location(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Location global::Natrix.JSCore.IJSObjectProxy<Location>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Location>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Href
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "href");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "href", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Origin
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "origin");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Protocol
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Host
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "host");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "host", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hostname
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hostname");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hostname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Port
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "port");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Pathname
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "pathname");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "pathname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Search
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "search");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "search", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Hash
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "hash", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Assign(string url)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "assign", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Replace(string url)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = url;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "replace", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Reload()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "reload", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMStringList AncestorOrigins
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMStringList>.Get(JSObject, "ancestorOrigins");
    }
}

#nullable disable