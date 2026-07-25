// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLWhereSupportLimits: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLWhereSupportLimits(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLWhereSupportLimits(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Condition
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "condition");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "condition", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits TrueValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "trueValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "trueValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits FalseValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "falseValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "falseValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MLTensorLimits Output
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "output");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.MLTensorLimits, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "output", value);
    }
}

#nullable disable