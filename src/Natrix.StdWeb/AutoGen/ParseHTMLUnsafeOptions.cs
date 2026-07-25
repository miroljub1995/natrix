// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ParseHTMLUnsafeOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ParseHTMLUnsafeOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ParseHTMLUnsafeOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.StdWeb.GenericMarshaller.Union> Sanitizer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sanitizer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Sanitizer, global::Natrix.StdWeb.SanitizerConfig, global::Natrix.StdWeb.SanitizerPresets, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "sanitizer", value);
    }
}

#nullable disable