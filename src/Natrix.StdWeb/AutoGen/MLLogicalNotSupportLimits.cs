// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLLogicalNotSupportLimits: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLLogicalNotSupportLimits>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLLogicalNotSupportLimits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLLogicalNotSupportLimits global::Natrix.JSCore.IJSObjectProxy<MLLogicalNotSupportLimits>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLLogicalNotSupportLimits(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits A
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Get(JSObject, "a");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Set(JSObject, "a", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Output
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Get(JSObject, "output");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.MLTensorLimits>.Set(JSObject, "output", value);
    }
}

#nullable disable