using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace Natrix.JSCore.Generics;

public partial class Promise<T, TPropertyAccessor> : JSObjectProxy
    where TPropertyAccessor : IPropertyAccessor<T>
{
    [SupportedOSPlatform("browser")]
    public Promise(JSObject obj) : base(obj)
    {
    }

    [JSImport("construct", "natrix")]
    private static partial JSObject ConstructObject(JSObject obj, string constructorName);

    [JSImport("wrapPromiseValue", "natrix")]
    private static partial Task<JSObject> WrapPromiseValue(JSObject obj);

    [JSImport("unwrapPromiseValue", "natrix")]
    private static partial JSObject UnwrapPromiseValue(Task<JSObject> task);

    [SupportedOSPlatform("browser")]
    public static implicit operator Task<T>(Promise<T, TPropertyAccessor> promise) => ToManaged(promise.JSObject);

    [SupportedOSPlatform("browser")]
    public static implicit operator Promise<T, TPropertyAccessor>(Task<T> task) => new(ToJS(task));

    public TaskAwaiter<T> GetAwaiter() => ((Task<T>)this).GetAwaiter();

    [SupportedOSPlatform("browser")]
    private static Task<T> ToManaged(JSObject input) =>
        WrapPromiseValue(input)
            .ContinueWith(
                static task =>
                {
                    var res = TPropertyAccessor.Get(task.Result, "value");
                    task.Result.Dispose();
                    return res;
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

    [SupportedOSPlatform("browser")]
    static JSObject ToJS(Task<T> input)
    {
        var wrappedPromiseValue = input
            .ContinueWith(
                static task =>
                {
                    var wrapperObject = ConstructObject(JSHost.GlobalThis, "Object");
                    var res = task.Result;
                    TPropertyAccessor.Set(wrapperObject, "value", res);
                    return wrapperObject;
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

        return UnwrapPromiseValue(wrappedPromiseValue);
    }
}