// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InputEventInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<InputEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InputEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InputEventInit global::Natrix.JSCore.IJSObjectProxy<InputEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InputEventInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DataTransfer? DataTransfer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DataTransfer>.Get(JSObject, "dataTransfer");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.DataTransfer>.Set(JSObject, "dataTransfer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.StaticRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StaticRange>> TargetRanges
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.StaticRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StaticRange>>>.Get(JSObject, "targetRanges");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.StaticRange, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StaticRange>>>.Set(JSObject, "targetRanges", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Data
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "data");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "data", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsComposing
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isComposing");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isComposing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string InputType
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "inputType");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "inputType", value);
    }
}

#nullable disable