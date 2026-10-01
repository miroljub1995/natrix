// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SVGLength: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<SVGLength>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SVGLength(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SVGLength global::Natrix.JSCore.IJSObjectProxy<SVGLength>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<SVGLength>(obj);

    public const ushort SVG_LENGTHTYPE_UNKNOWN = 0;

    public const ushort SVG_LENGTHTYPE_NUMBER = 1;

    public const ushort SVG_LENGTHTYPE_PERCENTAGE = 2;

    public const ushort SVG_LENGTHTYPE_EMS = 3;

    public const ushort SVG_LENGTHTYPE_EXS = 4;

    public const ushort SVG_LENGTHTYPE_PX = 5;

    public const ushort SVG_LENGTHTYPE_CM = 6;

    public const ushort SVG_LENGTHTYPE_MM = 7;

    public const ushort SVG_LENGTHTYPE_IN = 8;

    public const ushort SVG_LENGTHTYPE_PT = 9;

    public const ushort SVG_LENGTHTYPE_PC = 10;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort UnitType
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "unitType");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float Value
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "value");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "value", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public float ValueInSpecifiedUnits
    {
        get => global::Natrix.JSCore.Generics.SingleAccessor.Get(JSObject, "valueInSpecifiedUnits");
        set => global::Natrix.JSCore.Generics.SingleAccessor.Set(JSObject, "valueInSpecifiedUnits", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ValueAsString
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "valueAsString");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "valueAsString", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void NewValueSpecifiedUnits(ushort unitType, float valueInSpecifiedUnits)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(unitType);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = Convert.ToDouble(valueInSpecifiedUnits);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "newValueSpecifiedUnits", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ConvertToSpecifiedUnits(ushort unitType)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(unitType);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "convertToSpecifiedUnits", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable