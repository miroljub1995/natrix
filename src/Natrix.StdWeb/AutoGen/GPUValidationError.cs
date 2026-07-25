// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUValidationError: global::Natrix.StdWeb.GPUError
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUValidationError(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.GPUValidationError New(string message)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = message;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "GPUValidationError", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.GPUValidationError(___res_2);
    }
}

#nullable disable