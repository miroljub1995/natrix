// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HIDReportItem: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDReportItem(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HIDReportItem(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsAbsolute
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isAbsolute");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isAbsolute", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsArray
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isArray");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isArray", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsBufferedBytes
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isBufferedBytes");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isBufferedBytes", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsConstant
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isConstant");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isConstant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsLinear
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isLinear");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isLinear", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsRange
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isRange");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isRange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool IsVolatile
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isVolatile");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "isVolatile", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasNull
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hasNull");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hasNull", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasPreferredState
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hasPreferredState");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "hasPreferredState", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Wrap
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "wrap");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "wrap", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor> Usages
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usages");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usages", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UsageMinimum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usageMinimum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usageMinimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint UsageMaximum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usageMaximum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "usageMaximum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReportSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reportSize");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reportSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort ReportCount
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reportCount");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "reportCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HIDUnitSystem UnitSystem
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.HIDUnitSystem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitSystem");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.HIDUnitSystem, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitSystem", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorLengthExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorLengthExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorLengthExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorMassExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorMassExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorMassExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorTimeExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorTimeExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorTimeExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorTemperatureExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorTemperatureExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorTemperatureExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorCurrentExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorCurrentExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorCurrentExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public sbyte UnitFactorLuminousIntensityExponent
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorLuminousIntensityExponent");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<sbyte, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "unitFactorLuminousIntensityExponent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int LogicalMinimum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalMinimum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalMinimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int LogicalMaximum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalMaximum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "logicalMaximum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PhysicalMinimum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "physicalMinimum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "physicalMinimum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int PhysicalMaximum
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "physicalMaximum");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "physicalMaximum", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> Strings
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "strings");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "strings", value);
    }
}

#nullable disable