// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ValidityState: global::Natrix.JSCore.JSObjectProxy, global::Natrix.JSCore.IJSObjectProxy<ValidityState>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ValidityState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ValidityState global::Natrix.JSCore.IJSObjectProxy<ValidityState>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<ValidityState>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ValueMissing
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "valueMissing");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TypeMismatch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "typeMismatch");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PatternMismatch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "patternMismatch");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TooLong
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "tooLong");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TooShort
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "tooShort");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RangeUnderflow
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "rangeUnderflow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RangeOverflow
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "rangeOverflow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool StepMismatch
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "stepMismatch");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BadInput
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "badInput");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CustomError
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "customError");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Valid
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "valid");
    }
}

#nullable disable