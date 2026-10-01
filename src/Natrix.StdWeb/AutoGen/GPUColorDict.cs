// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class GPUColorDict: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<GPUColorDict>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUColorDict(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static GPUColorDict global::Natrix.JSCore.IJSObjectProxy<GPUColorDict>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public GPUColorDict(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double R
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "r");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "r", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double G
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "g");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "g", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double B
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "b");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "b", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public required double A
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "a");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "a", value);
    }
}

#nullable disable