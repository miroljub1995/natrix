// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class CSSFontFeatureValuesMap: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<CSSFontFeatureValuesMap>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public CSSFontFeatureValuesMap(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static CSSFontFeatureValuesMap global::Natrix.JSCore.IJSObjectProxy<CSSFontFeatureValuesMap>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<CSSFontFeatureValuesMap>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Set(string featureValueName, global::Natrix.JSCore.Generics.Union<uint, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>, global::Natrix.JSCore.Generics.UInt32Accessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>> values)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = featureValueName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = values.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "set", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable