// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SanitizerElementNamespace: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SanitizerElementNamespace>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SanitizerElementNamespace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SanitizerElementNamespace global::Natrix.JSCore.IJSObjectProxy<SanitizerElementNamespace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SanitizerElementNamespace(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Name
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "name");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "name", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Namespace
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "namespace");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "namespace", value);
    }
}

#nullable disable