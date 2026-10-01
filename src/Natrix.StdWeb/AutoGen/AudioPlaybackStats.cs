// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AudioPlaybackStats: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AudioPlaybackStats>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AudioPlaybackStats(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AudioPlaybackStats global::Natrix.JSCore.IJSObjectProxy<AudioPlaybackStats>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<AudioPlaybackStats>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double UnderrunDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "underrunDuration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UnderrunEvents
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "underrunEvents");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double TotalDuration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "totalDuration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double AverageLatency
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "averageLatency");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinimumLatency
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "minimumLatency");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaximumLatency
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maximumLatency");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ResetLatency()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "resetLatency", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable