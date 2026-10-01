// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SanitizerAttributeNamespace: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SanitizerAttributeNamespace>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SanitizerAttributeNamespace(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SanitizerAttributeNamespace global::Natrix.JSCore.IJSObjectProxy<SanitizerAttributeNamespace>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SanitizerAttributeNamespace(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
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