// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class External: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<External>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public External(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static External global::Natrix.JSCore.IJSObjectProxy<External>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<External>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void AddSearchProvider()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "AddSearchProvider", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void IsSearchProviderInstalled()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "IsSearchProviderInstalled", JSObject);
    }
}

#nullable disable