// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ContactsManager: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ContactsManager>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ContactsManager(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ContactsManager global::Natrix.JSCore.IJSObjectProxy<ContactsManager>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ContactsManager>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>>>> GetProperties()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getProperties", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>>>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>>> Select(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>> properties)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = properties.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "select", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>>>>>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>>> Select(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactProperty, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.ContactProperty>> properties, global::Natrix.StdWeb.ContactsSelectOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = properties.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "select", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.Promise<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.ContactInfo, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ContactInfo>>>>>>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable