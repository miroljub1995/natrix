// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class NotRestoredReasons: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public NotRestoredReasons(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Src
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "src");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Id
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "id");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Name
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Url
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "url");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? Reasons
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "reasons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? Children
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "children");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::System.Runtime.InteropServices.JavaScript.JSObject, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable