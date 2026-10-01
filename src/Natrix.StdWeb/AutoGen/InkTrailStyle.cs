// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class InkTrailStyle: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<InkTrailStyle>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InkTrailStyle(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static InkTrailStyle global::Natrix.JSCore.IJSObjectProxy<InkTrailStyle>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public InkTrailStyle(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required string Color
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "color");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "color", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double Diameter
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "diameter");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "diameter", value);
    }
}

#nullable disable