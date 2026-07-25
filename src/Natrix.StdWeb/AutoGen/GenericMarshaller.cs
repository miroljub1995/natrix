// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public static partial class GenericMarshaller
{
    [global::System.Runtime.InteropServices.JavaScript.JSImportAttribute("construct", "natrix")]
    private static partial global::System.Runtime.InteropServices.JavaScript.JSObject ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string constructorName);

    public class Union:
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<uint>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStream>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Blob>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int8Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int16Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int32Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint8Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint16Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint32Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint8ClampedArray>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.BigInt64Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.BigUint64Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float16Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float32Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float64Array>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.DataView>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.ArrayBuffer>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FormData>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLSearchParams>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<string>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FencedFrameConfig>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Request>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<double>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::System.Numerics.BigInteger>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<bool>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::System.Runtime.InteropServices.JavaScript.JSObject>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<object>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Function>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedScript>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLImageElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SVGImageElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLVideoElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLCanvasElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageBitmap>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.OffscreenCanvas>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.VideoFrame>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageData>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSStyleValue>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSVariableReferenceValue>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSNumericValue>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSKeywordValue>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSColorValue>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ScrollIntoViewOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedHTML>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedScriptURL>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ViewTransitionUpdateCallback>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.StartViewTransitionOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.KeyframeAnimationOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Text>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Element>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSPseudoElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Document>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Node>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSParserValue>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStreamTrack>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStreamTrackHandle>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ElementCreationOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImportNodeOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLScriptElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SVGScriptElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DOMMatrix>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUExtent3DDict>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUSampler>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUTexture>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUTextureView>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUBuffer>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUBufferBinding>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUExternalTexture>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUPipelineLayout>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUAutoLayoutMode>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUOrigin3DDict>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUOrigin2DDict>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.SharedArrayBuffer>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUColorDict>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.File>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WebGLRenderingContext>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WebGL2RenderingContext>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamDefaultReader>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamBYOBReader>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamDefaultController>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableByteStreamController>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<ulong>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCEncodedVideoFrame>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCEncodedAudioFrame>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Worker>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WorkerAndParameters>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpSFrameEncryptor>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpScriptTransform>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpSFrameDecryptor>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TaskPriority>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TaskSignal>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.PerformanceMeasureOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CryptoKey>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CryptoKeyPair>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.JsonWebKey>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.KeyframeEffectOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CompositeOperationOrAuto>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TimelineRangeOffset>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLPatternInit>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStream>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaSource>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasRenderingContext2D>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageBitmapRenderingContext>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUCanvasContext>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TogglePopoverOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.PasswordCredentialData>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLFormElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasGradient>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasPattern>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DOMPointInit>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AddEventListenerOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.EventListenerOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CollectedClientAdditionalPaymentData>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioBuffer>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainULongRange>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainDoubleRange>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainDOMStringParameters>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainBooleanParameters>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainPoint2DParameters>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaTrackConstraints>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WriteParams>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WellKnownDirectory>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FileSystemHandle>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaList>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AnimationEffect>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SharedWorkerOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterRule>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterSourceDict>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterSourceEnum>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLPattern>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Client>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ServiceWorker>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MessagePort>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.NDEFMessageInit>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ObservableSubscriptionCallback>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SubscriptionObserver>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ObservableInspector>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RemoteDocument>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RdfLiteral>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.JsonLdEmbed>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.EffectTiming>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLCollection>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RadioNodeList>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLOptionElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLOptGroupElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLElement>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<int>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.VideoTrack>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioTrack>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TextTrack>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Path2D>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Event>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Sanitizer>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerConfig>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerPresets>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerElementNamespace>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerProcessingInstruction>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerAttributeNamespace>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Window>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FenceEvent>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AutoKeyword>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ProcessingInstruction>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBObjectStore>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBIndex>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBCursor>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioSinkInfo>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioSinkOptions>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioContextLatencyCategory>,
        global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioContextRenderSizeCategory>
    {
        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<uint>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out uint value)
        {
            double __type_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_0 != 2)
            {
                value = default;
                return false;
            }

            try
            {
                uint __value_1;
                double __res_2 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "value");
                __value_1 = Convert.ToUInt32(__res_2);

                value = __value_1;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<uint>.ToJS(uint input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_3 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            double __marshalledValue_4;
            __marshalledValue_4 = Convert.ToDouble(input);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(__jsUnion_3, "value", __marshalledValue_4);
            return __jsUnion_3;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_5 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_5 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor> __value_6;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_7;
                __propObject_7 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_6 = new global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>(__propObject_7);

                value = __value_6;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_8 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_9 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_8, "value", __propObject_9);
            return __jsUnion_8;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStream>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ReadableStream value)
        {
            double __type_10 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_10 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ReadableStream __value_11;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_12 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_11 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStream>(__res_12);

                value = __value_11;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStream>.ToJS(global::Natrix.StdWeb.ReadableStream input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_13 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_14;
            __marshalledValue_14 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_13, "value", __marshalledValue_14);
            return __jsUnion_13;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Blob>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Blob value)
        {
            double __type_15 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_15 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Blob __value_16;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_17 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_16 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Blob>(__res_17);

                value = __value_16;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Blob>.ToJS(global::Natrix.StdWeb.Blob input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_18 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_19;
            __marshalledValue_19 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_18, "value", __marshalledValue_19);
            return __jsUnion_18;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int8Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Int8Array value)
        {
            double __type_20 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_20 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Int8Array __value_21;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_22 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_21 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Int8Array>(__res_22);

                value = __value_21;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int8Array>.ToJS(global::Natrix.JSCore.Int8Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_23 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_24;
            __marshalledValue_24 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_23, "value", __marshalledValue_24);
            return __jsUnion_23;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int16Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Int16Array value)
        {
            double __type_25 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_25 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Int16Array __value_26;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_27 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_26 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Int16Array>(__res_27);

                value = __value_26;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int16Array>.ToJS(global::Natrix.JSCore.Int16Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_28 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_29;
            __marshalledValue_29 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_28, "value", __marshalledValue_29);
            return __jsUnion_28;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int32Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Int32Array value)
        {
            double __type_30 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_30 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Int32Array __value_31;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_32 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_31 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Int32Array>(__res_32);

                value = __value_31;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Int32Array>.ToJS(global::Natrix.JSCore.Int32Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_33 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_34;
            __marshalledValue_34 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_33, "value", __marshalledValue_34);
            return __jsUnion_33;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint8Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Uint8Array value)
        {
            double __type_35 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_35 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Uint8Array __value_36;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_37 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_36 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Uint8Array>(__res_37);

                value = __value_36;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint8Array>.ToJS(global::Natrix.JSCore.Uint8Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_38 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_39;
            __marshalledValue_39 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_38, "value", __marshalledValue_39);
            return __jsUnion_38;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint16Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Uint16Array value)
        {
            double __type_40 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_40 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Uint16Array __value_41;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_42 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_41 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Uint16Array>(__res_42);

                value = __value_41;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint16Array>.ToJS(global::Natrix.JSCore.Uint16Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_43 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_44;
            __marshalledValue_44 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_43, "value", __marshalledValue_44);
            return __jsUnion_43;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint32Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Uint32Array value)
        {
            double __type_45 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_45 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Uint32Array __value_46;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_47 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_46 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Uint32Array>(__res_47);

                value = __value_46;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint32Array>.ToJS(global::Natrix.JSCore.Uint32Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_48 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_49;
            __marshalledValue_49 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_48, "value", __marshalledValue_49);
            return __jsUnion_48;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint8ClampedArray>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Uint8ClampedArray value)
        {
            double __type_50 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_50 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Uint8ClampedArray __value_51;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_52 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_51 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Uint8ClampedArray>(__res_52);

                value = __value_51;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Uint8ClampedArray>.ToJS(global::Natrix.JSCore.Uint8ClampedArray input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_53 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_54;
            __marshalledValue_54 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_53, "value", __marshalledValue_54);
            return __jsUnion_53;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.BigInt64Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.BigInt64Array value)
        {
            double __type_55 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_55 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.BigInt64Array __value_56;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_57 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_56 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.BigInt64Array>(__res_57);

                value = __value_56;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.BigInt64Array>.ToJS(global::Natrix.JSCore.BigInt64Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_58 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_59;
            __marshalledValue_59 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_58, "value", __marshalledValue_59);
            return __jsUnion_58;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.BigUint64Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.BigUint64Array value)
        {
            double __type_60 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_60 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.BigUint64Array __value_61;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_62 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_61 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.BigUint64Array>(__res_62);

                value = __value_61;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.BigUint64Array>.ToJS(global::Natrix.JSCore.BigUint64Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_63 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_64;
            __marshalledValue_64 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_63, "value", __marshalledValue_64);
            return __jsUnion_63;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float16Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Float16Array value)
        {
            double __type_65 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_65 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Float16Array __value_66;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_67 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_66 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Float16Array>(__res_67);

                value = __value_66;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float16Array>.ToJS(global::Natrix.JSCore.Float16Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_68 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_69;
            __marshalledValue_69 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_68, "value", __marshalledValue_69);
            return __jsUnion_68;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float32Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Float32Array value)
        {
            double __type_70 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_70 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Float32Array __value_71;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_72 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_71 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Float32Array>(__res_72);

                value = __value_71;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float32Array>.ToJS(global::Natrix.JSCore.Float32Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_73 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_74;
            __marshalledValue_74 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_73, "value", __marshalledValue_74);
            return __jsUnion_73;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float64Array>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Float64Array value)
        {
            double __type_75 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_75 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Float64Array __value_76;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_77 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_76 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Float64Array>(__res_77);

                value = __value_76;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Float64Array>.ToJS(global::Natrix.JSCore.Float64Array input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_78 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_79;
            __marshalledValue_79 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_78, "value", __marshalledValue_79);
            return __jsUnion_78;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.DataView>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.DataView value)
        {
            double __type_80 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_80 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.DataView __value_81;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_82 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_81 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.DataView>(__res_82);

                value = __value_81;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.DataView>.ToJS(global::Natrix.JSCore.DataView input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_83 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_84;
            __marshalledValue_84 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_83, "value", __marshalledValue_84);
            return __jsUnion_83;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.ArrayBuffer>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.ArrayBuffer value)
        {
            double __type_85 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_85 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.ArrayBuffer __value_86;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_87 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_86 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.ArrayBuffer>(__res_87);

                value = __value_86;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.ArrayBuffer>.ToJS(global::Natrix.JSCore.ArrayBuffer input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_88 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_89;
            __marshalledValue_89 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_88, "value", __marshalledValue_89);
            return __jsUnion_88;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FormData>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.FormData value)
        {
            double __type_90 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_90 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.FormData __value_91;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_92 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_91 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FormData>(__res_92);

                value = __value_91;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FormData>.ToJS(global::Natrix.StdWeb.FormData input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_93 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_94;
            __marshalledValue_94 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_93, "value", __marshalledValue_94);
            return __jsUnion_93;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLSearchParams>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.URLSearchParams value)
        {
            double __type_95 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_95 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.URLSearchParams __value_96;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_97 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_96 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.URLSearchParams>(__res_97);

                value = __value_96;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLSearchParams>.ToJS(global::Natrix.StdWeb.URLSearchParams input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_98 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_99;
            __marshalledValue_99 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_98, "value", __marshalledValue_99);
            return __jsUnion_98;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<string>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out string value)
        {
            double __type_100 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_100 != 4)
            {
                value = default;
                return false;
            }

            try
            {
                string __value_101;
                string __res_102 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_101 = __res_102;

                value = __value_101;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<string>.ToJS(string input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_103 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_104;
            __marshalledValue_104 = input;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_103, "value", __marshalledValue_104);
            return __jsUnion_103;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FencedFrameConfig>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.FencedFrameConfig value)
        {
            double __type_105 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_105 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.FencedFrameConfig __value_106;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_107 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_106 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FencedFrameConfig>(__res_107);

                value = __value_106;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FencedFrameConfig>.ToJS(global::Natrix.StdWeb.FencedFrameConfig input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_108 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_109;
            __marshalledValue_109 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_108, "value", __marshalledValue_109);
            return __jsUnion_108;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Request>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Request value)
        {
            double __type_110 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_110 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Request __value_111;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_112 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_111 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Request>(__res_112);

                value = __value_111;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Request>.ToJS(global::Natrix.StdWeb.Request input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_113 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_114;
            __marshalledValue_114 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_113, "value", __marshalledValue_114);
            return __jsUnion_113;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<double>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out double value)
        {
            double __type_115 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_115 != 2)
            {
                value = default;
                return false;
            }

            try
            {
                double __value_116;
                double __res_117 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "value");
                __value_116 = __res_117;

                value = __value_116;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<double>.ToJS(double input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_118 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            double __marshalledValue_119;
            __marshalledValue_119 = input;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(__jsUnion_118, "value", __marshalledValue_119);
            return __jsUnion_118;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::System.Numerics.BigInteger>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::System.Numerics.BigInteger value)
        {
            double __type_120 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_120 != 3)
            {
                value = default;
                return false;
            }

            try
            {
                global::System.Numerics.BigInteger __value_121;
                global::System.Numerics.BigInteger __res_122 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBigIntegerV2(input, "value");
                __value_121 = __res_122;

                value = __value_121;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::System.Numerics.BigInteger>.ToJS(global::System.Numerics.BigInteger input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_123 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Numerics.BigInteger __marshalledValue_124;
            __marshalledValue_124 = input;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBigIntegerV2(__jsUnion_123, "value", __marshalledValue_124);
            return __jsUnion_123;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<bool>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out bool value)
        {
            double __type_125 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_125 != 1)
            {
                value = default;
                return false;
            }

            try
            {
                bool __value_126;
                bool __res_127 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2(input, "value");
                __value_126 = __res_127;

                value = __value_126;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<bool>.ToJS(bool input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_128 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            bool __marshalledValue_129;
            __marshalledValue_129 = input;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2(__jsUnion_128, "value", __marshalledValue_129);
            return __jsUnion_128;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::System.Runtime.InteropServices.JavaScript.JSObject>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::System.Runtime.InteropServices.JavaScript.JSObject value)
        {
            double __type_130 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_130 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::System.Runtime.InteropServices.JavaScript.JSObject __value_131;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_132 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_131 = __res_132;

                value = __value_131;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::System.Runtime.InteropServices.JavaScript.JSObject>.ToJS(global::System.Runtime.InteropServices.JavaScript.JSObject input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_133 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_134;
            __marshalledValue_134 = input;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_133, "value", __marshalledValue_134);
            return __jsUnion_133;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<object>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out object value)
        {
            double __type_135 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_135 != 8)
            {
                value = default;
                return false;
            }

            try
            {
                object __value_136;
                object __res_137 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsObjectV2(input, "value");
                __value_136 = __res_137;

                value = __value_136;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<object>.ToJS(object input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_138 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            object __marshalledValue_139;
            __marshalledValue_139 = input;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsObjectV2(__jsUnion_138, "value", __marshalledValue_139);
            return __jsUnion_138;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Function>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Function value)
        {
            double __type_140 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_140 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Function __value_141;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_142 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_141 = new global::Natrix.StdWeb.Function(__res_142);

                value = __value_141;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Function>.ToJS(global::Natrix.StdWeb.Function input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_143 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_144;
            __marshalledValue_144 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_143, "value", __marshalledValue_144);
            return __jsUnion_143;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedScript>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TrustedScript value)
        {
            double __type_145 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_145 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TrustedScript __value_146;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_147 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_146 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TrustedScript>(__res_147);

                value = __value_146;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedScript>.ToJS(global::Natrix.StdWeb.TrustedScript input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_148 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_149;
            __marshalledValue_149 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_148, "value", __marshalledValue_149);
            return __jsUnion_148;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLImageElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLImageElement value)
        {
            double __type_150 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_150 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLImageElement __value_151;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_152 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_151 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLImageElement>(__res_152);

                value = __value_151;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLImageElement>.ToJS(global::Natrix.StdWeb.HTMLImageElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_153 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_154;
            __marshalledValue_154 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_153, "value", __marshalledValue_154);
            return __jsUnion_153;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SVGImageElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SVGImageElement value)
        {
            double __type_155 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_155 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SVGImageElement __value_156;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_157 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_156 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGImageElement>(__res_157);

                value = __value_156;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SVGImageElement>.ToJS(global::Natrix.StdWeb.SVGImageElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_158 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_159;
            __marshalledValue_159 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_158, "value", __marshalledValue_159);
            return __jsUnion_158;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLVideoElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLVideoElement value)
        {
            double __type_160 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_160 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLVideoElement __value_161;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_162 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_161 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLVideoElement>(__res_162);

                value = __value_161;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLVideoElement>.ToJS(global::Natrix.StdWeb.HTMLVideoElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_163 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_164;
            __marshalledValue_164 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_163, "value", __marshalledValue_164);
            return __jsUnion_163;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLCanvasElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLCanvasElement value)
        {
            double __type_165 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_165 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLCanvasElement __value_166;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_167 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_166 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLCanvasElement>(__res_167);

                value = __value_166;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLCanvasElement>.ToJS(global::Natrix.StdWeb.HTMLCanvasElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_168 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_169;
            __marshalledValue_169 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_168, "value", __marshalledValue_169);
            return __jsUnion_168;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageBitmap>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ImageBitmap value)
        {
            double __type_170 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_170 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ImageBitmap __value_171;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_172 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_171 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ImageBitmap>(__res_172);

                value = __value_171;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageBitmap>.ToJS(global::Natrix.StdWeb.ImageBitmap input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_173 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_174;
            __marshalledValue_174 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_173, "value", __marshalledValue_174);
            return __jsUnion_173;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.OffscreenCanvas>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.OffscreenCanvas value)
        {
            double __type_175 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_175 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.OffscreenCanvas __value_176;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_177 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_176 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.OffscreenCanvas>(__res_177);

                value = __value_176;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.OffscreenCanvas>.ToJS(global::Natrix.StdWeb.OffscreenCanvas input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_178 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_179;
            __marshalledValue_179 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_178, "value", __marshalledValue_179);
            return __jsUnion_178;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.VideoFrame>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.VideoFrame value)
        {
            double __type_180 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_180 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.VideoFrame __value_181;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_182 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_181 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VideoFrame>(__res_182);

                value = __value_181;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.VideoFrame>.ToJS(global::Natrix.StdWeb.VideoFrame input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_183 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_184;
            __marshalledValue_184 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_183, "value", __marshalledValue_184);
            return __jsUnion_183;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageData>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ImageData value)
        {
            double __type_185 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_185 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ImageData __value_186;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_187 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_186 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ImageData>(__res_187);

                value = __value_186;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageData>.ToJS(global::Natrix.StdWeb.ImageData input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_188 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_189;
            __marshalledValue_189 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_188, "value", __marshalledValue_189);
            return __jsUnion_188;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSStyleValue>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSStyleValue value)
        {
            double __type_190 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_190 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSStyleValue __value_191;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_192 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_191 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSStyleValue>(__res_192);

                value = __value_191;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSStyleValue>.ToJS(global::Natrix.StdWeb.CSSStyleValue input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_193 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_194;
            __marshalledValue_194 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_193, "value", __marshalledValue_194);
            return __jsUnion_193;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSVariableReferenceValue>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSVariableReferenceValue value)
        {
            double __type_195 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_195 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSVariableReferenceValue __value_196;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_197 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_196 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSVariableReferenceValue>(__res_197);

                value = __value_196;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSVariableReferenceValue>.ToJS(global::Natrix.StdWeb.CSSVariableReferenceValue input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_198 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_199;
            __marshalledValue_199 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_198, "value", __marshalledValue_199);
            return __jsUnion_198;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSNumericValue>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSNumericValue value)
        {
            double __type_200 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_200 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSNumericValue __value_201;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_202 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_201 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSNumericValue>(__res_202);

                value = __value_201;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSNumericValue>.ToJS(global::Natrix.StdWeb.CSSNumericValue input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_203 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_204;
            __marshalledValue_204 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_203, "value", __marshalledValue_204);
            return __jsUnion_203;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSKeywordValue>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSKeywordValue value)
        {
            double __type_205 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_205 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSKeywordValue __value_206;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_207 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_206 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSKeywordValue>(__res_207);

                value = __value_206;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSKeywordValue>.ToJS(global::Natrix.StdWeb.CSSKeywordValue input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_208 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_209;
            __marshalledValue_209 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_208, "value", __marshalledValue_209);
            return __jsUnion_208;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSColorValue>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSColorValue value)
        {
            double __type_210 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_210 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSColorValue __value_211;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_212 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_211 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSColorValue>(__res_212);

                value = __value_211;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSColorValue>.ToJS(global::Natrix.StdWeb.CSSColorValue input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_213 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_214;
            __marshalledValue_214 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_213, "value", __marshalledValue_214);
            return __jsUnion_213;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ScrollIntoViewOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ScrollIntoViewOptions value)
        {
            double __type_215 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_215 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ScrollIntoViewOptions __value_216;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_217 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_216 = new global::Natrix.StdWeb.ScrollIntoViewOptions(__res_217);

                value = __value_216;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ScrollIntoViewOptions>.ToJS(global::Natrix.StdWeb.ScrollIntoViewOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_218 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_219;
            __marshalledValue_219 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_218, "value", __marshalledValue_219);
            return __jsUnion_218;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedHTML>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TrustedHTML value)
        {
            double __type_220 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_220 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TrustedHTML __value_221;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_222 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_221 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TrustedHTML>(__res_222);

                value = __value_221;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedHTML>.ToJS(global::Natrix.StdWeb.TrustedHTML input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_223 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_224;
            __marshalledValue_224 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_223, "value", __marshalledValue_224);
            return __jsUnion_223;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedScriptURL>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TrustedScriptURL value)
        {
            double __type_225 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_225 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TrustedScriptURL __value_226;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_227 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_226 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TrustedScriptURL>(__res_227);

                value = __value_226;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TrustedScriptURL>.ToJS(global::Natrix.StdWeb.TrustedScriptURL input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_228 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_229;
            __marshalledValue_229 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_228, "value", __marshalledValue_229);
            return __jsUnion_228;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ViewTransitionUpdateCallback>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ViewTransitionUpdateCallback value)
        {
            double __type_230 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_230 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ViewTransitionUpdateCallback __value_231;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_232 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_231 = new global::Natrix.StdWeb.ViewTransitionUpdateCallback(__res_232);

                value = __value_231;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ViewTransitionUpdateCallback>.ToJS(global::Natrix.StdWeb.ViewTransitionUpdateCallback input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_233 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_234;
            __marshalledValue_234 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_233, "value", __marshalledValue_234);
            return __jsUnion_233;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.StartViewTransitionOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.StartViewTransitionOptions value)
        {
            double __type_235 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_235 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.StartViewTransitionOptions __value_236;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_237 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_236 = new global::Natrix.StdWeb.StartViewTransitionOptions(__res_237);

                value = __value_236;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.StartViewTransitionOptions>.ToJS(global::Natrix.StdWeb.StartViewTransitionOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_238 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_239;
            __marshalledValue_239 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_238, "value", __marshalledValue_239);
            return __jsUnion_238;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.KeyframeAnimationOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.KeyframeAnimationOptions value)
        {
            double __type_240 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_240 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.KeyframeAnimationOptions __value_241;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_242 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_241 = new global::Natrix.StdWeb.KeyframeAnimationOptions(__res_242);

                value = __value_241;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.KeyframeAnimationOptions>.ToJS(global::Natrix.StdWeb.KeyframeAnimationOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_243 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_244;
            __marshalledValue_244 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_243, "value", __marshalledValue_244);
            return __jsUnion_243;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Text>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Text value)
        {
            double __type_245 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_245 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Text __value_246;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_247 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_246 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Text>(__res_247);

                value = __value_246;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Text>.ToJS(global::Natrix.StdWeb.Text input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_248 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_249;
            __marshalledValue_249 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_248, "value", __marshalledValue_249);
            return __jsUnion_248;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Element>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Element value)
        {
            double __type_250 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_250 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Element __value_251;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_252 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_251 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Element>(__res_252);

                value = __value_251;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Element>.ToJS(global::Natrix.StdWeb.Element input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_253 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_254;
            __marshalledValue_254 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_253, "value", __marshalledValue_254);
            return __jsUnion_253;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSPseudoElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSPseudoElement value)
        {
            double __type_255 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_255 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSPseudoElement __value_256;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_257 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_256 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSPseudoElement>(__res_257);

                value = __value_256;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSPseudoElement>.ToJS(global::Natrix.StdWeb.CSSPseudoElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_258 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_259;
            __marshalledValue_259 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_258, "value", __marshalledValue_259);
            return __jsUnion_258;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Document>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Document value)
        {
            double __type_260 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_260 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Document __value_261;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_262 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_261 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Document>(__res_262);

                value = __value_261;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Document>.ToJS(global::Natrix.StdWeb.Document input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_263 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_264;
            __marshalledValue_264 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_263, "value", __marshalledValue_264);
            return __jsUnion_263;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Node>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Node value)
        {
            double __type_265 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_265 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Node __value_266;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_267 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_266 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Node>(__res_267);

                value = __value_266;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Node>.ToJS(global::Natrix.StdWeb.Node input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_268 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_269;
            __marshalledValue_269 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_268, "value", __marshalledValue_269);
            return __jsUnion_268;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSParserValue>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CSSParserValue value)
        {
            double __type_270 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_270 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CSSParserValue __value_271;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_272 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_271 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSParserValue>(__res_272);

                value = __value_271;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CSSParserValue>.ToJS(global::Natrix.StdWeb.CSSParserValue input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_273 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_274;
            __marshalledValue_274 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_273, "value", __marshalledValue_274);
            return __jsUnion_273;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStreamTrack>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MediaStreamTrack value)
        {
            double __type_275 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_275 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MediaStreamTrack __value_276;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_277 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_276 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaStreamTrack>(__res_277);

                value = __value_276;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStreamTrack>.ToJS(global::Natrix.StdWeb.MediaStreamTrack input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_278 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_279;
            __marshalledValue_279 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_278, "value", __marshalledValue_279);
            return __jsUnion_278;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStreamTrackHandle>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MediaStreamTrackHandle value)
        {
            double __type_280 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_280 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MediaStreamTrackHandle __value_281;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_282 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_281 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaStreamTrackHandle>(__res_282);

                value = __value_281;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStreamTrackHandle>.ToJS(global::Natrix.StdWeb.MediaStreamTrackHandle input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_283 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_284;
            __marshalledValue_284 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_283, "value", __marshalledValue_284);
            return __jsUnion_283;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_285 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_285 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> __value_286;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_287;
                __propObject_287 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_286 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(__propObject_287);

                value = __value_286;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.CSSKeywordValue, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_288 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_289 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_288, "value", __propObject_289);
            return __jsUnion_288;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ElementCreationOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ElementCreationOptions value)
        {
            double __type_290 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_290 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ElementCreationOptions __value_291;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_292 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_291 = new global::Natrix.StdWeb.ElementCreationOptions(__res_292);

                value = __value_291;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ElementCreationOptions>.ToJS(global::Natrix.StdWeb.ElementCreationOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_293 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_294;
            __marshalledValue_294 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_293, "value", __marshalledValue_294);
            return __jsUnion_293;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImportNodeOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ImportNodeOptions value)
        {
            double __type_295 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_295 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ImportNodeOptions __value_296;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_297 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_296 = new global::Natrix.StdWeb.ImportNodeOptions(__res_297);

                value = __value_296;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImportNodeOptions>.ToJS(global::Natrix.StdWeb.ImportNodeOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_298 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_299;
            __marshalledValue_299 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_298, "value", __marshalledValue_299);
            return __jsUnion_298;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLScriptElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLScriptElement value)
        {
            double __type_300 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_300 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLScriptElement __value_301;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_302 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_301 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLScriptElement>(__res_302);

                value = __value_301;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLScriptElement>.ToJS(global::Natrix.StdWeb.HTMLScriptElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_303 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_304;
            __marshalledValue_304 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_303, "value", __marshalledValue_304);
            return __jsUnion_303;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SVGScriptElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SVGScriptElement value)
        {
            double __type_305 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_305 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SVGScriptElement __value_306;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_307 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_306 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGScriptElement>(__res_307);

                value = __value_306;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SVGScriptElement>.ToJS(global::Natrix.StdWeb.SVGScriptElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_308 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_309;
            __marshalledValue_309 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_308, "value", __marshalledValue_309);
            return __jsUnion_308;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DOMMatrix>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.DOMMatrix value)
        {
            double __type_310 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_310 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.DOMMatrix __value_311;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_312 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_311 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMMatrix>(__res_312);

                value = __value_311;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DOMMatrix>.ToJS(global::Natrix.StdWeb.DOMMatrix input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_313 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_314;
            __marshalledValue_314 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_313, "value", __marshalledValue_314);
            return __jsUnion_313;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUExtent3DDict>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUExtent3DDict value)
        {
            double __type_315 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_315 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUExtent3DDict __value_316;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_317 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_316 = new global::Natrix.StdWeb.GPUExtent3DDict(__res_317);

                value = __value_316;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUExtent3DDict>.ToJS(global::Natrix.StdWeb.GPUExtent3DDict input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_318 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_319;
            __marshalledValue_319 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_318, "value", __marshalledValue_319);
            return __jsUnion_318;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUSampler>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUSampler value)
        {
            double __type_320 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_320 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUSampler __value_321;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_322 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_321 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUSampler>(__res_322);

                value = __value_321;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUSampler>.ToJS(global::Natrix.StdWeb.GPUSampler input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_323 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_324;
            __marshalledValue_324 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_323, "value", __marshalledValue_324);
            return __jsUnion_323;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUTexture>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUTexture value)
        {
            double __type_325 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_325 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUTexture __value_326;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_327 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_326 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUTexture>(__res_327);

                value = __value_326;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUTexture>.ToJS(global::Natrix.StdWeb.GPUTexture input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_328 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_329;
            __marshalledValue_329 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_328, "value", __marshalledValue_329);
            return __jsUnion_328;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUTextureView>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUTextureView value)
        {
            double __type_330 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_330 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUTextureView __value_331;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_332 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_331 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUTextureView>(__res_332);

                value = __value_331;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUTextureView>.ToJS(global::Natrix.StdWeb.GPUTextureView input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_333 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_334;
            __marshalledValue_334 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_333, "value", __marshalledValue_334);
            return __jsUnion_333;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUBuffer>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUBuffer value)
        {
            double __type_335 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_335 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUBuffer __value_336;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_337 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_336 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUBuffer>(__res_337);

                value = __value_336;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUBuffer>.ToJS(global::Natrix.StdWeb.GPUBuffer input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_338 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_339;
            __marshalledValue_339 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_338, "value", __marshalledValue_339);
            return __jsUnion_338;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUBufferBinding>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUBufferBinding value)
        {
            double __type_340 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_340 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUBufferBinding __value_341;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_342 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_341 = new global::Natrix.StdWeb.GPUBufferBinding(__res_342);

                value = __value_341;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUBufferBinding>.ToJS(global::Natrix.StdWeb.GPUBufferBinding input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_343 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_344;
            __marshalledValue_344 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_343, "value", __marshalledValue_344);
            return __jsUnion_343;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUExternalTexture>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUExternalTexture value)
        {
            double __type_345 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_345 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUExternalTexture __value_346;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_347 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_346 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUExternalTexture>(__res_347);

                value = __value_346;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUExternalTexture>.ToJS(global::Natrix.StdWeb.GPUExternalTexture input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_348 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_349;
            __marshalledValue_349 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_348, "value", __marshalledValue_349);
            return __jsUnion_348;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUPipelineLayout>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUPipelineLayout value)
        {
            double __type_350 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_350 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUPipelineLayout __value_351;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_352 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_351 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUPipelineLayout>(__res_352);

                value = __value_351;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUPipelineLayout>.ToJS(global::Natrix.StdWeb.GPUPipelineLayout input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_353 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_354;
            __marshalledValue_354 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_353, "value", __marshalledValue_354);
            return __jsUnion_353;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUAutoLayoutMode>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUAutoLayoutMode value)
        {
            double __type_355 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_355 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUAutoLayoutMode __value_356;
                string __res_357 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_356 = global::Natrix.StdWeb.GPUAutoLayoutMode.Create(__res_357);

                value = __value_356;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUAutoLayoutMode>.ToJS(global::Natrix.StdWeb.GPUAutoLayoutMode input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_358 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_359;
            __marshalledValue_359 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_358, "value", __marshalledValue_359);
            return __jsUnion_358;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUOrigin3DDict>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUOrigin3DDict value)
        {
            double __type_360 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_360 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUOrigin3DDict __value_361;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_362 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_361 = new global::Natrix.StdWeb.GPUOrigin3DDict(__res_362);

                value = __value_361;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUOrigin3DDict>.ToJS(global::Natrix.StdWeb.GPUOrigin3DDict input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_363 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_364;
            __marshalledValue_364 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_363, "value", __marshalledValue_364);
            return __jsUnion_363;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUOrigin2DDict>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUOrigin2DDict value)
        {
            double __type_365 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_365 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUOrigin2DDict __value_366;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_367 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_366 = new global::Natrix.StdWeb.GPUOrigin2DDict(__res_367);

                value = __value_366;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUOrigin2DDict>.ToJS(global::Natrix.StdWeb.GPUOrigin2DDict input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_368 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_369;
            __marshalledValue_369 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_368, "value", __marshalledValue_369);
            return __jsUnion_368;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.SharedArrayBuffer>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.SharedArrayBuffer value)
        {
            double __type_370 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_370 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.SharedArrayBuffer __value_371;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_372 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_371 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.SharedArrayBuffer>(__res_372);

                value = __value_371;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.SharedArrayBuffer>.ToJS(global::Natrix.JSCore.SharedArrayBuffer input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_373 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_374;
            __marshalledValue_374 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_373, "value", __marshalledValue_374);
            return __jsUnion_373;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_375 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_375 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor> __value_376;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_377;
                __propObject_377 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_376 = new global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor>(__propObject_377);

                value = __value_376;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<double, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_378 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_379 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_378, "value", __propObject_379);
            return __jsUnion_378;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUColorDict>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUColorDict value)
        {
            double __type_380 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_380 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUColorDict __value_381;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_382 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_381 = new global::Natrix.StdWeb.GPUColorDict(__res_382);

                value = __value_381;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUColorDict>.ToJS(global::Natrix.StdWeb.GPUColorDict input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_383 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_384;
            __marshalledValue_384 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_383, "value", __marshalledValue_384);
            return __jsUnion_383;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_385 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_385 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor> __value_386;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_387;
                __propObject_387 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_386 = new global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor>(__propObject_387);

                value = __value_386;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<float, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_388 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_389 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_388, "value", __propObject_389);
            return __jsUnion_388;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_390 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_390 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor> __value_391;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_392;
                __propObject_392 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_391 = new global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>(__propObject_392);

                value = __value_391;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<int, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_393 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_394 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_393, "value", __propObject_394);
            return __jsUnion_393;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.File>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.File value)
        {
            double __type_395 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_395 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.File __value_396;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_397 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_396 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.File>(__res_397);

                value = __value_396;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.File>.ToJS(global::Natrix.StdWeb.File input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_398 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_399;
            __marshalledValue_399 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_398, "value", __marshalledValue_399);
            return __jsUnion_398;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WebGLRenderingContext>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.WebGLRenderingContext value)
        {
            double __type_400 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_400 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.WebGLRenderingContext __value_401;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_402 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_401 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLRenderingContext>(__res_402);

                value = __value_401;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WebGLRenderingContext>.ToJS(global::Natrix.StdWeb.WebGLRenderingContext input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_403 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_404;
            __marshalledValue_404 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_403, "value", __marshalledValue_404);
            return __jsUnion_403;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WebGL2RenderingContext>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.WebGL2RenderingContext value)
        {
            double __type_405 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_405 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.WebGL2RenderingContext __value_406;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_407 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_406 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGL2RenderingContext>(__res_407);

                value = __value_406;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WebGL2RenderingContext>.ToJS(global::Natrix.StdWeb.WebGL2RenderingContext input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_408 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_409;
            __marshalledValue_409 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_408, "value", __marshalledValue_409);
            return __jsUnion_408;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamDefaultReader>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ReadableStreamDefaultReader value)
        {
            double __type_410 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_410 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ReadableStreamDefaultReader __value_411;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_412 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_411 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStreamDefaultReader>(__res_412);

                value = __value_411;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamDefaultReader>.ToJS(global::Natrix.StdWeb.ReadableStreamDefaultReader input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_413 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_414;
            __marshalledValue_414 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_413, "value", __marshalledValue_414);
            return __jsUnion_413;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamBYOBReader>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ReadableStreamBYOBReader value)
        {
            double __type_415 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_415 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ReadableStreamBYOBReader __value_416;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_417 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_416 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStreamBYOBReader>(__res_417);

                value = __value_416;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamBYOBReader>.ToJS(global::Natrix.StdWeb.ReadableStreamBYOBReader input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_418 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_419;
            __marshalledValue_419 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_418, "value", __marshalledValue_419);
            return __jsUnion_418;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamDefaultController>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ReadableStreamDefaultController value)
        {
            double __type_420 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_420 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ReadableStreamDefaultController __value_421;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_422 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_421 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStreamDefaultController>(__res_422);

                value = __value_421;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableStreamDefaultController>.ToJS(global::Natrix.StdWeb.ReadableStreamDefaultController input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_423 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_424;
            __marshalledValue_424 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_423, "value", __marshalledValue_424);
            return __jsUnion_423;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableByteStreamController>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ReadableByteStreamController value)
        {
            double __type_425 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_425 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ReadableByteStreamController __value_426;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_427 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_426 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableByteStreamController>(__res_427);

                value = __value_426;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ReadableByteStreamController>.ToJS(global::Natrix.StdWeb.ReadableByteStreamController input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_428 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_429;
            __marshalledValue_429 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_428, "value", __marshalledValue_429);
            return __jsUnion_428;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<ulong>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out ulong value)
        {
            double __type_430 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_430 != 2)
            {
                value = default;
                return false;
            }

            try
            {
                ulong __value_431;
                double __res_432 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "value");
                __value_431 = Convert.ToUInt64(__res_432);

                value = __value_431;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<ulong>.ToJS(ulong input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_433 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            double __marshalledValue_434;
            __marshalledValue_434 = Convert.ToDouble(input);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(__jsUnion_433, "value", __marshalledValue_434);
            return __jsUnion_433;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCEncodedVideoFrame>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RTCEncodedVideoFrame value)
        {
            double __type_435 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_435 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RTCEncodedVideoFrame __value_436;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_437 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_436 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCEncodedVideoFrame>(__res_437);

                value = __value_436;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCEncodedVideoFrame>.ToJS(global::Natrix.StdWeb.RTCEncodedVideoFrame input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_438 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_439;
            __marshalledValue_439 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_438, "value", __marshalledValue_439);
            return __jsUnion_438;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCEncodedAudioFrame>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RTCEncodedAudioFrame value)
        {
            double __type_440 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_440 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RTCEncodedAudioFrame __value_441;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_442 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_441 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCEncodedAudioFrame>(__res_442);

                value = __value_441;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCEncodedAudioFrame>.ToJS(global::Natrix.StdWeb.RTCEncodedAudioFrame input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_443 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_444;
            __marshalledValue_444 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_443, "value", __marshalledValue_444);
            return __jsUnion_443;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Worker>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Worker value)
        {
            double __type_445 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_445 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Worker __value_446;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_447 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_446 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Worker>(__res_447);

                value = __value_446;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Worker>.ToJS(global::Natrix.StdWeb.Worker input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_448 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_449;
            __marshalledValue_449 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_448, "value", __marshalledValue_449);
            return __jsUnion_448;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WorkerAndParameters>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.WorkerAndParameters value)
        {
            double __type_450 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_450 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.WorkerAndParameters __value_451;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_452 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_451 = new global::Natrix.StdWeb.WorkerAndParameters(__res_452);

                value = __value_451;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WorkerAndParameters>.ToJS(global::Natrix.StdWeb.WorkerAndParameters input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_453 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_454;
            __marshalledValue_454 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_453, "value", __marshalledValue_454);
            return __jsUnion_453;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpSFrameEncryptor>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RTCRtpSFrameEncryptor value)
        {
            double __type_455 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_455 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RTCRtpSFrameEncryptor __value_456;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_457 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_456 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCRtpSFrameEncryptor>(__res_457);

                value = __value_456;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpSFrameEncryptor>.ToJS(global::Natrix.StdWeb.RTCRtpSFrameEncryptor input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_458 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_459;
            __marshalledValue_459 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_458, "value", __marshalledValue_459);
            return __jsUnion_458;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpScriptTransform>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RTCRtpScriptTransform value)
        {
            double __type_460 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_460 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RTCRtpScriptTransform __value_461;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_462 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_461 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCRtpScriptTransform>(__res_462);

                value = __value_461;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpScriptTransform>.ToJS(global::Natrix.StdWeb.RTCRtpScriptTransform input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_463 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_464;
            __marshalledValue_464 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_463, "value", __marshalledValue_464);
            return __jsUnion_463;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpSFrameDecryptor>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RTCRtpSFrameDecryptor value)
        {
            double __type_465 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_465 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RTCRtpSFrameDecryptor __value_466;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_467 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_466 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCRtpSFrameDecryptor>(__res_467);

                value = __value_466;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RTCRtpSFrameDecryptor>.ToJS(global::Natrix.StdWeb.RTCRtpSFrameDecryptor input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_468 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_469;
            __marshalledValue_469 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_468, "value", __marshalledValue_469);
            return __jsUnion_468;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TaskPriority>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TaskPriority value)
        {
            double __type_470 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_470 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TaskPriority __value_471;
                string __res_472 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_471 = global::Natrix.StdWeb.TaskPriority.Create(__res_472);

                value = __value_471;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TaskPriority>.ToJS(global::Natrix.StdWeb.TaskPriority input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_473 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_474;
            __marshalledValue_474 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_473, "value", __marshalledValue_474);
            return __jsUnion_473;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TaskSignal>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TaskSignal value)
        {
            double __type_475 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_475 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TaskSignal __value_476;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_477 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_476 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TaskSignal>(__res_477);

                value = __value_476;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TaskSignal>.ToJS(global::Natrix.StdWeb.TaskSignal input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_478 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_479;
            __marshalledValue_479 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_478, "value", __marshalledValue_479);
            return __jsUnion_478;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.PerformanceMeasureOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.PerformanceMeasureOptions value)
        {
            double __type_480 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_480 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.PerformanceMeasureOptions __value_481;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_482 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_481 = new global::Natrix.StdWeb.PerformanceMeasureOptions(__res_482);

                value = __value_481;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.PerformanceMeasureOptions>.ToJS(global::Natrix.StdWeb.PerformanceMeasureOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_483 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_484;
            __marshalledValue_484 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_483, "value", __marshalledValue_484);
            return __jsUnion_483;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CryptoKey>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CryptoKey value)
        {
            double __type_485 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_485 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CryptoKey __value_486;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_487 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_486 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CryptoKey>(__res_487);

                value = __value_486;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CryptoKey>.ToJS(global::Natrix.StdWeb.CryptoKey input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_488 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_489;
            __marshalledValue_489 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_488, "value", __marshalledValue_489);
            return __jsUnion_488;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CryptoKeyPair>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CryptoKeyPair value)
        {
            double __type_490 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_490 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CryptoKeyPair __value_491;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_492 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_491 = new global::Natrix.StdWeb.CryptoKeyPair(__res_492);

                value = __value_491;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CryptoKeyPair>.ToJS(global::Natrix.StdWeb.CryptoKeyPair input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_493 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_494;
            __marshalledValue_494 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_493, "value", __marshalledValue_494);
            return __jsUnion_493;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.JsonWebKey>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.JsonWebKey value)
        {
            double __type_495 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_495 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.JsonWebKey __value_496;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_497 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_496 = new global::Natrix.StdWeb.JsonWebKey(__res_497);

                value = __value_496;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.JsonWebKey>.ToJS(global::Natrix.StdWeb.JsonWebKey input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_498 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_499;
            __marshalledValue_499 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_498, "value", __marshalledValue_499);
            return __jsUnion_498;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.KeyframeEffectOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.KeyframeEffectOptions value)
        {
            double __type_500 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_500 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.KeyframeEffectOptions __value_501;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_502 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_501 = new global::Natrix.StdWeb.KeyframeEffectOptions(__res_502);

                value = __value_501;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.KeyframeEffectOptions>.ToJS(global::Natrix.StdWeb.KeyframeEffectOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_503 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_504;
            __marshalledValue_504 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_503, "value", __marshalledValue_504);
            return __jsUnion_503;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable> value)
        {
            double __type_505 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_505 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable> __value_506;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_507;
                __propObject_507 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_506 = new global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>(__propObject_507);

                value = __value_506;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>>.ToJS(global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_508 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_509 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_508, "value", __propObject_509);
            return __jsUnion_508;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_510 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_510 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> __value_511;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_512;
                __propObject_512 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_511 = new global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>(__propObject_512);

                value = __value_511;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_513 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_514 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_513, "value", __propObject_514);
            return __jsUnion_513;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CompositeOperationOrAuto>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CompositeOperationOrAuto value)
        {
            double __type_515 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_515 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CompositeOperationOrAuto __value_516;
                string __res_517 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_516 = global::Natrix.StdWeb.CompositeOperationOrAuto.Create(__res_517);

                value = __value_516;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CompositeOperationOrAuto>.ToJS(global::Natrix.StdWeb.CompositeOperationOrAuto input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_518 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_519;
            __marshalledValue_519 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_518, "value", __marshalledValue_519);
            return __jsUnion_518;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_520 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_520 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor> __value_521;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_522;
                __propObject_522 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_521 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>(__propObject_522);

                value = __value_521;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.CompositeOperationOrAuto, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_523 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_524 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_523, "value", __propObject_524);
            return __jsUnion_523;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TimelineRangeOffset>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TimelineRangeOffset value)
        {
            double __type_525 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_525 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TimelineRangeOffset __value_526;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_527 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_526 = new global::Natrix.StdWeb.TimelineRangeOffset(__res_527);

                value = __value_526;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TimelineRangeOffset>.ToJS(global::Natrix.StdWeb.TimelineRangeOffset input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_528 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_529;
            __marshalledValue_529 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_528, "value", __marshalledValue_529);
            return __jsUnion_528;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLPatternInit>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.URLPatternInit value)
        {
            double __type_530 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_530 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.URLPatternInit __value_531;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_532 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_531 = new global::Natrix.StdWeb.URLPatternInit(__res_532);

                value = __value_531;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLPatternInit>.ToJS(global::Natrix.StdWeb.URLPatternInit input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_533 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_534;
            __marshalledValue_534 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_533, "value", __marshalledValue_534);
            return __jsUnion_533;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStream>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MediaStream value)
        {
            double __type_535 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_535 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MediaStream __value_536;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_537 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_536 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaStream>(__res_537);

                value = __value_536;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaStream>.ToJS(global::Natrix.StdWeb.MediaStream input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_538 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_539;
            __marshalledValue_539 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_538, "value", __marshalledValue_539);
            return __jsUnion_538;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaSource>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MediaSource value)
        {
            double __type_540 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_540 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MediaSource __value_541;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_542 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_541 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaSource>(__res_542);

                value = __value_541;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaSource>.ToJS(global::Natrix.StdWeb.MediaSource input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_543 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_544;
            __marshalledValue_544 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_543, "value", __marshalledValue_544);
            return __jsUnion_543;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasRenderingContext2D>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CanvasRenderingContext2D value)
        {
            double __type_545 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_545 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CanvasRenderingContext2D __value_546;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_547 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_546 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CanvasRenderingContext2D>(__res_547);

                value = __value_546;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasRenderingContext2D>.ToJS(global::Natrix.StdWeb.CanvasRenderingContext2D input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_548 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_549;
            __marshalledValue_549 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_548, "value", __marshalledValue_549);
            return __jsUnion_548;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageBitmapRenderingContext>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ImageBitmapRenderingContext value)
        {
            double __type_550 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_550 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ImageBitmapRenderingContext __value_551;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_552 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_551 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ImageBitmapRenderingContext>(__res_552);

                value = __value_551;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ImageBitmapRenderingContext>.ToJS(global::Natrix.StdWeb.ImageBitmapRenderingContext input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_553 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_554;
            __marshalledValue_554 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_553, "value", __marshalledValue_554);
            return __jsUnion_553;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUCanvasContext>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.GPUCanvasContext value)
        {
            double __type_555 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_555 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.GPUCanvasContext __value_556;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_557 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_556 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUCanvasContext>(__res_557);

                value = __value_556;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.GPUCanvasContext>.ToJS(global::Natrix.StdWeb.GPUCanvasContext input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_558 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_559;
            __marshalledValue_559 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_558, "value", __marshalledValue_559);
            return __jsUnion_558;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TogglePopoverOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TogglePopoverOptions value)
        {
            double __type_560 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_560 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TogglePopoverOptions __value_561;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_562 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_561 = new global::Natrix.StdWeb.TogglePopoverOptions(__res_562);

                value = __value_561;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TogglePopoverOptions>.ToJS(global::Natrix.StdWeb.TogglePopoverOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_563 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_564;
            __marshalledValue_564 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_563, "value", __marshalledValue_564);
            return __jsUnion_563;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_565 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_565 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor> __value_566;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_567;
                __propObject_567 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_566 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>(__propObject_567);

                value = __value_566;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_568 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_569 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_568, "value", __propObject_569);
            return __jsUnion_568;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_570 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_570 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor> __value_571;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_572;
                __propObject_572 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_571 = new global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor>(__propObject_572);

                value = __value_571;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.Record<string, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_573 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_574 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_573, "value", __propObject_574);
            return __jsUnion_573;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.PasswordCredentialData>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.PasswordCredentialData value)
        {
            double __type_575 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_575 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.PasswordCredentialData __value_576;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_577 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_576 = new global::Natrix.StdWeb.PasswordCredentialData(__res_577);

                value = __value_576;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.PasswordCredentialData>.ToJS(global::Natrix.StdWeb.PasswordCredentialData input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_578 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_579;
            __marshalledValue_579 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_578, "value", __marshalledValue_579);
            return __jsUnion_578;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLFormElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLFormElement value)
        {
            double __type_580 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_580 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLFormElement __value_581;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_582 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_581 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLFormElement>(__res_582);

                value = __value_581;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLFormElement>.ToJS(global::Natrix.StdWeb.HTMLFormElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_583 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_584;
            __marshalledValue_584 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_583, "value", __marshalledValue_584);
            return __jsUnion_583;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasGradient>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CanvasGradient value)
        {
            double __type_585 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_585 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CanvasGradient __value_586;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_587 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_586 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CanvasGradient>(__res_587);

                value = __value_586;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasGradient>.ToJS(global::Natrix.StdWeb.CanvasGradient input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_588 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_589;
            __marshalledValue_589 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_588, "value", __marshalledValue_589);
            return __jsUnion_588;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasPattern>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CanvasPattern value)
        {
            double __type_590 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_590 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CanvasPattern __value_591;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_592 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_591 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CanvasPattern>(__res_592);

                value = __value_591;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CanvasPattern>.ToJS(global::Natrix.StdWeb.CanvasPattern input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_593 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_594;
            __marshalledValue_594 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_593, "value", __marshalledValue_594);
            return __jsUnion_593;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DOMPointInit>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.DOMPointInit value)
        {
            double __type_595 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_595 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.DOMPointInit __value_596;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_597 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_596 = new global::Natrix.StdWeb.DOMPointInit(__res_597);

                value = __value_596;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DOMPointInit>.ToJS(global::Natrix.StdWeb.DOMPointInit input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_598 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_599;
            __marshalledValue_599 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_598, "value", __marshalledValue_599);
            return __jsUnion_598;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_600 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_600 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> __value_601;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_602;
                __propObject_602 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_601 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(__propObject_602);

                value = __value_601;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.DOMPointInit, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_603 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_604 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_603, "value", __propObject_604);
            return __jsUnion_603;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AddEventListenerOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AddEventListenerOptions value)
        {
            double __type_605 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_605 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AddEventListenerOptions __value_606;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_607 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_606 = new global::Natrix.StdWeb.AddEventListenerOptions(__res_607);

                value = __value_606;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AddEventListenerOptions>.ToJS(global::Natrix.StdWeb.AddEventListenerOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_608 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_609;
            __marshalledValue_609 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_608, "value", __marshalledValue_609);
            return __jsUnion_608;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.EventListenerOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.EventListenerOptions value)
        {
            double __type_610 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_610 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.EventListenerOptions __value_611;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_612 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_611 = new global::Natrix.StdWeb.EventListenerOptions(__res_612);

                value = __value_611;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.EventListenerOptions>.ToJS(global::Natrix.StdWeb.EventListenerOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_613 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_614;
            __marshalledValue_614 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_613, "value", __marshalledValue_614);
            return __jsUnion_613;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_615 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_615 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> __value_616;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_617;
                __propObject_617 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_616 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(__propObject_617);

                value = __value_616;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Request, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_618 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_619 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_618, "value", __propObject_619);
            return __jsUnion_618;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.DigitalCredentialPresentationProtocol value)
        {
            double __type_620 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_620 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.DigitalCredentialPresentationProtocol __value_621;
                string __res_622 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_621 = global::Natrix.StdWeb.DigitalCredentialPresentationProtocol.Create(__res_622);

                value = __value_621;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DigitalCredentialPresentationProtocol>.ToJS(global::Natrix.StdWeb.DigitalCredentialPresentationProtocol input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_623 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_624;
            __marshalledValue_624 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_623, "value", __marshalledValue_624);
            return __jsUnion_623;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol value)
        {
            double __type_625 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_625 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol __value_626;
                string __res_627 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_626 = global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol.Create(__res_627);

                value = __value_626;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol>.ToJS(global::Natrix.StdWeb.DigitalCredentialIssuanceProtocol input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_628 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_629;
            __marshalledValue_629 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_628, "value", __marshalledValue_629);
            return __jsUnion_628;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CollectedClientAdditionalPaymentData>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CollectedClientAdditionalPaymentData value)
        {
            double __type_630 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_630 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CollectedClientAdditionalPaymentData __value_631;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_632 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_631 = new global::Natrix.StdWeb.CollectedClientAdditionalPaymentData(__res_632);

                value = __value_631;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CollectedClientAdditionalPaymentData>.ToJS(global::Natrix.StdWeb.CollectedClientAdditionalPaymentData input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_633 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_634;
            __marshalledValue_634 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_633, "value", __marshalledValue_634);
            return __jsUnion_633;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData value)
        {
            double __type_635 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_635 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData __value_636;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_637 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_636 = new global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData(__res_637);

                value = __value_636;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData>.ToJS(global::Natrix.StdWeb.CollectedClientAdditionalPaymentRegistrationData input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_638 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_639;
            __marshalledValue_639 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_638, "value", __marshalledValue_639);
            return __jsUnion_638;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_640 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_640 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor> __value_641;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_642;
                __propObject_642 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_641 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor>(__propObject_642);

                value = __value_641;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessage, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_643 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_644 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_643, "value", __propObject_644);
            return __jsUnion_643;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_645 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_645 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor> __value_646;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_647;
                __propObject_647 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_646 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>(__propObject_647);

                value = __value_646;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.LanguageModelMessageContent, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_648 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_649 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_648, "value", __propObject_649);
            return __jsUnion_648;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioBuffer>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AudioBuffer value)
        {
            double __type_650 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_650 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AudioBuffer __value_651;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_652 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_651 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioBuffer>(__res_652);

                value = __value_651;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioBuffer>.ToJS(global::Natrix.StdWeb.AudioBuffer input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_653 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_654;
            __marshalledValue_654 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_653, "value", __marshalledValue_654);
            return __jsUnion_653;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainULongRange>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ConstrainULongRange value)
        {
            double __type_655 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_655 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ConstrainULongRange __value_656;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_657 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_656 = new global::Natrix.StdWeb.ConstrainULongRange(__res_657);

                value = __value_656;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainULongRange>.ToJS(global::Natrix.StdWeb.ConstrainULongRange input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_658 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_659;
            __marshalledValue_659 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_658, "value", __marshalledValue_659);
            return __jsUnion_658;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainDoubleRange>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ConstrainDoubleRange value)
        {
            double __type_660 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_660 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ConstrainDoubleRange __value_661;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_662 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_661 = new global::Natrix.StdWeb.ConstrainDoubleRange(__res_662);

                value = __value_661;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainDoubleRange>.ToJS(global::Natrix.StdWeb.ConstrainDoubleRange input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_663 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_664;
            __marshalledValue_664 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_663, "value", __marshalledValue_664);
            return __jsUnion_663;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainDOMStringParameters>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ConstrainDOMStringParameters value)
        {
            double __type_665 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_665 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ConstrainDOMStringParameters __value_666;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_667 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_666 = new global::Natrix.StdWeb.ConstrainDOMStringParameters(__res_667);

                value = __value_666;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainDOMStringParameters>.ToJS(global::Natrix.StdWeb.ConstrainDOMStringParameters input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_668 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_669;
            __marshalledValue_669 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_668, "value", __marshalledValue_669);
            return __jsUnion_668;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters value)
        {
            double __type_670 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_670 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters __value_671;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_672 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_671 = new global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters(__res_672);

                value = __value_671;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters>.ToJS(global::Natrix.StdWeb.ConstrainBooleanOrDOMStringParameters input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_673 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_674;
            __marshalledValue_674 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_673, "value", __marshalledValue_674);
            return __jsUnion_673;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainBooleanParameters>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ConstrainBooleanParameters value)
        {
            double __type_675 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_675 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ConstrainBooleanParameters __value_676;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_677 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_676 = new global::Natrix.StdWeb.ConstrainBooleanParameters(__res_677);

                value = __value_676;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainBooleanParameters>.ToJS(global::Natrix.StdWeb.ConstrainBooleanParameters input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_678 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_679;
            __marshalledValue_679 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_678, "value", __marshalledValue_679);
            return __jsUnion_678;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_680 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_680 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor> __value_681;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_682;
                __propObject_682 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_681 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor>(__propObject_682);

                value = __value_681;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Point2D, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_683 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_684 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_683, "value", __propObject_684);
            return __jsUnion_683;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainPoint2DParameters>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ConstrainPoint2DParameters value)
        {
            double __type_685 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_685 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ConstrainPoint2DParameters __value_686;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_687 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_686 = new global::Natrix.StdWeb.ConstrainPoint2DParameters(__res_687);

                value = __value_686;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ConstrainPoint2DParameters>.ToJS(global::Natrix.StdWeb.ConstrainPoint2DParameters input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_688 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_689;
            __marshalledValue_689 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_688, "value", __marshalledValue_689);
            return __jsUnion_688;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaTrackConstraints>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MediaTrackConstraints value)
        {
            double __type_690 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_690 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MediaTrackConstraints __value_691;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_692 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_691 = new global::Natrix.StdWeb.MediaTrackConstraints(__res_692);

                value = __value_691;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaTrackConstraints>.ToJS(global::Natrix.StdWeb.MediaTrackConstraints input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_693 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_694;
            __marshalledValue_694 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_693, "value", __marshalledValue_694);
            return __jsUnion_693;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WriteParams>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.WriteParams value)
        {
            double __type_695 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_695 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.WriteParams __value_696;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_697 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_696 = new global::Natrix.StdWeb.WriteParams(__res_697);

                value = __value_696;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WriteParams>.ToJS(global::Natrix.StdWeb.WriteParams input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_698 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_699;
            __marshalledValue_699 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_698, "value", __marshalledValue_699);
            return __jsUnion_698;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WellKnownDirectory>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.WellKnownDirectory value)
        {
            double __type_700 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_700 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.WellKnownDirectory __value_701;
                string __res_702 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_701 = global::Natrix.StdWeb.WellKnownDirectory.Create(__res_702);

                value = __value_701;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.WellKnownDirectory>.ToJS(global::Natrix.StdWeb.WellKnownDirectory input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_703 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_704;
            __marshalledValue_704 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_703, "value", __marshalledValue_704);
            return __jsUnion_703;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FileSystemHandle>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.FileSystemHandle value)
        {
            double __type_705 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_705 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.FileSystemHandle __value_706;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_707 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_706 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileSystemHandle>(__res_707);

                value = __value_706;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FileSystemHandle>.ToJS(global::Natrix.StdWeb.FileSystemHandle input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_708 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_709;
            __marshalledValue_709 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_708, "value", __marshalledValue_709);
            return __jsUnion_708;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaList>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MediaList value)
        {
            double __type_710 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_710 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MediaList __value_711;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_712 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_711 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaList>(__res_712);

                value = __value_711;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MediaList>.ToJS(global::Natrix.StdWeb.MediaList input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_713 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_714;
            __marshalledValue_714 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_713, "value", __marshalledValue_714);
            return __jsUnion_713;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AnimationEffect>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AnimationEffect value)
        {
            double __type_715 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_715 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AnimationEffect __value_716;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_717 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_716 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationEffect>(__res_717);

                value = __value_716;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AnimationEffect>.ToJS(global::Natrix.StdWeb.AnimationEffect input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_718 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_719;
            __marshalledValue_719 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_718, "value", __marshalledValue_719);
            return __jsUnion_718;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_720 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_720 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor> __value_721;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_722;
                __propObject_722 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_721 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor>(__propObject_722);

                value = __value_721;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.AnimationEffect, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_723 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_724 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_723, "value", __propObject_724);
            return __jsUnion_723;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SharedWorkerOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SharedWorkerOptions value)
        {
            double __type_725 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_725 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SharedWorkerOptions __value_726;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_727 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_726 = new global::Natrix.StdWeb.SharedWorkerOptions(__res_727);

                value = __value_726;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SharedWorkerOptions>.ToJS(global::Natrix.StdWeb.SharedWorkerOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_728 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_729;
            __marshalledValue_729 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_728, "value", __marshalledValue_729);
            return __jsUnion_728;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterRule>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RouterRule value)
        {
            double __type_730 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_730 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RouterRule __value_731;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_732 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_731 = new global::Natrix.StdWeb.RouterRule(__res_732);

                value = __value_731;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterRule>.ToJS(global::Natrix.StdWeb.RouterRule input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_733 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_734;
            __marshalledValue_734 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_733, "value", __marshalledValue_734);
            return __jsUnion_733;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_735 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_735 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor> __value_736;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_737;
                __propObject_737 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_736 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor>(__propObject_737);

                value = __value_736;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.RouterRule, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_738 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_739 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_738, "value", __propObject_739);
            return __jsUnion_738;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterSourceDict>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RouterSourceDict value)
        {
            double __type_740 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_740 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RouterSourceDict __value_741;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_742 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_741 = new global::Natrix.StdWeb.RouterSourceDict(__res_742);

                value = __value_741;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterSourceDict>.ToJS(global::Natrix.StdWeb.RouterSourceDict input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_743 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_744;
            __marshalledValue_744 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_743, "value", __marshalledValue_744);
            return __jsUnion_743;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterSourceEnum>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RouterSourceEnum value)
        {
            double __type_745 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_745 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RouterSourceEnum __value_746;
                string __res_747 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_746 = global::Natrix.StdWeb.RouterSourceEnum.Create(__res_747);

                value = __value_746;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RouterSourceEnum>.ToJS(global::Natrix.StdWeb.RouterSourceEnum input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_748 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_749;
            __marshalledValue_749 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_748, "value", __marshalledValue_749);
            return __jsUnion_748;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLPattern>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.URLPattern value)
        {
            double __type_750 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_750 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.URLPattern __value_751;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_752 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_751 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.URLPattern>(__res_752);

                value = __value_751;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.URLPattern>.ToJS(global::Natrix.StdWeb.URLPattern input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_753 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_754;
            __marshalledValue_754 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_753, "value", __marshalledValue_754);
            return __jsUnion_753;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Client>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Client value)
        {
            double __type_755 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_755 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Client __value_756;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_757 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_756 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Client>(__res_757);

                value = __value_756;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Client>.ToJS(global::Natrix.StdWeb.Client input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_758 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_759;
            __marshalledValue_759 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_758, "value", __marshalledValue_759);
            return __jsUnion_758;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ServiceWorker>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ServiceWorker value)
        {
            double __type_760 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_760 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ServiceWorker __value_761;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_762 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_761 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ServiceWorker>(__res_762);

                value = __value_761;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ServiceWorker>.ToJS(global::Natrix.StdWeb.ServiceWorker input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_763 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_764;
            __marshalledValue_764 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_763, "value", __marshalledValue_764);
            return __jsUnion_763;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MessagePort>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.MessagePort value)
        {
            double __type_765 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_765 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.MessagePort __value_766;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_767 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_766 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MessagePort>(__res_767);

                value = __value_766;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.MessagePort>.ToJS(global::Natrix.StdWeb.MessagePort input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_768 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_769;
            __marshalledValue_769 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_768, "value", __marshalledValue_769);
            return __jsUnion_768;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.NDEFMessageInit>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.NDEFMessageInit value)
        {
            double __type_770 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_770 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.NDEFMessageInit __value_771;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_772 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_771 = new global::Natrix.StdWeb.NDEFMessageInit(__res_772);

                value = __value_771;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.NDEFMessageInit>.ToJS(global::Natrix.StdWeb.NDEFMessageInit input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_773 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_774;
            __marshalledValue_774 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_773, "value", __marshalledValue_774);
            return __jsUnion_773;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ObservableSubscriptionCallback>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ObservableSubscriptionCallback value)
        {
            double __type_775 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_775 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ObservableSubscriptionCallback __value_776;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_777 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_776 = new global::Natrix.StdWeb.ObservableSubscriptionCallback(__res_777);

                value = __value_776;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ObservableSubscriptionCallback>.ToJS(global::Natrix.StdWeb.ObservableSubscriptionCallback input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_778 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_779;
            __marshalledValue_779 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_778, "value", __marshalledValue_779);
            return __jsUnion_778;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SubscriptionObserver>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SubscriptionObserver value)
        {
            double __type_780 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_780 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SubscriptionObserver __value_781;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_782 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_781 = new global::Natrix.StdWeb.SubscriptionObserver(__res_782);

                value = __value_781;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SubscriptionObserver>.ToJS(global::Natrix.StdWeb.SubscriptionObserver input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_783 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_784;
            __marshalledValue_784 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_783, "value", __marshalledValue_784);
            return __jsUnion_783;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ObservableInspector>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ObservableInspector value)
        {
            double __type_785 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_785 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ObservableInspector __value_786;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_787 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_786 = new global::Natrix.StdWeb.ObservableInspector(__res_787);

                value = __value_786;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ObservableInspector>.ToJS(global::Natrix.StdWeb.ObservableInspector input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_788 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_789;
            __marshalledValue_789 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_788, "value", __marshalledValue_789);
            return __jsUnion_788;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable> value)
        {
            double __type_790 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_790 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable> __value_791;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_792;
                __propObject_792 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_791 = new global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>(__propObject_792);

                value = __value_791;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>>.ToJS(global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_793 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_794 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_793, "value", __propObject_794);
            return __jsUnion_793;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_795 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_795 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor> __value_796;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_797;
                __propObject_797 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_796 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>(__propObject_797);

                value = __value_796;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_798 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_799 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_798, "value", __propObject_799);
            return __jsUnion_798;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RemoteDocument>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RemoteDocument value)
        {
            double __type_800 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_800 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RemoteDocument __value_801;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_802 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_801 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RemoteDocument>(__res_802);

                value = __value_801;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RemoteDocument>.ToJS(global::Natrix.StdWeb.RemoteDocument input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_803 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_804;
            __marshalledValue_804 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_803, "value", __marshalledValue_804);
            return __jsUnion_803;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> value)
        {
            double __type_805 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_805 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> __value_806;
                global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_807;
                __propObject_807 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_806 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>(__propObject_807);

                value = __value_806;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor>>.ToJS(global::Natrix.JSCore.Generics.JSArray<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>, global::Natrix.StdWeb.PropertyAccessor> input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_808 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __propObject_809 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_808, "value", __propObject_809);
            return __jsUnion_808;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RdfLiteral>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RdfLiteral value)
        {
            double __type_810 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_810 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RdfLiteral __value_811;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_812 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_811 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RdfLiteral>(__res_812);

                value = __value_811;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RdfLiteral>.ToJS(global::Natrix.StdWeb.RdfLiteral input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_813 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_814;
            __marshalledValue_814 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_813, "value", __marshalledValue_814);
            return __jsUnion_813;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.JsonLdEmbed>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.JsonLdEmbed value)
        {
            double __type_815 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_815 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.JsonLdEmbed __value_816;
                string __res_817 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_816 = global::Natrix.StdWeb.JsonLdEmbed.Create(__res_817);

                value = __value_816;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.JsonLdEmbed>.ToJS(global::Natrix.StdWeb.JsonLdEmbed input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_818 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_819;
            __marshalledValue_819 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_818, "value", __marshalledValue_819);
            return __jsUnion_818;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.EffectTiming>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.EffectTiming value)
        {
            double __type_820 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_820 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.EffectTiming __value_821;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_822 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_821 = new global::Natrix.StdWeb.EffectTiming(__res_822);

                value = __value_821;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.EffectTiming>.ToJS(global::Natrix.StdWeb.EffectTiming input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_823 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_824;
            __marshalledValue_824 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_823, "value", __marshalledValue_824);
            return __jsUnion_823;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLCollection>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLCollection value)
        {
            double __type_825 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_825 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLCollection __value_826;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_827 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_826 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLCollection>(__res_827);

                value = __value_826;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLCollection>.ToJS(global::Natrix.StdWeb.HTMLCollection input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_828 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_829;
            __marshalledValue_829 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_828, "value", __marshalledValue_829);
            return __jsUnion_828;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RadioNodeList>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.RadioNodeList value)
        {
            double __type_830 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_830 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.RadioNodeList __value_831;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_832 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_831 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RadioNodeList>(__res_832);

                value = __value_831;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.RadioNodeList>.ToJS(global::Natrix.StdWeb.RadioNodeList input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_833 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_834;
            __marshalledValue_834 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_833, "value", __marshalledValue_834);
            return __jsUnion_833;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLOptionElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLOptionElement value)
        {
            double __type_835 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_835 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLOptionElement __value_836;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_837 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_836 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLOptionElement>(__res_837);

                value = __value_836;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLOptionElement>.ToJS(global::Natrix.StdWeb.HTMLOptionElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_838 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_839;
            __marshalledValue_839 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_838, "value", __marshalledValue_839);
            return __jsUnion_838;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLOptGroupElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLOptGroupElement value)
        {
            double __type_840 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_840 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLOptGroupElement __value_841;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_842 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_841 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLOptGroupElement>(__res_842);

                value = __value_841;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLOptGroupElement>.ToJS(global::Natrix.StdWeb.HTMLOptGroupElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_843 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_844;
            __marshalledValue_844 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_843, "value", __marshalledValue_844);
            return __jsUnion_843;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLElement>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.HTMLElement value)
        {
            double __type_845 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_845 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.HTMLElement __value_846;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_847 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_846 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLElement>(__res_847);

                value = __value_846;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.HTMLElement>.ToJS(global::Natrix.StdWeb.HTMLElement input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_848 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_849;
            __marshalledValue_849 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_848, "value", __marshalledValue_849);
            return __jsUnion_848;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<int>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out int value)
        {
            double __type_850 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_850 != 2)
            {
                value = default;
                return false;
            }

            try
            {
                int __value_851;
                double __res_852 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "value");
                __value_851 = Convert.ToInt32(__res_852);

                value = __value_851;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<int>.ToJS(int input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_853 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            double __marshalledValue_854;
            __marshalledValue_854 = Convert.ToDouble(input);
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2(__jsUnion_853, "value", __marshalledValue_854);
            return __jsUnion_853;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.VideoTrack>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.VideoTrack value)
        {
            double __type_855 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_855 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.VideoTrack __value_856;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_857 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_856 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VideoTrack>(__res_857);

                value = __value_856;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.VideoTrack>.ToJS(global::Natrix.StdWeb.VideoTrack input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_858 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_859;
            __marshalledValue_859 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_858, "value", __marshalledValue_859);
            return __jsUnion_858;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioTrack>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AudioTrack value)
        {
            double __type_860 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_860 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AudioTrack __value_861;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_862 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_861 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioTrack>(__res_862);

                value = __value_861;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioTrack>.ToJS(global::Natrix.StdWeb.AudioTrack input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_863 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_864;
            __marshalledValue_864 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_863, "value", __marshalledValue_864);
            return __jsUnion_863;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TextTrack>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.TextTrack value)
        {
            double __type_865 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_865 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.TextTrack __value_866;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_867 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_866 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrack>(__res_867);

                value = __value_866;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.TextTrack>.ToJS(global::Natrix.StdWeb.TextTrack input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_868 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_869;
            __marshalledValue_869 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_868, "value", __marshalledValue_869);
            return __jsUnion_868;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Path2D>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Path2D value)
        {
            double __type_870 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_870 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Path2D __value_871;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_872 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_871 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Path2D>(__res_872);

                value = __value_871;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Path2D>.ToJS(global::Natrix.StdWeb.Path2D input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_873 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_874;
            __marshalledValue_874 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_873, "value", __marshalledValue_874);
            return __jsUnion_873;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D value)
        {
            double __type_875 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_875 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D __value_876;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_877 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_876 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>(__res_877);

                value = __value_876;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D>.ToJS(global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_878 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_879;
            __marshalledValue_879 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_878, "value", __marshalledValue_879);
            return __jsUnion_878;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Event>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Event value)
        {
            double __type_880 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_880 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Event __value_881;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_882 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_881 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Event>(__res_882);

                value = __value_881;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Event>.ToJS(global::Natrix.StdWeb.Event input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_883 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_884;
            __marshalledValue_884 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_883, "value", __marshalledValue_884);
            return __jsUnion_883;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Sanitizer>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Sanitizer value)
        {
            double __type_885 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_885 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Sanitizer __value_886;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_887 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_886 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Sanitizer>(__res_887);

                value = __value_886;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Sanitizer>.ToJS(global::Natrix.StdWeb.Sanitizer input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_888 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_889;
            __marshalledValue_889 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_888, "value", __marshalledValue_889);
            return __jsUnion_888;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerConfig>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SanitizerConfig value)
        {
            double __type_890 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_890 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SanitizerConfig __value_891;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_892 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_891 = new global::Natrix.StdWeb.SanitizerConfig(__res_892);

                value = __value_891;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerConfig>.ToJS(global::Natrix.StdWeb.SanitizerConfig input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_893 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_894;
            __marshalledValue_894 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_893, "value", __marshalledValue_894);
            return __jsUnion_893;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerPresets>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SanitizerPresets value)
        {
            double __type_895 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_895 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SanitizerPresets __value_896;
                string __res_897 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_896 = global::Natrix.StdWeb.SanitizerPresets.Create(__res_897);

                value = __value_896;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerPresets>.ToJS(global::Natrix.StdWeb.SanitizerPresets input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_898 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_899;
            __marshalledValue_899 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_898, "value", __marshalledValue_899);
            return __jsUnion_898;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes value)
        {
            double __type_900 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_900 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes __value_901;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_902 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_901 = new global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes(__res_902);

                value = __value_901;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes>.ToJS(global::Natrix.StdWeb.SanitizerElementNamespaceWithAttributes input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_903 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_904;
            __marshalledValue_904 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_903, "value", __marshalledValue_904);
            return __jsUnion_903;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerElementNamespace>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SanitizerElementNamespace value)
        {
            double __type_905 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_905 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SanitizerElementNamespace __value_906;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_907 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_906 = new global::Natrix.StdWeb.SanitizerElementNamespace(__res_907);

                value = __value_906;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerElementNamespace>.ToJS(global::Natrix.StdWeb.SanitizerElementNamespace input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_908 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_909;
            __marshalledValue_909 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_908, "value", __marshalledValue_909);
            return __jsUnion_908;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerProcessingInstruction>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SanitizerProcessingInstruction value)
        {
            double __type_910 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_910 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SanitizerProcessingInstruction __value_911;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_912 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_911 = new global::Natrix.StdWeb.SanitizerProcessingInstruction(__res_912);

                value = __value_911;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerProcessingInstruction>.ToJS(global::Natrix.StdWeb.SanitizerProcessingInstruction input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_913 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_914;
            __marshalledValue_914 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_913, "value", __marshalledValue_914);
            return __jsUnion_913;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerAttributeNamespace>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.SanitizerAttributeNamespace value)
        {
            double __type_915 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_915 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.SanitizerAttributeNamespace __value_916;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_917 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_916 = new global::Natrix.StdWeb.SanitizerAttributeNamespace(__res_917);

                value = __value_916;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.SanitizerAttributeNamespace>.ToJS(global::Natrix.StdWeb.SanitizerAttributeNamespace input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_918 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_919;
            __marshalledValue_919 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_918, "value", __marshalledValue_919);
            return __jsUnion_918;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Window>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.Window value)
        {
            double __type_920 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_920 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.Window __value_921;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_922 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_921 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Window>(__res_922);

                value = __value_921;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.Window>.ToJS(global::Natrix.StdWeb.Window input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_923 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_924;
            __marshalledValue_924 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_923, "value", __marshalledValue_924);
            return __jsUnion_923;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FenceEvent>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.FenceEvent value)
        {
            double __type_925 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_925 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.FenceEvent __value_926;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_927 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_926 = new global::Natrix.StdWeb.FenceEvent(__res_927);

                value = __value_926;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.FenceEvent>.ToJS(global::Natrix.StdWeb.FenceEvent input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_928 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_929;
            __marshalledValue_929 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_928, "value", __marshalledValue_929);
            return __jsUnion_928;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AutoKeyword>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AutoKeyword value)
        {
            double __type_930 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_930 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AutoKeyword __value_931;
                string __res_932 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_931 = global::Natrix.StdWeb.AutoKeyword.Create(__res_932);

                value = __value_931;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AutoKeyword>.ToJS(global::Natrix.StdWeb.AutoKeyword input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_933 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_934;
            __marshalledValue_934 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_933, "value", __marshalledValue_934);
            return __jsUnion_933;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ProcessingInstruction>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.ProcessingInstruction value)
        {
            double __type_935 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_935 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.ProcessingInstruction __value_936;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_937 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_936 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ProcessingInstruction>(__res_937);

                value = __value_936;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.ProcessingInstruction>.ToJS(global::Natrix.StdWeb.ProcessingInstruction input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_938 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_939;
            __marshalledValue_939 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_938, "value", __marshalledValue_939);
            return __jsUnion_938;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBObjectStore>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.IDBObjectStore value)
        {
            double __type_940 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_940 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.IDBObjectStore __value_941;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_942 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_941 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.IDBObjectStore>(__res_942);

                value = __value_941;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBObjectStore>.ToJS(global::Natrix.StdWeb.IDBObjectStore input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_943 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_944;
            __marshalledValue_944 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_943, "value", __marshalledValue_944);
            return __jsUnion_943;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBIndex>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.IDBIndex value)
        {
            double __type_945 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_945 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.IDBIndex __value_946;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_947 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_946 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.IDBIndex>(__res_947);

                value = __value_946;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBIndex>.ToJS(global::Natrix.StdWeb.IDBIndex input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_948 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_949;
            __marshalledValue_949 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_948, "value", __marshalledValue_949);
            return __jsUnion_948;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBCursor>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.IDBCursor value)
        {
            double __type_950 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_950 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.IDBCursor __value_951;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_952 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_951 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.IDBCursor>(__res_952);

                value = __value_951;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.IDBCursor>.ToJS(global::Natrix.StdWeb.IDBCursor input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_953 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_954;
            __marshalledValue_954 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_953, "value", __marshalledValue_954);
            return __jsUnion_953;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioSinkInfo>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AudioSinkInfo value)
        {
            double __type_955 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_955 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AudioSinkInfo __value_956;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_957 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_956 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioSinkInfo>(__res_957);

                value = __value_956;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioSinkInfo>.ToJS(global::Natrix.StdWeb.AudioSinkInfo input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_958 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_959;
            __marshalledValue_959 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_958, "value", __marshalledValue_959);
            return __jsUnion_958;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioSinkOptions>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AudioSinkOptions value)
        {
            double __type_960 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_960 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AudioSinkOptions __value_961;
                global::System.Runtime.InteropServices.JavaScript.JSObject __res_962 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2(input, "value");
                __value_961 = new global::Natrix.StdWeb.AudioSinkOptions(__res_962);

                value = __value_961;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioSinkOptions>.ToJS(global::Natrix.StdWeb.AudioSinkOptions input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_963 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            global::System.Runtime.InteropServices.JavaScript.JSObject __marshalledValue_964;
            __marshalledValue_964 = input.JSObject;
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2(__jsUnion_963, "value", __marshalledValue_964);
            return __jsUnion_963;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioContextLatencyCategory>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AudioContextLatencyCategory value)
        {
            double __type_965 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_965 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AudioContextLatencyCategory __value_966;
                string __res_967 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_966 = global::Natrix.StdWeb.AudioContextLatencyCategory.Create(__res_967);

                value = __value_966;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioContextLatencyCategory>.ToJS(global::Natrix.StdWeb.AudioContextLatencyCategory input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_968 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_969;
            __marshalledValue_969 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_968, "value", __marshalledValue_969);
            return __jsUnion_968;
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static bool global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioContextRenderSizeCategory>.TryToManaged(global::System.Runtime.InteropServices.JavaScript.JSObject input, [global::System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute(false)] out global::Natrix.StdWeb.AudioContextRenderSizeCategory value)
        {
            double __type_970 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2(input, "type");
            if (__type_970 != 7)
            {
                value = default;
                return false;
            }

            try
            {
                global::Natrix.StdWeb.AudioContextRenderSizeCategory __value_971;
                string __res_972 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2(input, "value");
                __value_971 = global::Natrix.StdWeb.AudioContextRenderSizeCategory.Create(__res_972);

                value = __value_971;
                return true;
            }
            catch
            {
                value = default;
                return false;
            }
        }

        [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
        static global::System.Runtime.InteropServices.JavaScript.JSObject global::Natrix.JSCore.Generics.IUnionTypeMarshaller<global::Natrix.StdWeb.AudioContextRenderSizeCategory>.ToJS(global::Natrix.StdWeb.AudioContextRenderSizeCategory input)
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject __jsUnion_973 = ConstructObject(global::System.Runtime.InteropServices.JavaScript.JSHost.GlobalThis, "Object");
            string __marshalledValue_974;
            __marshalledValue_974 = input.ToString();
            global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2(__jsUnion_973, "value", __marshalledValue_974);
            return __jsUnion_973;
        }
    }
}

#nullable disable