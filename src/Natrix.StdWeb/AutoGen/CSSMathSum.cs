// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSMathSum: global::Natrix.StdWeb.CSSMathValue
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSMathSum(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.CSSMathSum New(params global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>[] args)
    {
        int ___argsArrayLength_3 = args.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        for (int ___i_4 = 0; ___i_4 < args.Length; ___i_4++)
        {
        global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union> ___elem_5 = args[___i_4];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = ___elem_5.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_4, ___propObject_6);
        }

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "CSSMathSum", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.CSSMathSum(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSNumericArray Values
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.CSSNumericArray, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "values");
    }
}

#nullable disable