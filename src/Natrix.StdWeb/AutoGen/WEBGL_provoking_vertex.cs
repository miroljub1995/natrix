// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WEBGL_provoking_vertex: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WEBGL_provoking_vertex(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    public const uint FIRST_VERTEX_CONVENTION_WEBGL = 0x8E4D;

    public const uint LAST_VERTEX_CONVENTION_WEBGL = 0x8E4E;

    public const uint PROVOKING_VERTEX_WEBGL = 0x8E4F;

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ProvokingVertexWEBGL(uint provokeMode)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(provokeMode);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "provokingVertexWEBGL", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable