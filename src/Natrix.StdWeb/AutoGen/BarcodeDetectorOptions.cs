// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class BarcodeDetectorOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<BarcodeDetectorOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BarcodeDetectorOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static BarcodeDetectorOptions global::Natrix.JSCore.IJSObjectProxy<BarcodeDetectorOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public BarcodeDetectorOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BarcodeFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BarcodeFormat>> Formats
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BarcodeFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BarcodeFormat>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BarcodeFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BarcodeFormat>>>>(JSObject, "formats");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BarcodeFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BarcodeFormat>>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.BarcodeFormat, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.BarcodeFormat>>>>(JSObject, "formats", value);
    }
}

#nullable disable