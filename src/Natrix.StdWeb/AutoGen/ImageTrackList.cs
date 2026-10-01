// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ImageTrackList: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ImageTrackList>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ImageTrackList(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ImageTrackList global::Natrix.JSCore.IJSObjectProxy<ImageTrackList>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ImageTrackList>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageTrack Get(uint index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallGetter(JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ImageTrack>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Ready
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(JSObject, "ready");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SelectedIndex
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "selectedIndex");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ImageTrack? SelectedTrack
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ImageTrack>.Get(JSObject, "selectedTrack");
    }
}

#nullable disable