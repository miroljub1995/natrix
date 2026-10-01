// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class RTCIceParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<RTCIceParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static RTCIceParameters global::Natrix.JSCore.IJSObjectProxy<RTCIceParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public RTCIceParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IceLite
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "iceLite");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "iceLite", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string UsernameFragment
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "usernameFragment");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "usernameFragment", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Password
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "password");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "password", value);
    }
}

#nullable disable