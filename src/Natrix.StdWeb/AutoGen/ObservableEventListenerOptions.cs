// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ObservableEventListenerOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ObservableEventListenerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ObservableEventListenerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ObservableEventListenerOptions global::Natrix.JSCore.IJSObjectProxy<ObservableEventListenerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ObservableEventListenerOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Capture
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "capture");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "capture", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Passive
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "passive");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "passive", value);
    }
}

#nullable disable