// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class VideoEncoderEncodeOptionsForAvc: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptionsForAvc(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public VideoEncoderEncodeOptionsForAvc(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort? Quantizer
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "quantizer");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "quantizer", value);
    }
}

#nullable disable