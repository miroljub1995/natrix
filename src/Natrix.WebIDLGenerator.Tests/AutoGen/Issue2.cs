// ReSharper disable All

namespace Natrix.WebIDLGenerator.Tests;

#nullable enable

public partial class Issue2: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<Issue2>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Issue2(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Issue2 global::Natrix.JSCore.IJSObjectProxy<Issue2>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Issue2>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Value
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "value", value);
    }
}

#nullable disable