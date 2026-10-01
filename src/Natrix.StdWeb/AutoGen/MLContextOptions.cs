// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLContextOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MLContextOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLContextOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLContextOptions global::Natrix.JSCore.IJSObjectProxy<MLContextOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLContextOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLPowerPreference PowerPreference
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLPowerPreference>.Get(JSObject, "powerPreference");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MLPowerPreference>.Set(JSObject, "powerPreference", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Accelerated
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "accelerated");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "accelerated", value);
    }
}

#nullable disable