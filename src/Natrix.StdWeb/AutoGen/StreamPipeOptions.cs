// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StreamPipeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<StreamPipeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StreamPipeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static StreamPipeOptions global::Natrix.JSCore.IJSObjectProxy<StreamPipeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StreamPipeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreventClose
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preventClose");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preventClose", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreventAbort
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preventAbort");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preventAbort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PreventCancel
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "preventCancel");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "preventCancel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Get(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AbortSignal>.Set(JSObject, "signal", value);
    }
}

#nullable disable