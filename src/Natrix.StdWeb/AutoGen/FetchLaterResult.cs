// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FetchLaterResult: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<FetchLaterResult>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FetchLaterResult(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static FetchLaterResult global::Natrix.JSCore.IJSObjectProxy<FetchLaterResult>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<FetchLaterResult>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Activated
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.JSCore.Generics.BooleanAccessor>(JSObject, "activated");
    }
}

#nullable disable