// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ContactAddress: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ContactAddress>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ContactAddress(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ContactAddress global::Natrix.JSCore.IJSObjectProxy<ContactAddress>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ContactAddress>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::System.Runtime.InteropServices.JavaScript.JSObject ToJSON()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "toJSON", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.JSObjectAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string City
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "city");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Country
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "country");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DependentLocality
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dependentLocality");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Organization
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "organization");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Phone
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "phone");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PostalCode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "postalCode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Recipient
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "recipient");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Region
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "region");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SortingCode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sortingCode");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor> AddressLine
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "addressLine");
    }
}

#nullable disable