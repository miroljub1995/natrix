// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class OpenFilePickerOptions: global::Natrix.StdWeb.FilePickerOptions, global::Natrix.JSCore.IJSObjectProxy<OpenFilePickerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OpenFilePickerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static OpenFilePickerOptions global::Natrix.JSCore.IJSObjectProxy<OpenFilePickerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public OpenFilePickerOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Multiple
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "multiple");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "multiple", value);
    }
}

#nullable disable