// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class TestUtilsNamespace: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestUtilsNamespace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Gc()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "gc", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Promise, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }
}

public partial class ServiceWorkerGlobalScope
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TestUtilsNamespace TestUtils => new global::Natrix.StdWeb.TestUtilsNamespace(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(JSObject, "TestUtils"));
}

public partial class Window
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TestUtilsNamespace TestUtils => new global::Natrix.StdWeb.TestUtilsNamespace(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(JSObject, "TestUtils"));
}

public partial class DedicatedWorkerGlobalScope
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TestUtilsNamespace TestUtils => new global::Natrix.StdWeb.TestUtilsNamespace(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(JSObject, "TestUtils"));
}

public partial class RTCIdentityProviderGlobalScope
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TestUtilsNamespace TestUtils => new global::Natrix.StdWeb.TestUtilsNamespace(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(JSObject, "TestUtils"));
}

public partial class SharedWorkerGlobalScope
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.TestUtilsNamespace TestUtils => new global::Natrix.StdWeb.TestUtilsNamespace(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(JSObject, "TestUtils"));
}

#nullable disable