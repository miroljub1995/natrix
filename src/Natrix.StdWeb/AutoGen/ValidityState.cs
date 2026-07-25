// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class ValidityState: global::Natrix.JSCore.JSObjectProxy
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ValidityState(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ValueMissing
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "valueMissing");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TypeMismatch
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "typeMismatch");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool PatternMismatch
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "patternMismatch");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TooLong
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tooLong");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool TooShort
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "tooShort");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RangeUnderflow
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeUnderflow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool RangeOverflow
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "rangeOverflow");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool StepMismatch
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "stepMismatch");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool BadInput
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "badInput");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CustomError
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "customError");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Valid
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "valid");
    }
}

#nullable disable