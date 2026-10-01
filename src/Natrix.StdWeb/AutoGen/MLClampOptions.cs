// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLClampOptions: global::Natrix.StdWeb.MLOperatorOptions, global::Natrix.JSCore.IJSObjectProxy<MLClampOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLClampOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLClampOptions global::Natrix.JSCore.IJSObjectProxy<MLClampOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLClampOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor> MinValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "minValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "minValue", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor> MaxValue
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "maxValue");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>, global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::System.Numerics.BigInteger, double, global::Natrix.JSCore.Generics.BigIntegerAccessor, global::Natrix.JSCore.Generics.DoubleAccessor>>>(JSObject, "maxValue", value);
    }
}

#nullable disable