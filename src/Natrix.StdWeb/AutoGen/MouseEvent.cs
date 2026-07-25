// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class MouseEvent: global::Natrix.StdWeb.UIEvent
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public MouseEvent(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pageX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double PageY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "pageY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double X
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "x");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double Y
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "y");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double OffsetX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "offsetX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double OffsetY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "offsetY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MovementX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "movementX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double MovementY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<double, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "movementY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MouseEvent New(string type)
    {
        int ___argsArrayLength_3 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MouseEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MouseEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatformAttribute("browser")]
    public static global::Natrix.StdWeb.MouseEvent New(string type, global::Natrix.StdWeb.MouseEventInit eventInitDict)
    {
        int ___argsArrayLength_3 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_3);

        // Argument 1
        string ___marshalledValue_4;
        ___marshalledValue_4 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_4);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = eventInitDict.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::System.Runtime.InteropServices.JavaScript.JSObject ___res_2 = global::Natrix.JSCore.Extensions.JSConstructorExtensions.ConstructObjectNonEmpty(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "MouseEvent", ___argsArray_0.JSObject);
        return new global::Natrix.StdWeb.MouseEvent(___res_2);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScreenX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScreenY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "screenY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "clientY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int LayerX
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "layerX");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int LayerY
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<int, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "layerY");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CtrlKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "ctrlKey");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ShiftKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "shiftKey");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool AltKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "altKey");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool MetaKey
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "metaKey");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public short Button
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<short, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "button");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public ushort Buttons
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<ushort, global::Natrix.StdWeb.PropertyAccessor>(JSObject, "buttons");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventTarget? RelatedTarget
    {
        get => global::Natrix.JSCore.Generics.PropertyAccessor.Get<global::Natrix.StdWeb.EventTarget?, global::Natrix.StdWeb.PropertyAccessorNullable>(JSObject, "relatedTarget");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool GetModifierState(string keyArg)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = keyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getModifierState", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.PropertyAccessor.Get<bool, global::Natrix.StdWeb.PropertyAccessor>(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg)
    {
        int ___argsArrayLength_2 = 4;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg)
    {
        int ___argsArrayLength_2 = 5;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg)
    {
        int ___argsArrayLength_2 = 6;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg)
    {
        int ___argsArrayLength_2 = 7;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg)
    {
        int ___argsArrayLength_2 = 8;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg)
    {
        int ___argsArrayLength_2 = 9;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg)
    {
        int ___argsArrayLength_2 = 10;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        // Argument 10
        bool ___marshalledValue_13;
        ___marshalledValue_13 = ctrlKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 9, ___marshalledValue_13);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg)
    {
        int ___argsArrayLength_2 = 11;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        // Argument 10
        bool ___marshalledValue_13;
        ___marshalledValue_13 = ctrlKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 9, ___marshalledValue_13);

        // Argument 11
        bool ___marshalledValue_14;
        ___marshalledValue_14 = altKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 10, ___marshalledValue_14);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg)
    {
        int ___argsArrayLength_2 = 12;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        // Argument 10
        bool ___marshalledValue_13;
        ___marshalledValue_13 = ctrlKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 9, ___marshalledValue_13);

        // Argument 11
        bool ___marshalledValue_14;
        ___marshalledValue_14 = altKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 10, ___marshalledValue_14);

        // Argument 12
        bool ___marshalledValue_15;
        ___marshalledValue_15 = shiftKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 11, ___marshalledValue_15);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg)
    {
        int ___argsArrayLength_2 = 13;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        // Argument 10
        bool ___marshalledValue_13;
        ___marshalledValue_13 = ctrlKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 9, ___marshalledValue_13);

        // Argument 11
        bool ___marshalledValue_14;
        ___marshalledValue_14 = altKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 10, ___marshalledValue_14);

        // Argument 12
        bool ___marshalledValue_15;
        ___marshalledValue_15 = shiftKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 11, ___marshalledValue_15);

        // Argument 13
        bool ___marshalledValue_16;
        ___marshalledValue_16 = metaKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 12, ___marshalledValue_16);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg)
    {
        int ___argsArrayLength_2 = 14;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        // Argument 10
        bool ___marshalledValue_13;
        ___marshalledValue_13 = ctrlKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 9, ___marshalledValue_13);

        // Argument 11
        bool ___marshalledValue_14;
        ___marshalledValue_14 = altKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 10, ___marshalledValue_14);

        // Argument 12
        bool ___marshalledValue_15;
        ___marshalledValue_15 = shiftKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 11, ___marshalledValue_15);

        // Argument 13
        bool ___marshalledValue_16;
        ___marshalledValue_16 = metaKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 12, ___marshalledValue_16);

        // Argument 14
        double ___marshalledValue_17;
        ___marshalledValue_17 = Convert.ToDouble(buttonArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 13, ___marshalledValue_17);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InitMouseEvent(string typeArg, bool bubblesArg, bool cancelableArg, global::Natrix.StdWeb.Window? viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, short buttonArg, global::Natrix.StdWeb.EventTarget? relatedTargetArg)
    {
        int ___argsArrayLength_2 = 15;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = typeArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = bubblesArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        // Argument 3
        bool ___marshalledValue_5;
        ___marshalledValue_5 = cancelableArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        // Argument 4
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_6;
        if (viewArg is null)
        {
            ___marshalledValue_6 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_7 = (global::Natrix.StdWeb.Window)viewArg;
            ___marshalledValue_6 = ___notNullable_7.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 3, ___marshalledValue_6);

        // Argument 5
        double ___marshalledValue_8;
        ___marshalledValue_8 = Convert.ToDouble(detailArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 4, ___marshalledValue_8);

        // Argument 6
        double ___marshalledValue_9;
        ___marshalledValue_9 = Convert.ToDouble(screenXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 5, ___marshalledValue_9);

        // Argument 7
        double ___marshalledValue_10;
        ___marshalledValue_10 = Convert.ToDouble(screenYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 6, ___marshalledValue_10);

        // Argument 8
        double ___marshalledValue_11;
        ___marshalledValue_11 = Convert.ToDouble(clientXArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 7, ___marshalledValue_11);

        // Argument 9
        double ___marshalledValue_12;
        ___marshalledValue_12 = Convert.ToDouble(clientYArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 8, ___marshalledValue_12);

        // Argument 10
        bool ___marshalledValue_13;
        ___marshalledValue_13 = ctrlKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 9, ___marshalledValue_13);

        // Argument 11
        bool ___marshalledValue_14;
        ___marshalledValue_14 = altKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 10, ___marshalledValue_14);

        // Argument 12
        bool ___marshalledValue_15;
        ___marshalledValue_15 = shiftKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 11, ___marshalledValue_15);

        // Argument 13
        bool ___marshalledValue_16;
        ___marshalledValue_16 = metaKeyArg;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 12, ___marshalledValue_16);

        // Argument 14
        double ___marshalledValue_17;
        ___marshalledValue_17 = Convert.ToDouble(buttonArg);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 13, ___marshalledValue_17);

        // Argument 15
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_18;
        if (relatedTargetArg is null)
        {
            ___marshalledValue_18 = null;
        }
        else
        {
            global::Natrix.StdWeb.EventTarget ___notNullable_19 = (global::Natrix.StdWeb.EventTarget)relatedTargetArg;
            ___marshalledValue_18 = ___notNullable_19.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 14, ___marshalledValue_18);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "initMouseEvent", JSObject, ___argsArray_0.JSObject);
    }
}

#nullable disable