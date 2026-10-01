// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class DocumentTimelineOptions: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<DocumentTimelineOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentTimelineOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static DocumentTimelineOptions global::Natrix.JSCore.IJSObjectProxy<DocumentTimelineOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public DocumentTimelineOptions(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double OriginTime
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "originTime");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "originTime", value);
    }
}

#nullable disable