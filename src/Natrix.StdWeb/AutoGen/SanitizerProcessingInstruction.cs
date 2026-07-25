// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SanitizerProcessingInstruction: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SanitizerProcessingInstruction(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SanitizerProcessingInstruction(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Target
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "target");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<string, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "target", value);
    }
}

#nullable disable