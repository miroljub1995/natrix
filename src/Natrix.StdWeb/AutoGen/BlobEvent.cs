// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BlobEvent: global::Natrix.StdWeb.Event
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BlobEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.BlobEvent New(string type, global::Natrix.StdWeb.BlobEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "BlobEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.BlobEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Blob Data
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "data");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Timecode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "timecode");
    }
}

#nullable disable