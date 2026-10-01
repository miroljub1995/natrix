// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public partial class Element: global::Natrix.StdWeb.Node, global::Natrix.JSCore.IJSObjectProxy<Element>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public Element(global::System.Runtime.InteropServices.JavaScript.JSObject obj): base(obj)
    {
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static Element global::Natrix.JSCore.IJSObjectProxy<Element>.Create(global::System.Runtime.InteropServices.JavaScript.JSObject obj) =>
        global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<Element>(obj);

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ContainerTiming
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "containerTiming");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "containerTiming", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ContainerTimingIgnore
    {
        get => global::Natrix.JSCore.Generics.BooleanAccessor.Get(JSObject, "containerTimingIgnore");
        set => global::Natrix.JSCore.Generics.BooleanAccessor.Set(JSObject, "containerTimingIgnore", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node GetSpatialNavigationContainer()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getSpatialNavigationContainer", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>> FocusableAreas()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "focusableAreas", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>> FocusableAreas(global::Natrix.StdWeb.FocusableAreasOption option)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = option.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "focusableAreas", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? SpatialNavigationSearch(global::Natrix.StdWeb.SpatialNavigationDirection dir)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = dir.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "spatialNavigationSearch", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Node? SpatialNavigationSearch(global::Natrix.StdWeb.SpatialNavigationDirection dir, global::Natrix.StdWeb.SpatialNavigationSearchOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = dir.ToString();
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "spatialNavigationSearch", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Node>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CSSPseudoElement? Pseudo(string type)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = type;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "pseudo", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList Part
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "part");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.StylePropertyMapReadOnly ComputedStyleMap()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "computedStyleMap", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StylePropertyMapReadOnly>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ViewTransition StartViewTransition()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "startViewTransition", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ViewTransition>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ViewTransition StartViewTransition(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ViewTransitionUpdateCallback, global::Natrix.StdWeb.StartViewTransitionOptions, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ViewTransitionUpdateCallback>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.StartViewTransitionOptions>> callbackOptions)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = callbackOptions.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "startViewTransition", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ViewTransition>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ViewTransition? ActiveViewTransition
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ViewTransition>.Get(JSObject, "activeViewTransition");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRectList GetClientRects()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getClientRects", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRectList>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMRect GetBoundingClientRect()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getBoundingClientRect", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMRect>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CheckVisibility()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "checkVisibility", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool CheckVisibility(global::Natrix.StdWeb.CheckVisibilityOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "checkVisibility", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollIntoView()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "scrollIntoView", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollIntoView(global::Natrix.JSCore.Generics.Union<bool, global::Natrix.StdWeb.ScrollIntoViewOptions, global::Natrix.JSCore.Generics.BooleanAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ScrollIntoViewOptions>> arg)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = arg.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scrollIntoView", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Scroll()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "scroll", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Scroll(global::Natrix.StdWeb.ScrollToOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scroll", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise Scroll(double x, double y)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = x;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = y;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scroll", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollTo()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "scrollTo", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollTo(global::Natrix.StdWeb.ScrollToOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scrollTo", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollTo(double x, double y)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = x;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = y;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scrollTo", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollBy()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "scrollBy", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollBy(global::Natrix.StdWeb.ScrollToOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scrollBy", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise ScrollBy(double x, double y)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = x;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        double ___marshalledValue_4;
        ___marshalledValue_4 = y;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "scrollBy", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScrollTop
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "scrollTop");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "scrollTop", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double ScrollLeft
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "scrollLeft");
        set => global::Natrix.JSCore.Generics.DoubleAccessor.Set(JSObject, "scrollLeft", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScrollWidth
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "scrollWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ScrollHeight
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "scrollHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientTop
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "clientTop");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientLeft
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "clientLeft");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientWidth
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "clientWidth");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public int ClientHeight
    {
        get => global::Natrix.JSCore.Generics.Int32Accessor.Get(JSObject, "clientHeight");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public double CurrentCSSZoom
    {
        get => global::Natrix.JSCore.Generics.DoubleAccessor.Get(JSObject, "currentCSSZoom");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? NamespaceURI
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "namespaceURI");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Prefix
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "prefix");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string LocalName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "localName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string TagName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "tagName");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Id
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "id");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "id", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ClassName
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "className");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "className", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMTokenList ClassList
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMTokenList>.Get(JSObject, "classList");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string Slot
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "slot");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "slot", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasAttributes()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "hasAttributes", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NamedNodeMap Attributes
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NamedNodeMap>.Get(JSObject, "attributes");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor> GetAttributeNames()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getAttributeNames", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.JSCore.Generics.StringAccessor>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? GetAttribute(string qualifiedName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getAttribute", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableStringAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? GetAttributeNS(string? @namespace, string localName)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (@namespace is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)@namespace;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = localName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getAttributeNS", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableStringAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetAttribute(string qualifiedName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, global::Natrix.StdWeb.TrustedScript, global::Natrix.StdWeb.TrustedScriptURL, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScript>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>, global::Natrix.JSCore.Generics.StringAccessor> value)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setAttribute", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetAttributeNS(string? @namespace, string qualifiedName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, global::Natrix.StdWeb.TrustedScript, global::Natrix.StdWeb.TrustedScriptURL, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScript>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedScriptURL>, global::Natrix.JSCore.Generics.StringAccessor> value)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (@namespace is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)@namespace;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_6 = value.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 2, ___propObject_6);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setAttributeNS", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RemoveAttribute(string qualifiedName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "removeAttribute", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void RemoveAttributeNS(string? @namespace, string localName)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (@namespace is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)@namespace;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = localName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "removeAttributeNS", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ToggleAttribute(string qualifiedName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "toggleAttribute", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool ToggleAttribute(string qualifiedName, bool force)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        bool ___marshalledValue_4;
        ___marshalledValue_4 = force;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "toggleAttribute", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasAttribute(string qualifiedName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "hasAttribute", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasAttributeNS(string? @namespace, string localName)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (@namespace is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)@namespace;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = localName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "hasAttributeNS", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Attr? GetAttributeNode(string qualifiedName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getAttributeNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Attr>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Attr? GetAttributeNodeNS(string? @namespace, string localName)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (@namespace is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)@namespace;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = localName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getAttributeNodeNS", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Attr>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Attr? SetAttributeNode(global::Natrix.StdWeb.Attr attr)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = attr.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "setAttributeNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Attr>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Attr? SetAttributeNodeNS(global::Natrix.StdWeb.Attr attr)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = attr.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "setAttributeNodeNS", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Attr>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Attr RemoveAttributeNode(global::Natrix.StdWeb.Attr attr)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = attr.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "removeAttributeNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Attr>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ShadowRoot AttachShadow(global::Natrix.StdWeb.ShadowRootInit init)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = init.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "attachShadow", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.ShadowRoot>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.ShadowRoot? ShadowRoot
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.ShadowRoot>.Get(JSObject, "shadowRoot");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.CustomElementRegistry? CustomElementRegistry
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.CustomElementRegistry>.Get(JSObject, "customElementRegistry");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? Closest(string selectors)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = selectors;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "closest", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool Matches(string selectors)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = selectors;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "matches", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool WebkitMatchesSelector(string selectors)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = selectors;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "webkitMatchesSelector", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCollection GetElementsByTagName(string qualifiedName)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = qualifiedName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getElementsByTagName", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCollection>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCollection GetElementsByTagNameNS(string? @namespace, string localName)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string? ___marshalledValue_3;
        if (@namespace is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            string ___notNullable_4 = (string)@namespace;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_5;
        ___marshalledValue_5 = localName;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getElementsByTagNameNS", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCollection>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCollection GetElementsByClassName(string classNames)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = classNames;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getElementsByClassName", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCollection>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? InsertAdjacentElement(string where, global::Natrix.StdWeb.Element element)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = where;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = element.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "insertAdjacentElement", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InsertAdjacentText(string where, string data)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = where;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        string ___marshalledValue_4;
        ___marshalledValue_4 = data;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "insertAdjacentText", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string ElementTiming
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "elementTiming");
        set => global::Natrix.JSCore.Generics.StringAccessor.Set(JSObject, "elementTiming", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise RequestFullscreen()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "requestFullscreen", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise RequestFullscreen(global::Natrix.StdWeb.FullscreenOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "requestFullscreen", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onfullscreenchange
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onfullscreenchange");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onfullscreenchange", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.EventHandlerNonNull? Onfullscreenerror
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Get(JSObject, "onfullscreenerror");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.EventHandlerNonNull>.Set(JSObject, "onfullscreenerror", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetHTML(string html)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = html;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setHTML", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetHTML(string html, global::Natrix.StdWeb.SetHTMLOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = html;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setHTML", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetHTMLUnsafe(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> html)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = html.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setHTMLUnsafe", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetHTMLUnsafe(global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> html, global::Natrix.StdWeb.SetHTMLUnsafeOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_3 = html.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0, ___propObject_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setHTMLUnsafe", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GetHTML()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getHTML", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.StringAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string GetHTML(global::Natrix.StdWeb.GetHTMLOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getHTML", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.StringAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> InnerHTML
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "innerHTML");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "innerHTML", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> OuterHTML
    {
        get => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor>>.Get(JSObject, "outerHTML");
        set => global::Natrix.JSCore.Generics.UnionAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor>>.Set(JSObject, "outerHTML", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void InsertAdjacentHTML(string position, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.TrustedHTML, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.TrustedHTML>, global::Natrix.JSCore.Generics.StringAccessor> @string)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = position;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = @string.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "insertAdjacentHTML", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void SetPointerCapture(int pointerId)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(pointerId);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "setPointerCapture", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ReleasePointerCapture(int pointerId)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(pointerId);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "releasePointerCapture", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public bool HasPointerCapture(int pointerId)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        double ___marshalledValue_3;
        ___marshalledValue_3 = Convert.ToDouble(pointerId);
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "hasPointerCapture", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.BooleanAccessor.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise RequestPointerLock()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "requestPointerLock", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Promise RequestPointerLock(global::Natrix.StdWeb.PointerLockOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "requestPointerLock", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Promise>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string RegionOverset
    {
        get => global::Natrix.JSCore.Generics.StringAccessor.Get(JSObject, "regionOverset");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Range>>? GetRegionFlowRanges()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getRegionFlowRanges", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Range>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DOMQuad, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>> GetBoxQuads()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getBoxQuads", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DOMQuad, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DOMQuad, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>> GetBoxQuads(global::Natrix.StdWeb.BoxQuadOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getBoxQuads", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.DOMQuad, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMQuad ConvertQuadFromNode(global::Natrix.StdWeb.DOMQuadInit quad, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> from)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = quad.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = from.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertQuadFromNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMQuad ConvertQuadFromNode(global::Natrix.StdWeb.DOMQuadInit quad, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> from, global::Natrix.StdWeb.ConvertCoordinateOptions options)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = quad.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = from.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertQuadFromNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMQuad ConvertRectFromNode(global::Natrix.StdWeb.DOMRectReadOnly rect, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> from)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = rect.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = from.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertRectFromNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMQuad ConvertRectFromNode(global::Natrix.StdWeb.DOMRectReadOnly rect, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> from, global::Natrix.StdWeb.ConvertCoordinateOptions options)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = rect.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = from.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertRectFromNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMQuad>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPoint ConvertPointFromNode(global::Natrix.StdWeb.DOMPointInit point, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> from)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = point.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = from.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertPointFromNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPoint>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.DOMPoint ConvertPointFromNode(global::Natrix.StdWeb.DOMPointInit point, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Text, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.CSSPseudoElement, global::Natrix.StdWeb.Document, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Text>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.CSSPseudoElement>, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Document>> from, global::Natrix.StdWeb.ConvertCoordinateOptions options)
    {
        int ___argsArrayLength_2 = 3;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = point.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_4 = from.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_4);

        // Argument 3
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_5;
        ___marshalledValue_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 2, ___marshalledValue_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "convertPointFromNode", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.DOMPoint>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLCollection Children
    {
        get => global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.HTMLCollection>.Get(JSObject, "children");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? FirstElementChild
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "firstElementChild");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? LastElementChild
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "lastElementChild");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public uint ChildElementCount
    {
        get => global::Natrix.JSCore.Generics.UInt32Accessor.Get(JSObject, "childElementCount");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Prepend(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "prepend", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Append(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "append", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ReplaceChildren(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "replaceChildren", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void MoveBefore(global::Natrix.StdWeb.Node node, global::Natrix.StdWeb.Node? child)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = node.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_4;
        if (child is null)
        {
            ___marshalledValue_4 = null;
        }
        else
        {
            global::Natrix.StdWeb.Node ___notNullable_5 = (global::Natrix.StdWeb.Node)child;
            ___marshalledValue_4 = ___notNullable_5.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "moveBefore", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? QuerySelector(string selectors)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = selectors;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "querySelector", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.NodeList QuerySelectorAll(string selectors)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = selectors;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "querySelectorAll", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.NodeList>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? PreviousElementSibling
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "previousElementSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? NextElementSibling
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "nextElementSibling");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Before(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "before", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void After(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "after", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void ReplaceWith(params global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor>[] nodes)
    {
        int ___argsArrayLength_2 = nodes.Length + 0;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        for (int ___i_3 = 0; ___i_3 < nodes.Length; ___i_3++)
        {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Node, string, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Node>, global::Natrix.JSCore.Generics.StringAccessor> ___elem_4 = nodes[___i_3];
            global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = ___elem_4.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 0 + ___i_3, ___propObject_5);
        }

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "replaceWith", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void Remove()
    {
        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyVoidFunctionProperty(JSObject, "remove", JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.HTMLSlotElement? AssignedSlot
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.HTMLSlotElement>.Get(JSObject, "assignedSlot");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? Role
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "role");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "role", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Element? AriaActiveDescendantElement
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Get(JSObject, "ariaActiveDescendantElement");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.StdWeb.Element>.Set(JSObject, "ariaActiveDescendantElement", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaAtomic
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaAtomic");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaAtomic", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaAutoComplete
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaAutoComplete");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaAutoComplete", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBrailleLabel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaBrailleLabel");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaBrailleLabel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBrailleRoleDescription
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaBrailleRoleDescription");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaBrailleRoleDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaBusy
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaBusy");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaBusy", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaChecked
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaChecked");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaChecked", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColCount
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColCount");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColIndex
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColIndex");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColIndexText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColIndexText");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColIndexText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaColSpan
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaColSpan");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaColSpan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaControlsElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaControlsElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaControlsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaCurrent
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaCurrent");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaCurrent", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaDescribedByElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaDescribedByElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaDescribedByElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaDescription
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaDescription");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaDetailsElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaDetailsElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaDetailsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaDisabled
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaDisabled");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaDisabled", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaErrorMessageElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaErrorMessageElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaErrorMessageElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaExpanded
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaExpanded");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaExpanded", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaFlowToElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaFlowToElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaFlowToElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaHasPopup
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaHasPopup");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaHasPopup", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaHidden
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaHidden");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaHidden", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaInvalid
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaInvalid");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaInvalid", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaKeyShortcuts
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaKeyShortcuts");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaKeyShortcuts", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLabel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaLabel");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaLabel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaLabelledByElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaLabelledByElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaLabelledByElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLevel
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaLevel");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaLevel", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaLive
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaLive");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaLive", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaModal
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaModal");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaModal", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaMultiLine
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaMultiLine");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaMultiLine", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaMultiSelectable
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaMultiSelectable");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaMultiSelectable", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaOrientation
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaOrientation");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaOrientation", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>? AriaOwnsElements
    {
        get => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Get(JSObject, "ariaOwnsElements");
        set => global::Natrix.JSCore.Generics.NullableProxyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Element>>>.Set(JSObject, "ariaOwnsElements", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPlaceholder
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaPlaceholder");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaPlaceholder", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPosInSet
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaPosInSet");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaPosInSet", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaPressed
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaPressed");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaPressed", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaReadOnly
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaReadOnly");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaReadOnly", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRelevant
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRelevant");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRelevant", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRequired
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRequired");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRequired", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRoleDescription
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRoleDescription");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRoleDescription", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowCount
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowCount");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowCount", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowIndex
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowIndex");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowIndex", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowIndexText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowIndexText");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowIndexText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaRowSpan
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaRowSpan");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaRowSpan", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSelected
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaSelected");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaSelected", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSetSize
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaSetSize");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaSetSize", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaSort
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaSort");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaSort", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueMax
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueMax");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueMax", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueMin
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueMin");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueMin", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueNow
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueNow");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueNow", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public string? AriaValueText
    {
        get => global::Natrix.JSCore.Generics.NullableStringAccessor.Get(JSObject, "ariaValueText");
        set => global::Natrix.JSCore.Generics.NullableStringAccessor.Set(JSObject, "ariaValueText", value);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void AriaNotify(string announcement)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = announcement;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "ariaNotify", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public void AriaNotify(string announcement, global::Natrix.StdWeb.AriaNotificationOptions options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        string ___marshalledValue_3;
        ___marshalledValue_3 = announcement;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_4;
        ___marshalledValue_4 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 1, ___marshalledValue_4);

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyVoidFunctionProperty(JSObject, "ariaNotify", JSObject, ___argsArray_0.JSObject);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Animation Animate(global::System.Runtime.InteropServices.JavaScript.JSObject? keyframes)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (keyframes is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_4 = (global::System.Runtime.InteropServices.JavaScript.JSObject)keyframes;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "animate", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.StdWeb.Animation Animate(global::System.Runtime.InteropServices.JavaScript.JSObject? keyframes, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.KeyframeAnimationOptions, global::Natrix.JSCore.Generics.DoubleAccessor, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.KeyframeAnimationOptions>> options)
    {
        int ___argsArrayLength_2 = 2;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_3;
        if (keyframes is null)
        {
            ___marshalledValue_3 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_4 = (global::System.Runtime.InteropServices.JavaScript.JSObject)keyframes;
            ___marshalledValue_3 = ___notNullable_4;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        // Argument 2
        global::System.Runtime.InteropServices.JavaScript.JSObject ___propObject_5 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnion(___argsArray_0.JSObject, 1, ___propObject_5);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "animate", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Animation, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>> GetAnimations()
    {
        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallEmptyNonVoidFunctionProperty(JSObject, "getAnimations", JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Animation, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>>>.Get(___resOwner_1.JSObject, "value");
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    public global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Animation, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>> GetAnimations(global::Natrix.StdWeb.GetAnimationsOptions options)
    {
        int ___argsArrayLength_2 = 1;

        using global::Natrix.JSCore.ArgsArrayPool.Owner ___argsArray_0 = global::Natrix.JSCore.ArgsArrayPool.Shared.Rent(___argsArrayLength_2);

        // Argument 1
        global::System.Runtime.InteropServices.JavaScript.JSObject ___marshalledValue_3;
        ___marshalledValue_3 = options.JSObject;
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(___argsArray_0.JSObject, 0, ___marshalledValue_3);

        using global::Natrix.JSCore.FunctionResPool.Owner ___resOwner_1 = global::Natrix.JSCore.FunctionResPool.Shared.Rent();

        global::Natrix.JSCore.Extensions.JSFunctionExtensions.CallNonEmptyNonVoidFunctionProperty(JSObject, "getAnimations", JSObject, ___argsArray_0.JSObject, ___resOwner_1.JSObject);

        // Return Value
        return global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Animation, global::Natrix.JSCore.Generics.ProxyAccessor<global::Natrix.StdWeb.Animation>>>.Get(___resOwner_1.JSObject, "value");
    }
}

#nullable disable