// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ValidityStateFlags: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ValidityStateFlags>
{
#pragma warning disable CS8618 // When constructing using obj, we assume that all members are initialized.
    [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ValidityStateFlags(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }
#pragma warning restore CS8618

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ValidityStateFlags global::Natrix.JSCore.IJSObjectProxy<ValidityStateFlags>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        new(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ValidityStateFlags(): base(global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object"))
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ValueMissing
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "valueMissing");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "valueMissing", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TypeMismatch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "typeMismatch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "typeMismatch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PatternMismatch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "patternMismatch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "patternMismatch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TooLong
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "tooLong");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "tooLong", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TooShort
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "tooShort");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "tooShort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RangeUnderflow
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "rangeUnderflow");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "rangeUnderflow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RangeOverflow
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "rangeOverflow");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "rangeOverflow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool StepMismatch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "stepMismatch");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "stepMismatch", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BadInput
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "badInput");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "badInput", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CustomError
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "customError");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "customError", value);
    }
}

#nullable disable