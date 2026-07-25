// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_compressed_texture_astc: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_compressed_texture_astc(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const uint COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;

    public const uint COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;

    public const uint COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;

    public const uint COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;

    public const uint COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;

    public const uint COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;

    public const uint COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;

    public const uint COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;

    public const uint COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;

    public const uint COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;

    public const uint COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;

    public const uint COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;

    public const uint COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;

    public const uint COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;

    public const uint COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> GetSupportedProfiles()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getSupportedProfiles", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }
}

#nullable disable