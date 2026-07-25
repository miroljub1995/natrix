// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class URLPatternResult: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public URLPatternResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public URLPatternResult(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> Inputs
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "inputs");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<string, global::Natrix.StdWeb.URLPatternInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "inputs", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Protocol
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "protocol");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "protocol", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Username
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "username");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "username", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Password
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "password");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "password", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Hostname
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hostname");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hostname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Port
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "port", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Pathname
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pathname");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pathname", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Search
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "search");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "search", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.URLPatternComponentResult Hash
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hash");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.URLPatternComponentResult, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hash", value);
    }
}

#nullable disable