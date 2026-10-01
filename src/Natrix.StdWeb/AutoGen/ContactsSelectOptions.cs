// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ContactsSelectOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ContactsSelectOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ContactsSelectOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ContactsSelectOptions global::Natrix.JSCore.IJSObjectProxy<ContactsSelectOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ContactsSelectOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Multiple
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "multiple");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "multiple", value);
    }
}

#nullable disable