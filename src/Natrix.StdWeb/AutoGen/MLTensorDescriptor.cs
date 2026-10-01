// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MLTensorDescriptor: global::Natrix.StdWeb.MLOperandDescriptor, global::Natrix.JSCore.IJSObjectProxy<MLTensorDescriptor>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTensorDescriptor(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MLTensorDescriptor global::Natrix.JSCore.IJSObjectProxy<MLTensorDescriptor>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MLTensorDescriptor(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Readable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "readable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "readable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Writable
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "writable");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "writable", value);
    }
}

#nullable disable