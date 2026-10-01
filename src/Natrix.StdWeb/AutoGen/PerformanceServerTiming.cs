// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PerformanceServerTiming: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PerformanceServerTiming>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PerformanceServerTiming(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PerformanceServerTiming global::Natrix.JSCore.IJSObjectProxy<PerformanceServerTiming>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<PerformanceServerTiming>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Duration
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "duration");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Description
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "description");
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