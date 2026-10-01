// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class QueuingStrategyInit: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<QueuingStrategyInit>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public QueuingStrategyInit(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static QueuingStrategyInit global::Natrix.JSCore.IJSObjectProxy<QueuingStrategyInit>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public QueuingStrategyInit(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double HighWaterMark
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "highWaterMark");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "highWaterMark", value);
    }
}

#nullable disable