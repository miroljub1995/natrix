// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLFormControlsCollection: global::Natrix.StdWeb.HTMLCollection, global::Natrix.JSCore.IJSObjectProxy<HTMLFormControlsCollection>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLFormControlsCollection(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLFormControlsCollection global::Natrix.JSCore.IJSObjectProxy<HTMLFormControlsCollection>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLFormControlsCollection>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RadioNodeList>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? NamedItem(string name)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = name;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "namedItem", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RadioNodeList>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>?, global::Natrix.JSCore.Generics.NullableUnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.RadioNodeList>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable