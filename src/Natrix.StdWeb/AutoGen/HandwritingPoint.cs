// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HandwritingPoint: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HandwritingPoint>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingPoint(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HandwritingPoint global::Natrix.JSCore.IJSObjectProxy<HandwritingPoint>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HandwritingPoint(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double X
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "x");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "x", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Y
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "y");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "y", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double T
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "t");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "t", value);
    }
}

#nullable disable