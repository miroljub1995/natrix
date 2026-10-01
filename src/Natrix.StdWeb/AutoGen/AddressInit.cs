// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class AddressInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<AddressInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AddressInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static AddressInit global::Natrix.JSCore.IJSObjectProxy<AddressInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public AddressInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Country
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "country");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "country", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> AddressLine
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "addressLine");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "addressLine", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Region
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "region");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "region", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string City
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "city");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "city", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string DependentLocality
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "dependentLocality");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "dependentLocality", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string PostalCode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "postalCode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "postalCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string SortingCode
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "sortingCode");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "sortingCode", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Organization
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "organization");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "organization", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Recipient
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "recipient");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "recipient", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Phone
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "phone");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "phone", value);
    }
}

#nullable disable