// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class QueuingStrategy: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<QueuingStrategy>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public QueuingStrategy(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static QueuingStrategy global::Natrix.JSCore.IJSObjectProxy<QueuingStrategy>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public QueuingStrategy(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double HighWaterMark
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "highWaterMark");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "highWaterMark", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.QueuingStrategySize Size
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.QueuingStrategySize>.Get(JSObject, "size");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.QueuingStrategySize>.Set(JSObject, "size", value);
    }
}

#nullable disable