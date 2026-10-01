using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class NullableBigIntegerAccessor : IPropertyAccessor<BigInteger?>
{
    [SupportedOSPlatform("browser")]
    public static BigInteger? Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBigIntegerV2AsNullable(propertyName);

    [SupportedOSPlatform("browser")]
    public static BigInteger? Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBigIntegerV2AsNullable(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, BigInteger? value) =>
        obj.SetPropertyAsBigIntegerV2AsNullable(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, BigInteger? value) =>
        obj.SetPropertyAsBigIntegerV2AsNullable(propertyIndex, value);
}
