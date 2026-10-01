// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class SaveFilePickerOptions: global::Natrix.StdWeb.FilePickerOptions, global::Natrix.JSCore.IJSObjectProxy<SaveFilePickerOptions>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SaveFilePickerOptions(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static SaveFilePickerOptions global::Natrix.JSCore.IJSObjectProxy<SaveFilePickerOptions>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public SaveFilePickerOptions(): base()
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? SuggestedName
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "suggestedName");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "suggestedName", value);
    }
}

#nullable disable