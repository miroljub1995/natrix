// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class FaceDetectorOptions: global::Natrix.JSCore.JSObjectProxy
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FaceDetectorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public FaceDetectorOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort MaxDetectedFaces
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxDetectedFaces");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "maxDetectedFaces", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool FastMode
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fastMode");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "fastMode", value);
    }
}

#nullable disable