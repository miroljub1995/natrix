// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class StylePropertyMap: global::Natrix.StdWeb.StylePropertyMapReadOnly
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public StylePropertyMap(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Set(string property, params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSStyleValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>[] values)
    {
        int ___argsArrayLength_2 = values.Length + 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = property;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        for (int ___i_4 = 0; ___i_4 < values.Length; ___i_4++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSStyleValue, string, global::Natrix.StdWeb.GenericMarshaller.Union> ___elem_5 = values[___i_4];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = ___elem_5.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1 + ___i_4, ___propObject_6);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "set", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Append(string property, params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSStyleValue, string, global::Natrix.StdWeb.GenericMarshaller.Union>[] values)
    {
        int ___argsArrayLength_2 = values.Length + 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = property;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        for (int ___i_4 = 0; ___i_4 < values.Length; ___i_4++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSStyleValue, string, global::Natrix.StdWeb.GenericMarshaller.Union> ___elem_5 = values[___i_4];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = ___elem_5.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1 + ___i_4, ___propObject_6);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "append", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Delete(string property)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = property;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "delete", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Clear()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "clear", JSObject);
    }
}

#nullable disable