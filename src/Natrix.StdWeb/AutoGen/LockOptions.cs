// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LockOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<LockOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LockOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static LockOptions global::Natrix.JSCore.IJSObjectProxy<LockOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LockOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.LockMode Mode
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LockMode>.Get(JSObject, "mode");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.LockMode>.Set(JSObject, "mode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IfAvailable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "ifAvailable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "ifAvailable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Steal
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "steal");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "steal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }
}

#nullable disable