// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BaseComputedKeyframe: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BaseComputedKeyframe>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BaseComputedKeyframe(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BaseComputedKeyframe global::Natrix.JSCore.IJSObjectProxy<BaseComputedKeyframe>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BaseComputedKeyframe(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? Offset
    {
        get => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Get(JSObject, "offset");
        set => global::Natrix.JSCore.Generics.NullableDoubleAccessor.Set(JSObject, "offset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ComputedOffset
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "computedOffset");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "computedOffset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Easing
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "easing");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "easing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CompositeOperationOrAuto Composite
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>.Get(JSObject, "composite");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.CompositeOperationOrAuto>.Set(JSObject, "composite", value);
    }
}

#nullable disable