// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MockCapturePromptResultConfiguration: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<MockCapturePromptResultConfiguration>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MockCapturePromptResultConfiguration(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static MockCapturePromptResultConfiguration global::Natrix.JSCore.IJSObjectProxy<MockCapturePromptResultConfiguration>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MockCapturePromptResultConfiguration(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MockCapturePromptResult GetUserMedia
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MockCapturePromptResult>.Get(JSObject, "getUserMedia");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MockCapturePromptResult>.Set(JSObject, "getUserMedia", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.MockCapturePromptResult GetDisplayMedia
    {
        get => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MockCapturePromptResult>.Get(JSObject, "getDisplayMedia");
        set => global::Natrix.JSCore.Generics.EnumAccessor<global::Natrix.StdWeb.MockCapturePromptResult>.Set(JSObject, "getDisplayMedia", value);
    }
}

#nullable disable