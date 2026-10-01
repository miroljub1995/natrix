// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUProgrammableStage: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUProgrammableStage>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUProgrammableStage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUProgrammableStage global::Natrix.JSCore.IJSObjectProxy<GPUProgrammableStage>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUProgrammableStage(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.GPUShaderModule Module
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModule>.Get(JSObject, "module");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.GPUShaderModule>.Set(JSObject, "module", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string EntryPoint
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "entryPoint");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "entryPoint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor> Constants
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Get(JSObject, "constants");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Record<double, global::Natrix.JSCore.Generics.DoubleAccessor>>.Set(JSObject, "constants", value);
    }
}

#nullable disable