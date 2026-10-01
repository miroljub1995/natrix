// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class IntrinsicSizes: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<IntrinsicSizes>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public IntrinsicSizes(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static IntrinsicSizes global::Natrix.JSCore.IJSObjectProxy<IntrinsicSizes>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<IntrinsicSizes>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MinContentSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "minContentSize");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MaxContentSize
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "maxContentSize");
    }
}

#nullable disable