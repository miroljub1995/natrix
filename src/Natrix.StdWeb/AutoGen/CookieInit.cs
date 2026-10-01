// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CookieInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CookieInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CookieInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CookieInit global::Natrix.JSCore.IJSObjectProxy<CookieInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CookieInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Value
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "value");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Expires
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "expires");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double?, global::Natrix.JSCore.Generics.NullableDoubleAccessor>(JSObject, "expires", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Domain
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "domain");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string?, global::Natrix.JSCore.Generics.NullableStringAccessor>(JSObject, "domain", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Path
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "path");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.JSCore.Generics.StringAccessor>(JSObject, "path", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CookieSameSite SameSite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CookieSameSite, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CookieSameSite>>(JSObject, "sameSite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.CookieSameSite, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CookieSameSite>>(JSObject, "sameSite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Partitioned
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "partitioned");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "partitioned", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public long? MaxAge
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<long?, global::Natrix.JSCore.Generics.NullableInt64Accessor>(JSObject, "maxAge");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<long?, global::Natrix.JSCore.Generics.NullableInt64Accessor>(JSObject, "maxAge", value);
    }
}

#nullable disable