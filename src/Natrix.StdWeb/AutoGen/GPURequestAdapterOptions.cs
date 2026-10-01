// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPURequestAdapterOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPURequestAdapterOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURequestAdapterOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPURequestAdapterOptions global::Natrix.JSCore.IJSObjectProxy<GPURequestAdapterOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPURequestAdapterOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string FeatureLevel
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "featureLevel");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "featureLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.GPUPowerPreference PowerPreference
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUPowerPreference>.Get(JSObject, "powerPreference");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.GPUPowerPreference>.Set(JSObject, "powerPreference", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ForceFallbackAdapter
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "forceFallbackAdapter");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "forceFallbackAdapter", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool XrCompatible
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "xrCompatible");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "xrCompatible", value);
    }
}

#nullable disable