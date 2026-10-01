// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TouchEventInit: global::Natrix.StdWeb.EventModifierInit, global::Natrix.JSCore.IJSObjectProxy<TouchEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TouchEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TouchEventInit global::Natrix.JSCore.IJSObjectProxy<TouchEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TouchEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>> Touches
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>>>(JSObject, "touches");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>>>(JSObject, "touches", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>> TargetTouches
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>>>(JSObject, "targetTouches");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>>>(JSObject, "targetTouches", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>> ChangedTouches
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>>>(JSObject, "changedTouches");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Touch, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Touch>>>>(JSObject, "changedTouches", value);
    }
}

#nullable disable