// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class LanguageModelAppendOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelAppendOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public LanguageModelAppendOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AbortSignal Signal
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AbortSignal, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "signal");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AbortSignal, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "signal", value);
    }
}

#nullable disable