// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class TestStaticProperties: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<TestStaticProperties>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public TestStaticProperties(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static TestStaticProperties global::Natrix.JSCore.IJSObjectProxy<TestStaticProperties>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<TestStaticProperties>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public static int SimpleProp
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TestStaticProperties"), "simpleProp");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsConstructorProxy(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "TestStaticProperties"), "simpleProp", value);
    }
}

#nullable disable