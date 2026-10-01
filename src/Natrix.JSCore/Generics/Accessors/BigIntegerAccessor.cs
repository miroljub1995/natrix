using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.JSCore.Extensions;

namespace Natrix.JSCore.Generics;

public sealed class BigIntegerAccessor : IUnionMemberAccessor<BigInteger>
{
    public static bool CanRead(JSValueKind kind) => kind == JSValueKind.BigInt;

    [SupportedOSPlatform("browser")]
    public static BigInteger Get(JSObject obj, string propertyName) =>
        obj.GetPropertyAsBigIntegerV2(propertyName);

    [SupportedOSPlatform("browser")]
    public static BigInteger Get(JSObject obj, int propertyIndex) =>
        obj.GetPropertyAsBigIntegerV2(propertyIndex);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, string propertyName, BigInteger value) =>
        obj.SetPropertyAsBigIntegerV2(propertyName, value);

    [SupportedOSPlatform("browser")]
    public static void Set(JSObject obj, int propertyIndex, BigInteger value) =>
        obj.SetPropertyAsBigIntegerV2(propertyIndex, value);
}
