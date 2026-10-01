// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class HTMLOptionsCollection: global::Natrix.StdWeb.HTMLCollection, global::Natrix.JSCore.IJSObjectProxy<HTMLOptionsCollection>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public HTMLOptionsCollection(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static HTMLOptionsCollection global::Natrix.JSCore.IJSObjectProxy<HTMLOptionsCollection>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<HTMLOptionsCollection>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint Length
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "length");
        set => global::Natrix.JSCore.Generics.UInt32Accessor.Set(JSObject, "length", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Set(uint index, global::Natrix.StdWeb.HTMLOptionElement? option)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_4;
        if (option is null)
        {
            ___marshalledValue_4 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLOptionElement ___notNullable_5 = (global::Natrix.StdWeb.HTMLOptionElement)option;
            ___marshalledValue_4 = ___notNullable_5.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallSetter(JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Add(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLOptionElement, global::Natrix.StdWeb.HTMLOptGroupElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptionElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptGroupElement>> element)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = element.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "add", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Add(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLOptionElement, global::Natrix.StdWeb.HTMLOptGroupElement, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptionElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLOptGroupElement>> element, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLElement, int, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLElement>, global::Natrix.JSCore.Generics.Int32Accessor>? before)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = element.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_4;
        if (before is null)
        {
            ___propObject_4 = null;
        }
        else
        {
            ___propObject_4 = before.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(___argsArray_0.JSObject, 1, ___propObject_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "add", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Remove(int index)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(index);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "remove", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int SelectedIndex
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "selectedIndex");
        set => global::Natrix.JSCore.Generics.Int32Accessor.Set(JSObject, "selectedIndex", value);
    }
}

#nullable disable