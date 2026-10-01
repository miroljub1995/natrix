// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImportNodeOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImportNodeOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImportNodeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImportNodeOptions global::Natrix.JSCore.IJSObjectProxy<ImportNodeOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImportNodeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CustomElementRegistry CustomElementRegistry
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CustomElementRegistry>.Get(JSObject, "customElementRegistry");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CustomElementRegistry>.Set(JSObject, "customElementRegistry", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool SelfOnly
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "selfOnly");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "selfOnly", value);
    }
}

#nullable disable