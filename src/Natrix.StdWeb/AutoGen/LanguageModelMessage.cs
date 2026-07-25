// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelMessage: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelMessage(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelMessage(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.StdWeb.LanguageModelMessageRole Role
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.LanguageModelMessageRole, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "role");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.LanguageModelMessageRole, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "role", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> Content
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "content");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "content", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Prefix
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prefix");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "prefix", value);
    }
}

#nullable disable