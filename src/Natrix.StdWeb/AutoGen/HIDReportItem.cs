// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDReportItem: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<HIDReportItem>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDReportItem(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HIDReportItem global::Natrix.JSCore.IJSObjectProxy<HIDReportItem>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDReportItem(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsAbsolute
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isAbsolute");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isAbsolute", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsArray
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isArray");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isArray", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsBufferedBytes
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isBufferedBytes");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isBufferedBytes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsConstant
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isConstant");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isConstant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsLinear
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isLinear");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsRange
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isRange");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isRange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsVolatile
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "isVolatile");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "isVolatile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasNull
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasNull");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hasNull", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasPreferredState
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "hasPreferredState");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "hasPreferredState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Wrap
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "wrap");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "wrap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor> Usages
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Get(JSObject, "usages");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.JSCore.Generics.UInt32Accessor>>.Set(JSObject, "usages", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UsageMinimum
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "usageMinimum");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "usageMinimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UsageMaximum
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "usageMaximum");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "usageMaximum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReportSize
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "reportSize");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "reportSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReportCount
    {
        get => global::Natrix.JSCore.Generics.UInt16Accessor.Get(JSObject, "reportCount");
        set => global::Natrix.JSCore.Generics.UInt16Accessor.Set(JSObject, "reportCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HIDUnitSystem UnitSystem
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HIDUnitSystem>.Get(JSObject, "unitSystem");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.HIDUnitSystem>.Set(JSObject, "unitSystem", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorLengthExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitFactorLengthExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitFactorLengthExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorMassExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitFactorMassExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitFactorMassExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorTimeExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitFactorTimeExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitFactorTimeExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorTemperatureExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitFactorTemperatureExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitFactorTemperatureExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorCurrentExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitFactorCurrentExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitFactorCurrentExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorLuminousIntensityExponent
    {
        get => global::Natrix.JSCore.Generics.SByteAccessor.Get(JSObject, "unitFactorLuminousIntensityExponent");
        set => global::Natrix.JSCore.Generics.SByteAccessor.Set(JSObject, "unitFactorLuminousIntensityExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int LogicalMinimum
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "logicalMinimum");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "logicalMinimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int LogicalMaximum
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "logicalMaximum");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "logicalMaximum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PhysicalMinimum
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "physicalMinimum");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "physicalMinimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PhysicalMaximum
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "physicalMaximum");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "physicalMaximum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> Strings
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "strings");
        set => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "strings", value);
    }
}

#nullable disable