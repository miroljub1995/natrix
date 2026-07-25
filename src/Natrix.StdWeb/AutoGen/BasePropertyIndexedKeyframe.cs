// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BasePropertyIndexedKeyframe: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BasePropertyIndexedKeyframe(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BasePropertyIndexedKeyframe(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? Offset
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "offset");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "offset", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> Easing
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "easing");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "easing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union> Composite
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "composite");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "composite", value);
    }
}

#nullable disable