// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestNamespace: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestNamespace>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestNamespace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestNamespace global::Natrix.JSCore.IJSObjectProxy<TestNamespace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestNamespace>(obj);


}

#nullable disable