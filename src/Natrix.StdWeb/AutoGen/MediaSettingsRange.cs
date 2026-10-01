// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MediaSettingsRange: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MediaSettingsRange>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaSettingsRange(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MediaSettingsRange global::Natrix.JSCore.IJSObjectProxy<MediaSettingsRange>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MediaSettingsRange(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Max
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "max");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "max", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Min
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "min");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "min", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Step
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "step");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "step", value);
    }
}

#nullable disable