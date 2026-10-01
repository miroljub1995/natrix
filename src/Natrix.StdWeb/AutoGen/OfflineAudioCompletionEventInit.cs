// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OfflineAudioCompletionEventInit: global::Natrix.StdWeb.EventInit, global::Natrix.JSCore.IJSObjectProxy<OfflineAudioCompletionEventInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OfflineAudioCompletionEventInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OfflineAudioCompletionEventInit global::Natrix.JSCore.IJSObjectProxy<OfflineAudioCompletionEventInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OfflineAudioCompletionEventInit(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.AudioBuffer RenderedBuffer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AudioBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioBuffer>>(JSObject, "renderedBuffer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AudioBuffer, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.AudioBuffer>>(JSObject, "renderedBuffer", value);
    }
}

#nullable disable