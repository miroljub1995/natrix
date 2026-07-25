// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSPerspective: global::Natrix.StdWeb.CSSTransformComponent
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSPerspective(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSPerspective New(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union> length)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = length.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSPerspective", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSPerspective(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union> Length
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "length");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, string, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "length", value);
    }
}

#nullable disable