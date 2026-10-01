// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSNumericType: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CSSNumericType>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSNumericType(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSNumericType global::Natrix.JSCore.IJSObjectProxy<CSSNumericType>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSNumericType(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Length
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "length", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Angle
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "angle");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "angle", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Time
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "time");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "time", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Frequency
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "frequency");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "frequency", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Resolution
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "resolution");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "resolution", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Flex
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "flex");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "flex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int Percent
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "percent");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "percent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSNumericBaseType PercentHint
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSNumericBaseType>.Get(JSObject, "percentHint");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CSSNumericBaseType>.Set(JSObject, "percentHint", value);
    }
}

#nullable disable