// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class UserActivation: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<UserActivation>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public UserActivation(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static UserActivation global::Natrix.JSCore.IJSObjectProxy<UserActivation>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<UserActivation>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasBeenActive
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasBeenActive");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsActive
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isActive");
    }
}

#nullable disable