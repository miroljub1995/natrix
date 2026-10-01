// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioTimestamp: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioTimestamp>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioTimestamp(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioTimestamp global::Natrix.JSCore.IJSObjectProxy<AudioTimestamp>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioTimestamp(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ContextTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "contextTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "contextTime", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PerformanceTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "performanceTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "performanceTime", value);
    }
}

#nullable disable