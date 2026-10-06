// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ToolAnnotations: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ToolAnnotations>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ToolAnnotations(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ToolAnnotations global::Natrix.JSCore.IJSObjectProxy<ToolAnnotations>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ToolAnnotations(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ReadOnlyHint
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "readOnlyHint");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "readOnlyHint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool UntrustedContentHint
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "untrustedContentHint");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "untrustedContentHint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ConsequentialHint
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "consequentialHint");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "consequentialHint", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Debugging
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "debugging");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "debugging", value);
    }
}

#nullable disable