// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ConvolverOptions: global::Natrix.StdWeb.AudioNodeOptions, global::Natrix.JSCore.IJSObjectProxy<ConvolverOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConvolverOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ConvolverOptions global::Natrix.JSCore.IJSObjectProxy<ConvolverOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ConvolverOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AudioBuffer? Buffer
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Get(JSObject, "buffer");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.AudioBuffer>.Set(JSObject, "buffer", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool DisableNormalization
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "disableNormalization");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "disableNormalization", value);
    }
}

#nullable disable