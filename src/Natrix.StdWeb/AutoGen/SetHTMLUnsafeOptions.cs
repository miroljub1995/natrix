// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SetHTMLUnsafeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SetHTMLUnsafeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SetHTMLUnsafeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SetHTMLUnsafeOptions global::Natrix.JSCore.IJSObjectProxy<SetHTMLUnsafeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SetHTMLUnsafeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Sanitizer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SanitizerConfig>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SanitizerPresets>> Sanitizer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Sanitizer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SanitizerConfig>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SanitizerPresets>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Sanitizer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SanitizerConfig>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SanitizerPresets>>>>(JSObject, "sanitizer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Sanitizer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SanitizerConfig>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SanitizerPresets>>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Sanitizer>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.SanitizerConfig>, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.SanitizerPresets>>>>(JSObject, "sanitizer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RunScripts
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "runScripts");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "runScripts", value);
    }
}

#nullable disable