// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntrinsicSizesResultOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IntrinsicSizesResultOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntrinsicSizesResultOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IntrinsicSizesResultOptions global::Natrix.JSCore.IJSObjectProxy<IntrinsicSizesResultOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntrinsicSizesResultOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxContentSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maxContentSize");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "maxContentSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinContentSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "minContentSize");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "minContentSize", value);
    }
}

#nullable disable