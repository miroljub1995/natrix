// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class PromptResponseObject: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<PromptResponseObject>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PromptResponseObject(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static PromptResponseObject global::Natrix.JSCore.IJSObjectProxy<PromptResponseObject>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public PromptResponseObject(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.AppBannerPromptOutcome UserChoice
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.AppBannerPromptOutcome, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AppBannerPromptOutcome>>(JSObject, "userChoice");
        set => global::Natrix.JSCore.Generics.PropertyAccessor.Set<global::Natrix.StdWeb.AppBannerPromptOutcome, global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.AppBannerPromptOutcome>>(JSObject, "userChoice", value);
    }
}

#nullable disable