// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ProfilerTrace: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ProfilerTrace>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerTrace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ProfilerTrace global::Natrix.JSCore.IJSObjectProxy<ProfilerTrace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ProfilerTrace(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Resources
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "resources");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>>(JSObject, "resources", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerFrame>> Frames
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerFrame>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerFrame>>>>(JSObject, "frames");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerFrame>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerFrame, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerFrame>>>>(JSObject, "frames", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerStack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerStack>> Stacks
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerStack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerStack>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerStack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerStack>>>>(JSObject, "stacks");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerStack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerStack>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerStack, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerStack>>>>(JSObject, "stacks", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerSample, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerSample>> Samples
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerSample, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerSample>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerSample, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerSample>>>>(JSObject, "samples");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerSample, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerSample>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ProfilerSample, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ProfilerSample>>>>(JSObject, "samples", value);
    }
}

#nullable disable