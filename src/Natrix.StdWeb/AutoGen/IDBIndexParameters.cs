// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IDBIndexParameters: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IDBIndexParameters>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBIndexParameters(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IDBIndexParameters global::Natrix.JSCore.IJSObjectProxy<IDBIndexParameters>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IDBIndexParameters(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Unique
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "unique");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "unique", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool MultiEntry
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "multiEntry");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "multiEntry", value);
    }
}

#nullable disable