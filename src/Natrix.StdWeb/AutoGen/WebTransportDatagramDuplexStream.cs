// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class WebTransportDatagramDuplexStream: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public WebTransportDatagramDuplexStream(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportDatagramsWritable CreateWritable()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "createWritable", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebTransportDatagramsWritable, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.WebTransportDatagramsWritable CreateWritable(global::Natrix.StdWeb.WebTransportSendOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "createWritable", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.WebTransportDatagramsWritable, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ReadableStream Readable
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "readable");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint MaxDatagramSize
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxDatagramSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? IncomingMaxAge
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "incomingMaxAge");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "incomingMaxAge", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double? OutgoingMaxAge
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "outgoingMaxAge");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "outgoingMaxAge", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint IncomingMaxBufferedDatagrams
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "incomingMaxBufferedDatagrams");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "incomingMaxBufferedDatagrams", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint OutgoingMaxBufferedDatagrams
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "outgoingMaxBufferedDatagrams");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<uint, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "outgoingMaxBufferedDatagrams", value);
    }
}

#nullable disable