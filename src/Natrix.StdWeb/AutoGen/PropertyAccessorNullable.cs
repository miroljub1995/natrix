// ReSharper disable All

namespace Natrix.StdWeb;

#nullable enable

public class PropertyAccessorNullable:
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Node?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPlaneOrientation?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<string?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRLightEstimate?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCPUDepthInformation?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRJointPose?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewerPose?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPose?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRBody?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDepthType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<float?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Float32Array?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventHandlerNonNull?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayState?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorker?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HandwritingRecognizerQueryResult?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Gamepad?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Selection?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VisualViewport?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Event?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PortalHost?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Window?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Element?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Fence?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnErrorEventHandlerNonNull?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleValue?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSUnparsedValue?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Attr?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ShadowRoot?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementRegistry?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSPseudoElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransition?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLSlotElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<double?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCamera?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGSVGElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGMatrix?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleSheet?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGTransform?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaretPosition?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DocumentType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Location?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLHeadElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WindowClient?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaMetadata?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUAdapter?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUError?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureViewDimension?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUColorTargetState?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureFormat?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUCanvasConfiguration?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLContextAttributes?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShader?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLActiveInfo?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShaderPrecisionFormat?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLUniformLocation?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Document?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransfer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLTexture?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLDepthInformation?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStreamBYOBRequest?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Uint8Array?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaStreamTrack?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDtlsTransport?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpCapabilities?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDTMFSender?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TrustedTypePolicy?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NotRestoredReasons?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLFormElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileList?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLDataListElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeList?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemEntry?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemHandle?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.File?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationEffect?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTimeline?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTrigger?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GroupEffect?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRRigidTransform?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMPointReadOnly?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLLayer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CookieListItem?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<long?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URLPatternResult?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeys?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaError?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRect?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EditContext?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventTarget?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSessionDescription?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSctpTransport?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceComponent?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceProtocol?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidateType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidate?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidatePair?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceParameters?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<int?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GamepadPose?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebTransportSendGroup?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Headers?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGPathSegment?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationRequest?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationReceiver?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AbortSignal?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStream?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSTransition?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaptureHandle?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Credential?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioSampleFormat?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoPixelFormat?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectReadOnly?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoColorPrimaries?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ImageTrack?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectInit?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothDevice?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.DataView?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.UserIdleState?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ScreenIdleState?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTexture?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.ArrayBuffer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventAcceleration?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRate?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CanvasPattern?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Touch?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSAnimation?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSKeyframeRule?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSRule?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeFilter?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReportBody?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ContactAddress?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentShippingType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRHand?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRSpace?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LanguageModelParams?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URL?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLFramebuffer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewport?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WritableStream?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Client?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Response?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushSubscription?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushMessageData?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Notification?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.USBConfiguration?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LoadDocumentCallback?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeyStatus?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioTrack?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SourceBuffer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTrack?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrack?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCueList?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCue?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableCaptionElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableSectionElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLOptionElement?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementConstructor?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransferItem?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationTransition?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationActivation?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FormData?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Plugin?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MimeType?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Storage?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPosition?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPositionError?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FencedFrameConfig?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLQuery?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLSync?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VTTRegion?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransitionUpdateCallback?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MIDIPort?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMException?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.IDBTransaction?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ChildBreakToken?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioBuffer?>,
    global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RefillCallback?>
{
    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Node? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Node?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Node? __element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_0 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_0 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Node>(___notNullable_1);
        }
        return __element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Node? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Node?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Node? __element_0;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_0 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_0 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Node>(___notNullable_1);
        }
        return __element_0;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Node?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Node? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Node ___notNullable_1 = (global::Natrix.StdWeb.Node)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Node?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Node? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Node ___notNullable_1 = (global::Natrix.StdWeb.Node)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRPlaneOrientation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPlaneOrientation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRPlaneOrientation? __element_1;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_1 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_1 = global::Natrix.StdWeb.XRPlaneOrientation.Create(___notNullable_1);
        }
        return __element_1;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRPlaneOrientation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPlaneOrientation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRPlaneOrientation? __element_1;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_1 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_1 = global::Natrix.StdWeb.XRPlaneOrientation.Create(___notNullable_1);
        }
        return __element_1;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPlaneOrientation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRPlaneOrientation? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRPlaneOrientation ___notNullable_1 = (global::Natrix.StdWeb.XRPlaneOrientation)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPlaneOrientation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRPlaneOrientation? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRPlaneOrientation ___notNullable_1 = (global::Natrix.StdWeb.XRPlaneOrientation)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static string? global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        string? __element_2;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_2 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_2 = ___notNullable_1;
        }
        return __element_2;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static string? global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        string? __element_2;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_2 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_2 = ___notNullable_1;
        }
        return __element_2;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, string? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            string ___notNullable_1 = (string)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<string?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, string? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            string ___notNullable_1 = (string)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRLightEstimate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRLightEstimate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRLightEstimate? __element_3;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_3 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_3 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRLightEstimate>(___notNullable_1);
        }
        return __element_3;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRLightEstimate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRLightEstimate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRLightEstimate? __element_3;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_3 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_3 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRLightEstimate>(___notNullable_1);
        }
        return __element_3;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRLightEstimate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRLightEstimate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRLightEstimate ___notNullable_1 = (global::Natrix.StdWeb.XRLightEstimate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRLightEstimate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRLightEstimate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRLightEstimate ___notNullable_1 = (global::Natrix.StdWeb.XRLightEstimate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRCPUDepthInformation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCPUDepthInformation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRCPUDepthInformation? __element_4;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_4 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_4 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRCPUDepthInformation>(___notNullable_1);
        }
        return __element_4;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRCPUDepthInformation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCPUDepthInformation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRCPUDepthInformation? __element_4;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_4 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_4 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRCPUDepthInformation>(___notNullable_1);
        }
        return __element_4;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCPUDepthInformation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRCPUDepthInformation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRCPUDepthInformation ___notNullable_1 = (global::Natrix.StdWeb.XRCPUDepthInformation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCPUDepthInformation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRCPUDepthInformation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRCPUDepthInformation ___notNullable_1 = (global::Natrix.StdWeb.XRCPUDepthInformation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRJointPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRJointPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRJointPose? __element_5;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_5 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_5 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRJointPose>(___notNullable_1);
        }
        return __element_5;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRJointPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRJointPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRJointPose? __element_5;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_5 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_5 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRJointPose>(___notNullable_1);
        }
        return __element_5;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRJointPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRJointPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRJointPose ___notNullable_1 = (global::Natrix.StdWeb.XRJointPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRJointPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRJointPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRJointPose ___notNullable_1 = (global::Natrix.StdWeb.XRJointPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRViewerPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewerPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRViewerPose? __element_6;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_6 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_6 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRViewerPose>(___notNullable_1);
        }
        return __element_6;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRViewerPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewerPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRViewerPose? __element_6;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_6 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_6 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRViewerPose>(___notNullable_1);
        }
        return __element_6;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewerPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRViewerPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRViewerPose ___notNullable_1 = (global::Natrix.StdWeb.XRViewerPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewerPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRViewerPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRViewerPose ___notNullable_1 = (global::Natrix.StdWeb.XRViewerPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRPose? __element_7;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_7 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_7 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRPose>(___notNullable_1);
        }
        return __element_7;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRPose? __element_7;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_7 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_7 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRPose>(___notNullable_1);
        }
        return __element_7;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRPose ___notNullable_1 = (global::Natrix.StdWeb.XRPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRPose ___notNullable_1 = (global::Natrix.StdWeb.XRPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRBody? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRBody?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRBody? __element_8;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_8 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_8 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRBody>(___notNullable_1);
        }
        return __element_8;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRBody? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRBody?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRBody? __element_8;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_8 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_8 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRBody>(___notNullable_1);
        }
        return __element_8;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRBody?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRBody? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRBody ___notNullable_1 = (global::Natrix.StdWeb.XRBody)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRBody?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRBody? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRBody ___notNullable_1 = (global::Natrix.StdWeb.XRBody)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRDepthType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDepthType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRDepthType? __element_9;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_9 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_9 = global::Natrix.StdWeb.XRDepthType.Create(___notNullable_1);
        }
        return __element_9;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRDepthType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDepthType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRDepthType? __element_9;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_9 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_9 = global::Natrix.StdWeb.XRDepthType.Create(___notNullable_1);
        }
        return __element_9;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDepthType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRDepthType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRDepthType ___notNullable_1 = (global::Natrix.StdWeb.XRDepthType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDepthType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRDepthType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRDepthType ___notNullable_1 = (global::Natrix.StdWeb.XRDepthType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static bool? global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        bool? __element_10;
        bool? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_10 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)___res_0;
            __element_10 = ___notNullable_1;
        }
        return __element_10;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static bool? global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        bool? __element_10;
        bool? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsBooleanV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_10 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)___res_0;
            __element_10 = ___notNullable_1;
        }
        return __element_10;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, bool? value)
    {
        bool? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<bool?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, bool? value)
    {
        bool? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            bool ___notNullable_1 = (bool)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsBooleanV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static float? global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        float? __element_11;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_11 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_11 = Convert.ToSingle(___notNullable_1);
        }
        return __element_11;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static float? global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        float? __element_11;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_11 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_11 = Convert.ToSingle(___notNullable_1);
        }
        return __element_11;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, float? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            float ___notNullable_1 = (float)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<float?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, float? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            float ___notNullable_1 = (float)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Float32Array? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Float32Array?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Float32Array? __element_12;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_12 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_12 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Float32Array>(___notNullable_1);
        }
        return __element_12;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Float32Array? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Float32Array?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Float32Array? __element_12;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_12 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_12 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Float32Array>(___notNullable_1);
        }
        return __element_12;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Float32Array?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Float32Array? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.Float32Array ___notNullable_1 = (global::Natrix.JSCore.Float32Array)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Float32Array?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Float32Array? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.Float32Array ___notNullable_1 = (global::Natrix.JSCore.Float32Array)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.EventHandlerNonNull? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventHandlerNonNull?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.EventHandlerNonNull? __element_13;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_13 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_13 = new global::Natrix.StdWeb.EventHandlerNonNull(___notNullable_1);
        }
        return __element_13;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.EventHandlerNonNull? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventHandlerNonNull?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.EventHandlerNonNull? __element_13;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_13 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_13 = new global::Natrix.StdWeb.EventHandlerNonNull(___notNullable_1);
        }
        return __element_13;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventHandlerNonNull?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.EventHandlerNonNull? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.EventHandlerNonNull ___notNullable_1 = (global::Natrix.StdWeb.EventHandlerNonNull)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventHandlerNonNull?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.EventHandlerNonNull? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.EventHandlerNonNull ___notNullable_1 = (global::Natrix.StdWeb.EventHandlerNonNull)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRDOMOverlayState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRDOMOverlayState? __element_14;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_14 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_14 = new global::Natrix.StdWeb.XRDOMOverlayState(___notNullable_1);
        }
        return __element_14;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRDOMOverlayState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRDOMOverlayState? __element_14;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_14 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_14 = new global::Natrix.StdWeb.XRDOMOverlayState(___notNullable_1);
        }
        return __element_14;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRDOMOverlayState? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRDOMOverlayState ___notNullable_1 = (global::Natrix.StdWeb.XRDOMOverlayState)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRDOMOverlayState? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRDOMOverlayState ___notNullable_1 = (global::Natrix.StdWeb.XRDOMOverlayState)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ServiceWorker? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorker?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ServiceWorker? __element_15;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_15 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_15 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ServiceWorker>(___notNullable_1);
        }
        return __element_15;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ServiceWorker? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorker?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ServiceWorker? __element_15;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_15 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_15 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ServiceWorker>(___notNullable_1);
        }
        return __element_15;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorker?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ServiceWorker? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ServiceWorker ___notNullable_1 = (global::Natrix.StdWeb.ServiceWorker)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorker?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ServiceWorker? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ServiceWorker ___notNullable_1 = (global::Natrix.StdWeb.ServiceWorker)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaKeySystemAccess? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MediaKeySystemAccess? __element_16;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_16 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_16 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaKeySystemAccess>(___notNullable_1);
        }
        return __element_16;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaKeySystemAccess? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MediaKeySystemAccess? __element_16;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_16 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_16 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaKeySystemAccess>(___notNullable_1);
        }
        return __element_16;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MediaKeySystemAccess? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeySystemAccess ___notNullable_1 = (global::Natrix.StdWeb.MediaKeySystemAccess)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeySystemAccess?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MediaKeySystemAccess? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeySystemAccess ___notNullable_1 = (global::Natrix.StdWeb.MediaKeySystemAccess)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HandwritingRecognizerQueryResult? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HandwritingRecognizerQueryResult?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HandwritingRecognizerQueryResult? __element_17;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_17 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_17 = new global::Natrix.StdWeb.HandwritingRecognizerQueryResult(___notNullable_1);
        }
        return __element_17;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HandwritingRecognizerQueryResult? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HandwritingRecognizerQueryResult?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HandwritingRecognizerQueryResult? __element_17;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_17 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_17 = new global::Natrix.StdWeb.HandwritingRecognizerQueryResult(___notNullable_1);
        }
        return __element_17;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HandwritingRecognizerQueryResult?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HandwritingRecognizerQueryResult? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HandwritingRecognizerQueryResult ___notNullable_1 = (global::Natrix.StdWeb.HandwritingRecognizerQueryResult)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HandwritingRecognizerQueryResult?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HandwritingRecognizerQueryResult? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HandwritingRecognizerQueryResult ___notNullable_1 = (global::Natrix.StdWeb.HandwritingRecognizerQueryResult)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Gamepad? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Gamepad?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Gamepad? __element_18;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_18 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_18 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Gamepad>(___notNullable_1);
        }
        return __element_18;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Gamepad? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Gamepad?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Gamepad? __element_18;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_18 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_18 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Gamepad>(___notNullable_1);
        }
        return __element_18;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Gamepad?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Gamepad? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Gamepad ___notNullable_1 = (global::Natrix.StdWeb.Gamepad)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Gamepad?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Gamepad? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Gamepad ___notNullable_1 = (global::Natrix.StdWeb.Gamepad)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Selection? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Selection?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Selection? __element_19;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_19 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_19 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Selection>(___notNullable_1);
        }
        return __element_19;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Selection? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Selection?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Selection? __element_19;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_19 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_19 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Selection>(___notNullable_1);
        }
        return __element_19;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Selection?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Selection? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Selection ___notNullable_1 = (global::Natrix.StdWeb.Selection)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Selection?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Selection? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Selection ___notNullable_1 = (global::Natrix.StdWeb.Selection)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VisualViewport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VisualViewport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VisualViewport? __element_20;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_20 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_20 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VisualViewport>(___notNullable_1);
        }
        return __element_20;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VisualViewport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VisualViewport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VisualViewport? __element_20;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_20 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_20 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VisualViewport>(___notNullable_1);
        }
        return __element_20;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VisualViewport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VisualViewport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VisualViewport ___notNullable_1 = (global::Natrix.StdWeb.VisualViewport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VisualViewport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VisualViewport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VisualViewport ___notNullable_1 = (global::Natrix.StdWeb.VisualViewport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Event? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Event?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Event? __element_21;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_21 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_21 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Event>(___notNullable_1);
        }
        return __element_21;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Event? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Event?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Event? __element_21;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_21 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_21 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Event>(___notNullable_1);
        }
        return __element_21;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Event?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Event? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Event ___notNullable_1 = (global::Natrix.StdWeb.Event)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Event?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Event? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Event ___notNullable_1 = (global::Natrix.StdWeb.Event)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PortalHost? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PortalHost?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PortalHost? __element_22;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_22 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_22 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PortalHost>(___notNullable_1);
        }
        return __element_22;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PortalHost? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PortalHost?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PortalHost? __element_22;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_22 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_22 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PortalHost>(___notNullable_1);
        }
        return __element_22;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PortalHost?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PortalHost? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PortalHost ___notNullable_1 = (global::Natrix.StdWeb.PortalHost)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PortalHost?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PortalHost? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PortalHost ___notNullable_1 = (global::Natrix.StdWeb.PortalHost)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Window? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Window?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Window? __element_23;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_23 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_23 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Window>(___notNullable_1);
        }
        return __element_23;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Window? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Window?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Window? __element_23;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_23 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_23 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Window>(___notNullable_1);
        }
        return __element_23;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Window?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Window? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_1 = (global::Natrix.StdWeb.Window)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Window?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Window? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Window ___notNullable_1 = (global::Natrix.StdWeb.Window)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_24;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_24 = null;
        }
        else
        {
            __element_24 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_24;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_24;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_24 = null;
        }
        else
        {
            __element_24 = new global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_24;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Element? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Element?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Element? __element_25;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_25 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_25 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Element>(___notNullable_1);
        }
        return __element_25;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Element? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Element?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Element? __element_25;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_25 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_25 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Element>(___notNullable_1);
        }
        return __element_25;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Element?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Element? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Element ___notNullable_1 = (global::Natrix.StdWeb.Element)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Element?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Element? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Element ___notNullable_1 = (global::Natrix.StdWeb.Element)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Fence? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Fence?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Fence? __element_26;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_26 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_26 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Fence>(___notNullable_1);
        }
        return __element_26;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Fence? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Fence?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Fence? __element_26;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_26 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_26 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Fence>(___notNullable_1);
        }
        return __element_26;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Fence?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Fence? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Fence ___notNullable_1 = (global::Natrix.StdWeb.Fence)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Fence?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Fence? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Fence ___notNullable_1 = (global::Natrix.StdWeb.Fence)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.OnErrorEventHandlerNonNull? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnErrorEventHandlerNonNull?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.OnErrorEventHandlerNonNull? __element_27;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_27 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_27 = new global::Natrix.StdWeb.OnErrorEventHandlerNonNull(___notNullable_1);
        }
        return __element_27;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.OnErrorEventHandlerNonNull? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnErrorEventHandlerNonNull?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.OnErrorEventHandlerNonNull? __element_27;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_27 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_27 = new global::Natrix.StdWeb.OnErrorEventHandlerNonNull(___notNullable_1);
        }
        return __element_27;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnErrorEventHandlerNonNull?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.OnErrorEventHandlerNonNull? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.OnErrorEventHandlerNonNull ___notNullable_1 = (global::Natrix.StdWeb.OnErrorEventHandlerNonNull)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnErrorEventHandlerNonNull?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.OnErrorEventHandlerNonNull? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.OnErrorEventHandlerNonNull ___notNullable_1 = (global::Natrix.StdWeb.OnErrorEventHandlerNonNull)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull? __element_28;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_28 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_28 = new global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull(___notNullable_1);
        }
        return __element_28;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull? __element_28;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_28 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_28 = new global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull(___notNullable_1);
        }
        return __element_28;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull ___notNullable_1 = (global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull ___notNullable_1 = (global::Natrix.StdWeb.OnBeforeUnloadEventHandlerNonNull)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSStyleValue? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleValue?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSStyleValue? __element_29;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_29 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_29 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSStyleValue>(___notNullable_1);
        }
        return __element_29;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSStyleValue? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleValue?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSStyleValue? __element_29;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_29 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_29 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSStyleValue>(___notNullable_1);
        }
        return __element_29;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleValue?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSStyleValue? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSStyleValue ___notNullable_1 = (global::Natrix.StdWeb.CSSStyleValue)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleValue?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSStyleValue? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSStyleValue ___notNullable_1 = (global::Natrix.StdWeb.CSSStyleValue)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSUnparsedValue? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSUnparsedValue?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSUnparsedValue? __element_30;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_30 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_30 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSUnparsedValue>(___notNullable_1);
        }
        return __element_30;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSUnparsedValue? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSUnparsedValue?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSUnparsedValue? __element_30;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_30 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_30 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSUnparsedValue>(___notNullable_1);
        }
        return __element_30;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSUnparsedValue?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSUnparsedValue? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSUnparsedValue ___notNullable_1 = (global::Natrix.StdWeb.CSSUnparsedValue)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSUnparsedValue?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSUnparsedValue? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSUnparsedValue ___notNullable_1 = (global::Natrix.StdWeb.CSSUnparsedValue)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Attr? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Attr?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Attr? __element_31;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_31 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_31 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Attr>(___notNullable_1);
        }
        return __element_31;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Attr? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Attr?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Attr? __element_31;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_31 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_31 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Attr>(___notNullable_1);
        }
        return __element_31;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Attr?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Attr? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Attr ___notNullable_1 = (global::Natrix.StdWeb.Attr)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Attr?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Attr? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Attr ___notNullable_1 = (global::Natrix.StdWeb.Attr)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ShadowRoot? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ShadowRoot?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ShadowRoot? __element_32;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_32 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_32 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ShadowRoot>(___notNullable_1);
        }
        return __element_32;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ShadowRoot? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ShadowRoot?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ShadowRoot? __element_32;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_32 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_32 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ShadowRoot>(___notNullable_1);
        }
        return __element_32;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ShadowRoot?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ShadowRoot? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ShadowRoot ___notNullable_1 = (global::Natrix.StdWeb.ShadowRoot)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ShadowRoot?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ShadowRoot? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ShadowRoot ___notNullable_1 = (global::Natrix.StdWeb.ShadowRoot)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CustomElementRegistry? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementRegistry?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CustomElementRegistry? __element_33;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_33 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_33 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CustomElementRegistry>(___notNullable_1);
        }
        return __element_33;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CustomElementRegistry? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementRegistry?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CustomElementRegistry? __element_33;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_33 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_33 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CustomElementRegistry>(___notNullable_1);
        }
        return __element_33;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementRegistry?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CustomElementRegistry? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CustomElementRegistry ___notNullable_1 = (global::Natrix.StdWeb.CustomElementRegistry)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementRegistry?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CustomElementRegistry? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CustomElementRegistry ___notNullable_1 = (global::Natrix.StdWeb.CustomElementRegistry)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSPseudoElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSPseudoElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSPseudoElement? __element_34;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_34 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_34 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSPseudoElement>(___notNullable_1);
        }
        return __element_34;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSPseudoElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSPseudoElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSPseudoElement? __element_34;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_34 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_34 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSPseudoElement>(___notNullable_1);
        }
        return __element_34;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSPseudoElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSPseudoElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSPseudoElement ___notNullable_1 = (global::Natrix.StdWeb.CSSPseudoElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSPseudoElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSPseudoElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSPseudoElement ___notNullable_1 = (global::Natrix.StdWeb.CSSPseudoElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ViewTransition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ViewTransition? __element_35;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_35 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_35 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ViewTransition>(___notNullable_1);
        }
        return __element_35;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ViewTransition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ViewTransition? __element_35;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_35 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_35 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ViewTransition>(___notNullable_1);
        }
        return __element_35;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ViewTransition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ViewTransition ___notNullable_1 = (global::Natrix.StdWeb.ViewTransition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ViewTransition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ViewTransition ___notNullable_1 = (global::Natrix.StdWeb.ViewTransition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>? __element_36;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_36 = null;
        }
        else
        {
            __element_36 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_36;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>? __element_36;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_36 = null;
        }
        else
        {
            __element_36 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_36;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Range, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLSlotElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLSlotElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLSlotElement? __element_37;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_37 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_37 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLSlotElement>(___notNullable_1);
        }
        return __element_37;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLSlotElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLSlotElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLSlotElement? __element_37;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_37 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_37 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLSlotElement>(___notNullable_1);
        }
        return __element_37;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLSlotElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLSlotElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLSlotElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLSlotElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLSlotElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLSlotElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLSlotElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLSlotElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? __element_38;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_38 = null;
        }
        else
        {
            __element_38 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_38;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? __element_38;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_38 = null;
        }
        else
        {
            __element_38 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_38;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>? __element_39;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_39 = null;
        }
        else
        {
            __element_39 = new global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_39;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>? __element_39;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_39 = null;
        }
        else
        {
            __element_39 = new global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_39;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<string, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static double? global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        double? __element_40;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_40 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_40 = ___notNullable_1;
        }
        return __element_40;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static double? global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        double? __element_40;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_40 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_40 = ___notNullable_1;
        }
        return __element_40;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, double? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            double ___notNullable_1 = (double)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<double?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, double? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            double ___notNullable_1 = (double)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRCamera? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCamera?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRCamera? __element_41;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_41 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_41 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRCamera>(___notNullable_1);
        }
        return __element_41;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRCamera? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCamera?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRCamera? __element_41;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_41 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_41 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRCamera>(___notNullable_1);
        }
        return __element_41;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCamera?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRCamera? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRCamera ___notNullable_1 = (global::Natrix.StdWeb.XRCamera)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRCamera?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRCamera? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRCamera ___notNullable_1 = (global::Natrix.StdWeb.XRCamera)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGSVGElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGSVGElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SVGSVGElement? __element_42;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_42 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_42 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGSVGElement>(___notNullable_1);
        }
        return __element_42;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGSVGElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGSVGElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SVGSVGElement? __element_42;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_42 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_42 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGSVGElement>(___notNullable_1);
        }
        return __element_42;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGSVGElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SVGSVGElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGSVGElement ___notNullable_1 = (global::Natrix.StdWeb.SVGSVGElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGSVGElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SVGSVGElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGSVGElement ___notNullable_1 = (global::Natrix.StdWeb.SVGSVGElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SVGElement? __element_43;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_43 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_43 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGElement>(___notNullable_1);
        }
        return __element_43;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SVGElement? __element_43;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_43 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_43 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGElement>(___notNullable_1);
        }
        return __element_43;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SVGElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGElement ___notNullable_1 = (global::Natrix.StdWeb.SVGElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SVGElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGElement ___notNullable_1 = (global::Natrix.StdWeb.SVGElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGMatrix? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGMatrix?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SVGMatrix? __element_44;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_44 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_44 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGMatrix>(___notNullable_1);
        }
        return __element_44;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGMatrix? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGMatrix?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SVGMatrix? __element_44;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_44 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_44 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGMatrix>(___notNullable_1);
        }
        return __element_44;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGMatrix?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SVGMatrix? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGMatrix ___notNullable_1 = (global::Natrix.StdWeb.SVGMatrix)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGMatrix?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SVGMatrix? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGMatrix ___notNullable_1 = (global::Natrix.StdWeb.SVGMatrix)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSStyleSheet? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleSheet?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSStyleSheet? __element_45;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_45 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_45 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSStyleSheet>(___notNullable_1);
        }
        return __element_45;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSStyleSheet? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleSheet?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSStyleSheet? __element_45;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_45 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_45 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSStyleSheet>(___notNullable_1);
        }
        return __element_45;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleSheet?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSStyleSheet? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSStyleSheet ___notNullable_1 = (global::Natrix.StdWeb.CSSStyleSheet)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSStyleSheet?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSStyleSheet? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSStyleSheet ___notNullable_1 = (global::Natrix.StdWeb.CSSStyleSheet)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGTransform? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGTransform?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SVGTransform? __element_46;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_46 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_46 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGTransform>(___notNullable_1);
        }
        return __element_46;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGTransform? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGTransform?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SVGTransform? __element_46;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_46 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_46 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGTransform>(___notNullable_1);
        }
        return __element_46;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGTransform?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SVGTransform? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGTransform ___notNullable_1 = (global::Natrix.StdWeb.SVGTransform)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGTransform?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SVGTransform? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGTransform ___notNullable_1 = (global::Natrix.StdWeb.SVGTransform)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CaretPosition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaretPosition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CaretPosition? __element_47;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_47 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_47 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CaretPosition>(___notNullable_1);
        }
        return __element_47;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CaretPosition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaretPosition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CaretPosition? __element_47;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_47 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_47 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CaretPosition>(___notNullable_1);
        }
        return __element_47;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaretPosition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CaretPosition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CaretPosition ___notNullable_1 = (global::Natrix.StdWeb.CaretPosition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaretPosition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CaretPosition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CaretPosition ___notNullable_1 = (global::Natrix.StdWeb.CaretPosition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DocumentType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DocumentType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DocumentType? __element_48;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_48 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_48 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DocumentType>(___notNullable_1);
        }
        return __element_48;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DocumentType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DocumentType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DocumentType? __element_48;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_48 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_48 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DocumentType>(___notNullable_1);
        }
        return __element_48;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DocumentType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DocumentType? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DocumentType ___notNullable_1 = (global::Natrix.StdWeb.DocumentType)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DocumentType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DocumentType? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DocumentType ___notNullable_1 = (global::Natrix.StdWeb.DocumentType)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Location? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Location?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Location? __element_49;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_49 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_49 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Location>(___notNullable_1);
        }
        return __element_49;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Location? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Location?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Location? __element_49;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_49 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_49 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Location>(___notNullable_1);
        }
        return __element_49;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Location?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Location? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Location ___notNullable_1 = (global::Natrix.StdWeb.Location)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Location?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Location? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Location ___notNullable_1 = (global::Natrix.StdWeb.Location)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLElement? __element_50;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_50 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_50 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLElement>(___notNullable_1);
        }
        return __element_50;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLElement? __element_50;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_50 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_50 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLElement>(___notNullable_1);
        }
        return __element_50;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLHeadElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLHeadElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLHeadElement? __element_51;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_51 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_51 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLHeadElement>(___notNullable_1);
        }
        return __element_51;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLHeadElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLHeadElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLHeadElement? __element_51;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_51 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_51 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLHeadElement>(___notNullable_1);
        }
        return __element_51;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLHeadElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLHeadElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLHeadElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLHeadElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLHeadElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLHeadElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLHeadElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLHeadElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_52;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_52 = null;
        }
        else
        {
            __element_52 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_52;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_52;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_52 = null;
        }
        else
        {
            __element_52 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_52;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLScriptElement, global::Natrix.StdWeb.SVGScriptElement, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Runtime.InteropServices.JavaScript.JSObject? global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? __element_53;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_53 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_53 = ___notNullable_1;
        }
        return __element_53;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::System.Runtime.InteropServices.JavaScript.JSObject? global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? __element_53;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_53 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_53 = ___notNullable_1;
        }
        return __element_53;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::System.Runtime.InteropServices.JavaScript.JSObject? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::System.Runtime.InteropServices.JavaScript.JSObject?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::System.Runtime.InteropServices.JavaScript.JSObject? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)value;
            ___marshalledValue_0 = ___notNullable_1;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>? __element_54;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_54 = null;
        }
        else
        {
            __element_54 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_54;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>? __element_54;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_54 = null;
        }
        else
        {
            __element_54 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_54;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.PaymentShippingOption, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WindowClient? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WindowClient?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WindowClient? __element_55;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_55 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_55 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WindowClient>(___notNullable_1);
        }
        return __element_55;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WindowClient? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WindowClient?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WindowClient? __element_55;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_55 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_55 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WindowClient>(___notNullable_1);
        }
        return __element_55;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WindowClient?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WindowClient? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WindowClient ___notNullable_1 = (global::Natrix.StdWeb.WindowClient)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WindowClient?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WindowClient? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WindowClient ___notNullable_1 = (global::Natrix.StdWeb.WindowClient)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PaymentRequestDetailsUpdate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PaymentRequestDetailsUpdate? __element_56;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_56 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_56 = new global::Natrix.StdWeb.PaymentRequestDetailsUpdate(___notNullable_1);
        }
        return __element_56;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PaymentRequestDetailsUpdate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PaymentRequestDetailsUpdate? __element_56;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_56 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_56 = new global::Natrix.StdWeb.PaymentRequestDetailsUpdate(___notNullable_1);
        }
        return __element_56;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PaymentRequestDetailsUpdate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PaymentRequestDetailsUpdate ___notNullable_1 = (global::Natrix.StdWeb.PaymentRequestDetailsUpdate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentRequestDetailsUpdate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PaymentRequestDetailsUpdate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PaymentRequestDetailsUpdate ___notNullable_1 = (global::Natrix.StdWeb.PaymentRequestDetailsUpdate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaMetadata? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaMetadata?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MediaMetadata? __element_57;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_57 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_57 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaMetadata>(___notNullable_1);
        }
        return __element_57;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaMetadata? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaMetadata?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MediaMetadata? __element_57;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_57 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_57 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaMetadata>(___notNullable_1);
        }
        return __element_57;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaMetadata?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MediaMetadata? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaMetadata ___notNullable_1 = (global::Natrix.StdWeb.MediaMetadata)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaMetadata?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MediaMetadata? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaMetadata ___notNullable_1 = (global::Natrix.StdWeb.MediaMetadata)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>? __element_58;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_58 = null;
        }
        else
        {
            __element_58 = new global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_58;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>? __element_58;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_58 = null;
        }
        else
        {
            __element_58 = new global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_58;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<double, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUAdapter? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUAdapter?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUAdapter? __element_59;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_59 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_59 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUAdapter>(___notNullable_1);
        }
        return __element_59;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUAdapter? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUAdapter?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUAdapter? __element_59;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_59 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_59 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUAdapter>(___notNullable_1);
        }
        return __element_59;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUAdapter?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUAdapter? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUAdapter ___notNullable_1 = (global::Natrix.StdWeb.GPUAdapter)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUAdapter?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUAdapter? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUAdapter ___notNullable_1 = (global::Natrix.StdWeb.GPUAdapter)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ulong? global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        ulong? __element_60;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_60 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_60 = Convert.ToUInt64(___notNullable_1);
        }
        return __element_60;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ulong? global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        ulong? __element_60;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_60 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_60 = Convert.ToUInt64(___notNullable_1);
        }
        return __element_60;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, ulong? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ulong ___notNullable_1 = (ulong)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ulong?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, ulong? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ulong ___notNullable_1 = (ulong)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUError? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUError?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUError? __element_61;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_61 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_61 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUError>(___notNullable_1);
        }
        return __element_61;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUError? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUError?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUError? __element_61;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_61 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_61 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUError>(___notNullable_1);
        }
        return __element_61;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUError?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUError? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUError ___notNullable_1 = (global::Natrix.StdWeb.GPUError)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUError?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUError? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUError ___notNullable_1 = (global::Natrix.StdWeb.GPUError)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUTextureViewDimension? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureViewDimension?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUTextureViewDimension? __element_62;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_62 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_62 = global::Natrix.StdWeb.GPUTextureViewDimension.Create(___notNullable_1);
        }
        return __element_62;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUTextureViewDimension? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureViewDimension?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUTextureViewDimension? __element_62;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_62 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_62 = global::Natrix.StdWeb.GPUTextureViewDimension.Create(___notNullable_1);
        }
        return __element_62;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureViewDimension?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUTextureViewDimension? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUTextureViewDimension ___notNullable_1 = (global::Natrix.StdWeb.GPUTextureViewDimension)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureViewDimension?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUTextureViewDimension? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUTextureViewDimension ___notNullable_1 = (global::Natrix.StdWeb.GPUTextureViewDimension)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUBindGroupLayout? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUBindGroupLayout? __element_63;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_63 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_63 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUBindGroupLayout>(___notNullable_1);
        }
        return __element_63;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUBindGroupLayout? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUBindGroupLayout? __element_63;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_63 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_63 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUBindGroupLayout>(___notNullable_1);
        }
        return __element_63;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUBindGroupLayout? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUBindGroupLayout ___notNullable_1 = (global::Natrix.StdWeb.GPUBindGroupLayout)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUBindGroupLayout?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUBindGroupLayout? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUBindGroupLayout ___notNullable_1 = (global::Natrix.StdWeb.GPUBindGroupLayout)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUColorTargetState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUColorTargetState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUColorTargetState? __element_64;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_64 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_64 = new global::Natrix.StdWeb.GPUColorTargetState(___notNullable_1);
        }
        return __element_64;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUColorTargetState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUColorTargetState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUColorTargetState? __element_64;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_64 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_64 = new global::Natrix.StdWeb.GPUColorTargetState(___notNullable_1);
        }
        return __element_64;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUColorTargetState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUColorTargetState? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUColorTargetState ___notNullable_1 = (global::Natrix.StdWeb.GPUColorTargetState)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUColorTargetState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUColorTargetState? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUColorTargetState ___notNullable_1 = (global::Natrix.StdWeb.GPUColorTargetState)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUVertexBufferLayout? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUVertexBufferLayout? __element_65;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_65 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_65 = new global::Natrix.StdWeb.GPUVertexBufferLayout(___notNullable_1);
        }
        return __element_65;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUVertexBufferLayout? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUVertexBufferLayout? __element_65;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_65 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_65 = new global::Natrix.StdWeb.GPUVertexBufferLayout(___notNullable_1);
        }
        return __element_65;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUVertexBufferLayout? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUVertexBufferLayout ___notNullable_1 = (global::Natrix.StdWeb.GPUVertexBufferLayout)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUVertexBufferLayout?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUVertexBufferLayout? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUVertexBufferLayout ___notNullable_1 = (global::Natrix.StdWeb.GPUVertexBufferLayout)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPURenderPassColorAttachment? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPURenderPassColorAttachment? __element_66;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_66 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_66 = new global::Natrix.StdWeb.GPURenderPassColorAttachment(___notNullable_1);
        }
        return __element_66;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPURenderPassColorAttachment? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPURenderPassColorAttachment? __element_66;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_66 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_66 = new global::Natrix.StdWeb.GPURenderPassColorAttachment(___notNullable_1);
        }
        return __element_66;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPURenderPassColorAttachment? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPURenderPassColorAttachment ___notNullable_1 = (global::Natrix.StdWeb.GPURenderPassColorAttachment)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPURenderPassColorAttachment?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPURenderPassColorAttachment? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPURenderPassColorAttachment ___notNullable_1 = (global::Natrix.StdWeb.GPURenderPassColorAttachment)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUTextureFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUTextureFormat? __element_67;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_67 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_67 = global::Natrix.StdWeb.GPUTextureFormat.Create(___notNullable_1);
        }
        return __element_67;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUTextureFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUTextureFormat? __element_67;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_67 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_67 = global::Natrix.StdWeb.GPUTextureFormat.Create(___notNullable_1);
        }
        return __element_67;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUTextureFormat? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUTextureFormat ___notNullable_1 = (global::Natrix.StdWeb.GPUTextureFormat)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTextureFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUTextureFormat? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUTextureFormat ___notNullable_1 = (global::Natrix.StdWeb.GPUTextureFormat)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUCanvasConfiguration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUCanvasConfiguration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUCanvasConfiguration? __element_68;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_68 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_68 = new global::Natrix.StdWeb.GPUCanvasConfiguration(___notNullable_1);
        }
        return __element_68;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUCanvasConfiguration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUCanvasConfiguration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUCanvasConfiguration? __element_68;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_68 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_68 = new global::Natrix.StdWeb.GPUCanvasConfiguration(___notNullable_1);
        }
        return __element_68;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUCanvasConfiguration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUCanvasConfiguration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUCanvasConfiguration ___notNullable_1 = (global::Natrix.StdWeb.GPUCanvasConfiguration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUCanvasConfiguration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUCanvasConfiguration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUCanvasConfiguration ___notNullable_1 = (global::Natrix.StdWeb.GPUCanvasConfiguration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLContextAttributes? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLContextAttributes?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLContextAttributes? __element_69;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_69 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_69 = new global::Natrix.StdWeb.WebGLContextAttributes(___notNullable_1);
        }
        return __element_69;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLContextAttributes? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLContextAttributes?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLContextAttributes? __element_69;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_69 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_69 = new global::Natrix.StdWeb.WebGLContextAttributes(___notNullable_1);
        }
        return __element_69;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLContextAttributes?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLContextAttributes? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLContextAttributes ___notNullable_1 = (global::Natrix.StdWeb.WebGLContextAttributes)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLContextAttributes?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLContextAttributes? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLContextAttributes ___notNullable_1 = (global::Natrix.StdWeb.WebGLContextAttributes)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>? __element_70;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_70 = null;
        }
        else
        {
            __element_70 = new global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_70;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>? __element_70;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_70 = null;
        }
        else
        {
            __element_70 = new global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_70;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLShader? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShader?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLShader? __element_71;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_71 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_71 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLShader>(___notNullable_1);
        }
        return __element_71;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLShader? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShader?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLShader? __element_71;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_71 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_71 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLShader>(___notNullable_1);
        }
        return __element_71;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShader?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLShader? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLShader ___notNullable_1 = (global::Natrix.StdWeb.WebGLShader)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShader?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLShader? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLShader ___notNullable_1 = (global::Natrix.StdWeb.WebGLShader)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLActiveInfo? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLActiveInfo?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLActiveInfo? __element_72;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_72 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_72 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLActiveInfo>(___notNullable_1);
        }
        return __element_72;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLActiveInfo? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLActiveInfo?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLActiveInfo? __element_72;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_72 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_72 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLActiveInfo>(___notNullable_1);
        }
        return __element_72;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLActiveInfo?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLActiveInfo? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLActiveInfo ___notNullable_1 = (global::Natrix.StdWeb.WebGLActiveInfo)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLActiveInfo?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLActiveInfo? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLActiveInfo ___notNullable_1 = (global::Natrix.StdWeb.WebGLActiveInfo)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>? __element_73;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_73 = null;
        }
        else
        {
            __element_73 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_73;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>? __element_73;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_73 = null;
        }
        else
        {
            __element_73 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_73;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.WebGLShader, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLShaderPrecisionFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShaderPrecisionFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLShaderPrecisionFormat? __element_74;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_74 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_74 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLShaderPrecisionFormat>(___notNullable_1);
        }
        return __element_74;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLShaderPrecisionFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShaderPrecisionFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLShaderPrecisionFormat? __element_74;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_74 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_74 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLShaderPrecisionFormat>(___notNullable_1);
        }
        return __element_74;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShaderPrecisionFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLShaderPrecisionFormat? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLShaderPrecisionFormat ___notNullable_1 = (global::Natrix.StdWeb.WebGLShaderPrecisionFormat)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLShaderPrecisionFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLShaderPrecisionFormat? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLShaderPrecisionFormat ___notNullable_1 = (global::Natrix.StdWeb.WebGLShaderPrecisionFormat)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLUniformLocation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLUniformLocation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLUniformLocation? __element_75;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_75 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_75 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLUniformLocation>(___notNullable_1);
        }
        return __element_75;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLUniformLocation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLUniformLocation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLUniformLocation? __element_75;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_75 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_75 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLUniformLocation>(___notNullable_1);
        }
        return __element_75;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLUniformLocation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLUniformLocation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLUniformLocation ___notNullable_1 = (global::Natrix.StdWeb.WebGLUniformLocation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLUniformLocation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLUniformLocation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLUniformLocation ___notNullable_1 = (global::Natrix.StdWeb.WebGLUniformLocation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Document? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Document?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Document? __element_76;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_76 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_76 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Document>(___notNullable_1);
        }
        return __element_76;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Document? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Document?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Document? __element_76;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_76 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_76 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Document>(___notNullable_1);
        }
        return __element_76;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Document?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Document? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Document ___notNullable_1 = (global::Natrix.StdWeb.Document)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Document?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Document? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Document ___notNullable_1 = (global::Natrix.StdWeb.Document)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DataTransfer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransfer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DataTransfer? __element_77;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_77 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_77 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DataTransfer>(___notNullable_1);
        }
        return __element_77;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DataTransfer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransfer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DataTransfer? __element_77;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_77 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_77 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DataTransfer>(___notNullable_1);
        }
        return __element_77;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransfer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DataTransfer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DataTransfer ___notNullable_1 = (global::Natrix.StdWeb.DataTransfer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransfer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DataTransfer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DataTransfer ___notNullable_1 = (global::Natrix.StdWeb.DataTransfer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_78;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_78 = null;
        }
        else
        {
            __element_78 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_78;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_78;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_78 = null;
        }
        else
        {
            __element_78 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_78;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.File, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLTexture? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLTexture?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLTexture? __element_79;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_79 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_79 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLTexture>(___notNullable_1);
        }
        return __element_79;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLTexture? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLTexture?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLTexture? __element_79;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_79 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_79 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLTexture>(___notNullable_1);
        }
        return __element_79;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLTexture?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLTexture? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLTexture ___notNullable_1 = (global::Natrix.StdWeb.WebGLTexture)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLTexture?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLTexture? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLTexture ___notNullable_1 = (global::Natrix.StdWeb.WebGLTexture)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRWebGLDepthInformation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLDepthInformation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRWebGLDepthInformation? __element_80;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_80 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_80 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRWebGLDepthInformation>(___notNullable_1);
        }
        return __element_80;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRWebGLDepthInformation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLDepthInformation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRWebGLDepthInformation? __element_80;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_80 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_80 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRWebGLDepthInformation>(___notNullable_1);
        }
        return __element_80;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLDepthInformation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRWebGLDepthInformation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRWebGLDepthInformation ___notNullable_1 = (global::Natrix.StdWeb.XRWebGLDepthInformation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLDepthInformation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRWebGLDepthInformation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRWebGLDepthInformation ___notNullable_1 = (global::Natrix.StdWeb.XRWebGLDepthInformation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ReadableStreamBYOBRequest? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStreamBYOBRequest?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ReadableStreamBYOBRequest? __element_81;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_81 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_81 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStreamBYOBRequest>(___notNullable_1);
        }
        return __element_81;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ReadableStreamBYOBRequest? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStreamBYOBRequest?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ReadableStreamBYOBRequest? __element_81;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_81 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_81 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStreamBYOBRequest>(___notNullable_1);
        }
        return __element_81;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStreamBYOBRequest?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ReadableStreamBYOBRequest? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ReadableStreamBYOBRequest ___notNullable_1 = (global::Natrix.StdWeb.ReadableStreamBYOBRequest)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStreamBYOBRequest?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ReadableStreamBYOBRequest? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ReadableStreamBYOBRequest ___notNullable_1 = (global::Natrix.StdWeb.ReadableStreamBYOBRequest)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Uint8Array? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Uint8Array?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Uint8Array? __element_82;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_82 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_82 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Uint8Array>(___notNullable_1);
        }
        return __element_82;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Uint8Array? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Uint8Array?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Uint8Array? __element_82;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_82 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_82 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.Uint8Array>(___notNullable_1);
        }
        return __element_82;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Uint8Array?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Uint8Array? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.Uint8Array ___notNullable_1 = (global::Natrix.JSCore.Uint8Array)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Uint8Array?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Uint8Array? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.Uint8Array ___notNullable_1 = (global::Natrix.JSCore.Uint8Array)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_83;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_83 = null;
        }
        else
        {
            __element_83 = new global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_83;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_83;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_83 = null;
        }
        else
        {
            __element_83 = new global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_83;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<ulong, global::System.Numerics.BigInteger, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_84;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_84 = null;
        }
        else
        {
            __element_84 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_84;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_84;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_84 = null;
        }
        else
        {
            __element_84 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_84;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameEncryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaStreamTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaStreamTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MediaStreamTrack? __element_85;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_85 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_85 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaStreamTrack>(___notNullable_1);
        }
        return __element_85;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaStreamTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaStreamTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MediaStreamTrack? __element_85;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_85 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_85 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaStreamTrack>(___notNullable_1);
        }
        return __element_85;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaStreamTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MediaStreamTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaStreamTrack ___notNullable_1 = (global::Natrix.StdWeb.MediaStreamTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaStreamTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MediaStreamTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaStreamTrack ___notNullable_1 = (global::Natrix.StdWeb.MediaStreamTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCDtlsTransport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDtlsTransport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCDtlsTransport? __element_86;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_86 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_86 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCDtlsTransport>(___notNullable_1);
        }
        return __element_86;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCDtlsTransport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDtlsTransport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCDtlsTransport? __element_86;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_86 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_86 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCDtlsTransport>(___notNullable_1);
        }
        return __element_86;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDtlsTransport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCDtlsTransport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCDtlsTransport ___notNullable_1 = (global::Natrix.StdWeb.RTCDtlsTransport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDtlsTransport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCDtlsTransport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCDtlsTransport ___notNullable_1 = (global::Natrix.StdWeb.RTCDtlsTransport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCRtpCapabilities? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpCapabilities?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCRtpCapabilities? __element_87;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_87 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_87 = new global::Natrix.StdWeb.RTCRtpCapabilities(___notNullable_1);
        }
        return __element_87;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCRtpCapabilities? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpCapabilities?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCRtpCapabilities? __element_87;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_87 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_87 = new global::Natrix.StdWeb.RTCRtpCapabilities(___notNullable_1);
        }
        return __element_87;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpCapabilities?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCRtpCapabilities? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCRtpCapabilities ___notNullable_1 = (global::Natrix.StdWeb.RTCRtpCapabilities)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpCapabilities?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCRtpCapabilities? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCRtpCapabilities ___notNullable_1 = (global::Natrix.StdWeb.RTCRtpCapabilities)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCDTMFSender? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDTMFSender?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCDTMFSender? __element_88;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_88 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_88 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCDTMFSender>(___notNullable_1);
        }
        return __element_88;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCDTMFSender? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDTMFSender?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCDTMFSender? __element_88;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_88 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_88 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCDTMFSender>(___notNullable_1);
        }
        return __element_88;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDTMFSender?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCDTMFSender? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCDTMFSender ___notNullable_1 = (global::Natrix.StdWeb.RTCDTMFSender)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCDTMFSender?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCDTMFSender? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCDTMFSender ___notNullable_1 = (global::Natrix.StdWeb.RTCDTMFSender)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_89;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_89 = null;
        }
        else
        {
            __element_89 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_89;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_89;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_89 = null;
        }
        else
        {
            __element_89 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_89;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RTCRtpSFrameDecryptor, global::Natrix.StdWeb.RTCRtpScriptTransform, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ushort? global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        ushort? __element_90;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_90 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_90 = Convert.ToUInt16(___notNullable_1);
        }
        return __element_90;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static ushort? global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        ushort? __element_90;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_90 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_90 = Convert.ToUInt16(___notNullable_1);
        }
        return __element_90;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, ushort? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ushort ___notNullable_1 = (ushort)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<ushort?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, ushort? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            ushort ___notNullable_1 = (ushort)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static uint? global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        uint? __element_91;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_91 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_91 = Convert.ToUInt32(___notNullable_1);
        }
        return __element_91;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static uint? global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        uint? __element_91;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_91 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_91 = Convert.ToUInt32(___notNullable_1);
        }
        return __element_91;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, uint? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            uint ___notNullable_1 = (uint)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<uint?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, uint? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            uint ___notNullable_1 = (uint)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRDOMOverlayInit? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRDOMOverlayInit? __element_92;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_92 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_92 = new global::Natrix.StdWeb.XRDOMOverlayInit(___notNullable_1);
        }
        return __element_92;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRDOMOverlayInit? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRDOMOverlayInit? __element_92;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_92 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_92 = new global::Natrix.StdWeb.XRDOMOverlayInit(___notNullable_1);
        }
        return __element_92;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRDOMOverlayInit? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRDOMOverlayInit ___notNullable_1 = (global::Natrix.StdWeb.XRDOMOverlayInit)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRDOMOverlayInit?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRDOMOverlayInit? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRDOMOverlayInit ___notNullable_1 = (global::Natrix.StdWeb.XRDOMOverlayInit)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TrustedTypePolicy? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TrustedTypePolicy?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.TrustedTypePolicy? __element_93;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_93 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_93 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TrustedTypePolicy>(___notNullable_1);
        }
        return __element_93;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TrustedTypePolicy? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TrustedTypePolicy?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.TrustedTypePolicy? __element_93;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_93 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_93 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TrustedTypePolicy>(___notNullable_1);
        }
        return __element_93;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TrustedTypePolicy?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.TrustedTypePolicy? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TrustedTypePolicy ___notNullable_1 = (global::Natrix.StdWeb.TrustedTypePolicy)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TrustedTypePolicy?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.TrustedTypePolicy? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TrustedTypePolicy ___notNullable_1 = (global::Natrix.StdWeb.TrustedTypePolicy)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NotRestoredReasons? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NotRestoredReasons?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NotRestoredReasons? __element_94;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_94 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_94 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NotRestoredReasons>(___notNullable_1);
        }
        return __element_94;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NotRestoredReasons? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NotRestoredReasons?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NotRestoredReasons? __element_94;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_94 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_94 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NotRestoredReasons>(___notNullable_1);
        }
        return __element_94;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NotRestoredReasons?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NotRestoredReasons? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NotRestoredReasons ___notNullable_1 = (global::Natrix.StdWeb.NotRestoredReasons)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NotRestoredReasons?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NotRestoredReasons? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NotRestoredReasons ___notNullable_1 = (global::Natrix.StdWeb.NotRestoredReasons)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLFormElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLFormElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLFormElement? __element_95;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_95 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_95 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLFormElement>(___notNullable_1);
        }
        return __element_95;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLFormElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLFormElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLFormElement? __element_95;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_95 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_95 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLFormElement>(___notNullable_1);
        }
        return __element_95;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLFormElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLFormElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLFormElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLFormElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLFormElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLFormElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLFormElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLFormElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FileList? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileList?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.FileList? __element_96;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_96 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_96 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileList>(___notNullable_1);
        }
        return __element_96;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FileList? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileList?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.FileList? __element_96;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_96 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_96 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileList>(___notNullable_1);
        }
        return __element_96;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileList?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.FileList? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FileList ___notNullable_1 = (global::Natrix.StdWeb.FileList)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileList?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.FileList? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FileList ___notNullable_1 = (global::Natrix.StdWeb.FileList)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLDataListElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLDataListElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLDataListElement? __element_97;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_97 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_97 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLDataListElement>(___notNullable_1);
        }
        return __element_97;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLDataListElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLDataListElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLDataListElement? __element_97;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_97 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_97 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLDataListElement>(___notNullable_1);
        }
        return __element_97;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLDataListElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLDataListElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLDataListElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLDataListElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLDataListElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLDataListElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLDataListElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLDataListElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NodeList? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeList?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NodeList? __element_98;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_98 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_98 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NodeList>(___notNullable_1);
        }
        return __element_98;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NodeList? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeList?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NodeList? __element_98;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_98 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_98 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NodeList>(___notNullable_1);
        }
        return __element_98;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeList?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NodeList? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NodeList ___notNullable_1 = (global::Natrix.StdWeb.NodeList)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeList?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NodeList? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NodeList ___notNullable_1 = (global::Natrix.StdWeb.NodeList)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FileSystemEntry? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemEntry?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.FileSystemEntry? __element_99;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_99 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_99 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileSystemEntry>(___notNullable_1);
        }
        return __element_99;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FileSystemEntry? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemEntry?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.FileSystemEntry? __element_99;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_99 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_99 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileSystemEntry>(___notNullable_1);
        }
        return __element_99;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemEntry?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.FileSystemEntry? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FileSystemEntry ___notNullable_1 = (global::Natrix.StdWeb.FileSystemEntry)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemEntry?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.FileSystemEntry? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FileSystemEntry ___notNullable_1 = (global::Natrix.StdWeb.FileSystemEntry)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FileSystemHandle? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemHandle?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.FileSystemHandle? __element_100;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_100 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_100 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileSystemHandle>(___notNullable_1);
        }
        return __element_100;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FileSystemHandle? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemHandle?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.FileSystemHandle? __element_100;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_100 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_100 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FileSystemHandle>(___notNullable_1);
        }
        return __element_100;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemHandle?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.FileSystemHandle? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FileSystemHandle ___notNullable_1 = (global::Natrix.StdWeb.FileSystemHandle)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FileSystemHandle?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.FileSystemHandle? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FileSystemHandle ___notNullable_1 = (global::Natrix.StdWeb.FileSystemHandle)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.File? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.File?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.File? __element_101;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_101 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_101 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.File>(___notNullable_1);
        }
        return __element_101;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.File? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.File?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.File? __element_101;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_101 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_101 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.File>(___notNullable_1);
        }
        return __element_101;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.File?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.File? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.File ___notNullable_1 = (global::Natrix.StdWeb.File)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.File?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.File? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.File ___notNullable_1 = (global::Natrix.StdWeb.File)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_102;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_102 = null;
        }
        else
        {
            __element_102 = new global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_102;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_102;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_102 = null;
        }
        else
        {
            __element_102 = new global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_102;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<double, global::Natrix.StdWeb.CSSNumericValue, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationEffect? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationEffect?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AnimationEffect? __element_103;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_103 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_103 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationEffect>(___notNullable_1);
        }
        return __element_103;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationEffect? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationEffect?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AnimationEffect? __element_103;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_103 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_103 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationEffect>(___notNullable_1);
        }
        return __element_103;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationEffect?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AnimationEffect? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationEffect ___notNullable_1 = (global::Natrix.StdWeb.AnimationEffect)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationEffect?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AnimationEffect? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationEffect ___notNullable_1 = (global::Natrix.StdWeb.AnimationEffect)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationTimeline? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTimeline?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AnimationTimeline? __element_104;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_104 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_104 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationTimeline>(___notNullable_1);
        }
        return __element_104;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationTimeline? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTimeline?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AnimationTimeline? __element_104;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_104 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_104 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationTimeline>(___notNullable_1);
        }
        return __element_104;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTimeline?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AnimationTimeline? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTimeline ___notNullable_1 = (global::Natrix.StdWeb.AnimationTimeline)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTimeline?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AnimationTimeline? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTimeline ___notNullable_1 = (global::Natrix.StdWeb.AnimationTimeline)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationTrigger? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTrigger?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AnimationTrigger? __element_105;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_105 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_105 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationTrigger>(___notNullable_1);
        }
        return __element_105;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationTrigger? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTrigger?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AnimationTrigger? __element_105;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_105 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_105 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AnimationTrigger>(___notNullable_1);
        }
        return __element_105;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTrigger?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AnimationTrigger? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTrigger ___notNullable_1 = (global::Natrix.StdWeb.AnimationTrigger)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTrigger?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AnimationTrigger? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTrigger ___notNullable_1 = (global::Natrix.StdWeb.AnimationTrigger)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GroupEffect? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GroupEffect?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GroupEffect? __element_106;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_106 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_106 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GroupEffect>(___notNullable_1);
        }
        return __element_106;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GroupEffect? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GroupEffect?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GroupEffect? __element_106;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_106 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_106 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GroupEffect>(___notNullable_1);
        }
        return __element_106;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GroupEffect?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GroupEffect? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GroupEffect ___notNullable_1 = (global::Natrix.StdWeb.GroupEffect)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GroupEffect?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GroupEffect? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GroupEffect ___notNullable_1 = (global::Natrix.StdWeb.GroupEffect)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_107;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_107 = null;
        }
        else
        {
            __element_107 = new global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_107;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_107;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_107 = null;
        }
        else
        {
            __element_107 = new global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_107;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<double, global::Natrix.JSCore.Generics.JSArray<double?, global::Natrix.StdWeb.PropertyAccessorNullable>, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRRigidTransform? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRRigidTransform?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRRigidTransform? __element_108;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_108 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_108 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRRigidTransform>(___notNullable_1);
        }
        return __element_108;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRRigidTransform? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRRigidTransform?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRRigidTransform? __element_108;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_108 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_108 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRRigidTransform>(___notNullable_1);
        }
        return __element_108;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRRigidTransform?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRRigidTransform? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRRigidTransform ___notNullable_1 = (global::Natrix.StdWeb.XRRigidTransform)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRRigidTransform?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRRigidTransform? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRRigidTransform ___notNullable_1 = (global::Natrix.StdWeb.XRRigidTransform)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMPointReadOnly? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMPointReadOnly?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DOMPointReadOnly? __element_109;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_109 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_109 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMPointReadOnly>(___notNullable_1);
        }
        return __element_109;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMPointReadOnly? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMPointReadOnly?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DOMPointReadOnly? __element_109;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_109 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_109 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMPointReadOnly>(___notNullable_1);
        }
        return __element_109;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMPointReadOnly?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DOMPointReadOnly? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMPointReadOnly ___notNullable_1 = (global::Natrix.StdWeb.DOMPointReadOnly)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMPointReadOnly?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DOMPointReadOnly? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMPointReadOnly ___notNullable_1 = (global::Natrix.StdWeb.DOMPointReadOnly)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRWebGLLayer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLLayer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRWebGLLayer? __element_110;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_110 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_110 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRWebGLLayer>(___notNullable_1);
        }
        return __element_110;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRWebGLLayer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLLayer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRWebGLLayer? __element_110;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_110 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_110 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRWebGLLayer>(___notNullable_1);
        }
        return __element_110;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLLayer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRWebGLLayer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRWebGLLayer ___notNullable_1 = (global::Natrix.StdWeb.XRWebGLLayer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRWebGLLayer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRWebGLLayer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRWebGLLayer ___notNullable_1 = (global::Natrix.StdWeb.XRWebGLLayer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CookieListItem? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CookieListItem?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CookieListItem? __element_111;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_111 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_111 = new global::Natrix.StdWeb.CookieListItem(___notNullable_1);
        }
        return __element_111;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CookieListItem? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CookieListItem?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CookieListItem? __element_111;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_111 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_111 = new global::Natrix.StdWeb.CookieListItem(___notNullable_1);
        }
        return __element_111;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CookieListItem?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CookieListItem? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CookieListItem ___notNullable_1 = (global::Natrix.StdWeb.CookieListItem)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CookieListItem?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CookieListItem? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CookieListItem ___notNullable_1 = (global::Natrix.StdWeb.CookieListItem)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static long? global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        long? __element_112;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_112 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_112 = Convert.ToInt64(___notNullable_1);
        }
        return __element_112;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static long? global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        long? __element_112;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_112 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_112 = Convert.ToInt64(___notNullable_1);
        }
        return __element_112;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, long? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            long ___notNullable_1 = (long)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<long?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, long? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            long ___notNullable_1 = (long)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.URLPatternResult? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URLPatternResult?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.URLPatternResult? __element_113;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_113 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_113 = new global::Natrix.StdWeb.URLPatternResult(___notNullable_1);
        }
        return __element_113;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.URLPatternResult? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URLPatternResult?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.URLPatternResult? __element_113;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_113 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_113 = new global::Natrix.StdWeb.URLPatternResult(___notNullable_1);
        }
        return __element_113;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URLPatternResult?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.URLPatternResult? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.URLPatternResult ___notNullable_1 = (global::Natrix.StdWeb.URLPatternResult)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URLPatternResult?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.URLPatternResult? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.URLPatternResult ___notNullable_1 = (global::Natrix.StdWeb.URLPatternResult)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaKeys? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeys?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MediaKeys? __element_114;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_114 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_114 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaKeys>(___notNullable_1);
        }
        return __element_114;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaKeys? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeys?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MediaKeys? __element_114;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_114 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_114 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaKeys>(___notNullable_1);
        }
        return __element_114;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeys?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MediaKeys? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeys ___notNullable_1 = (global::Natrix.StdWeb.MediaKeys)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeys?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MediaKeys? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeys ___notNullable_1 = (global::Natrix.StdWeb.MediaKeys)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaError? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaError?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MediaError? __element_115;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_115 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_115 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaError>(___notNullable_1);
        }
        return __element_115;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaError? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaError?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MediaError? __element_115;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_115 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_115 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MediaError>(___notNullable_1);
        }
        return __element_115;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaError?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MediaError? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaError ___notNullable_1 = (global::Natrix.StdWeb.MediaError)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaError?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MediaError? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaError ___notNullable_1 = (global::Natrix.StdWeb.MediaError)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_116;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_116 = null;
        }
        else
        {
            __element_116 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_116;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_116;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_116 = null;
        }
        else
        {
            __element_116 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_116;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.MediaStream, global::Natrix.StdWeb.MediaSource, global::Natrix.StdWeb.Blob, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_117;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_117 = null;
        }
        else
        {
            __element_117 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_117;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_117;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_117 = null;
        }
        else
        {
            __element_117 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_117;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.CanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>? __element_118;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_118 = null;
        }
        else
        {
            __element_118 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_118;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>? __element_118;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_118 = null;
        }
        else
        {
            __element_118 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_118;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Landmark, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMRect? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRect?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DOMRect? __element_119;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_119 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_119 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMRect>(___notNullable_1);
        }
        return __element_119;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMRect? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRect?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DOMRect? __element_119;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_119 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_119 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMRect>(___notNullable_1);
        }
        return __element_119;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRect?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DOMRect? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMRect ___notNullable_1 = (global::Natrix.StdWeb.DOMRect)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRect?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DOMRect? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMRect ___notNullable_1 = (global::Natrix.StdWeb.DOMRect)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_120;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_120 = null;
        }
        else
        {
            __element_120 = new global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_120;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_120;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_120 = null;
        }
        else
        {
            __element_120 = new global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_120;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<bool, double, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.EditContext? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EditContext?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.EditContext? __element_121;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_121 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_121 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.EditContext>(___notNullable_1);
        }
        return __element_121;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.EditContext? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EditContext?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.EditContext? __element_121;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_121 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_121 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.EditContext>(___notNullable_1);
        }
        return __element_121;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EditContext?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.EditContext? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.EditContext ___notNullable_1 = (global::Natrix.StdWeb.EditContext)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EditContext?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.EditContext? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.EditContext ___notNullable_1 = (global::Natrix.StdWeb.EditContext)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.EventTarget? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventTarget?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.EventTarget? __element_122;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_122 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_122 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.EventTarget>(___notNullable_1);
        }
        return __element_122;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.EventTarget? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventTarget?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.EventTarget? __element_122;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_122 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_122 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.EventTarget>(___notNullable_1);
        }
        return __element_122;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventTarget?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.EventTarget? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.EventTarget ___notNullable_1 = (global::Natrix.StdWeb.EventTarget)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.EventTarget?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.EventTarget? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.EventTarget ___notNullable_1 = (global::Natrix.StdWeb.EventTarget)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCSessionDescription? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSessionDescription?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCSessionDescription? __element_123;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_123 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_123 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCSessionDescription>(___notNullable_1);
        }
        return __element_123;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCSessionDescription? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSessionDescription?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCSessionDescription? __element_123;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_123 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_123 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCSessionDescription>(___notNullable_1);
        }
        return __element_123;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSessionDescription?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCSessionDescription? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCSessionDescription ___notNullable_1 = (global::Natrix.StdWeb.RTCSessionDescription)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSessionDescription?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCSessionDescription? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCSessionDescription ___notNullable_1 = (global::Natrix.StdWeb.RTCSessionDescription)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCSctpTransport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSctpTransport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCSctpTransport? __element_124;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_124 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_124 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCSctpTransport>(___notNullable_1);
        }
        return __element_124;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCSctpTransport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSctpTransport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCSctpTransport? __element_124;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_124 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_124 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCSctpTransport>(___notNullable_1);
        }
        return __element_124;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSctpTransport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCSctpTransport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCSctpTransport ___notNullable_1 = (global::Natrix.StdWeb.RTCSctpTransport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCSctpTransport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCSctpTransport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCSctpTransport ___notNullable_1 = (global::Natrix.StdWeb.RTCSctpTransport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceComponent? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceComponent?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceComponent? __element_125;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_125 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_125 = global::Natrix.StdWeb.RTCIceComponent.Create(___notNullable_1);
        }
        return __element_125;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceComponent? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceComponent?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceComponent? __element_125;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_125 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_125 = global::Natrix.StdWeb.RTCIceComponent.Create(___notNullable_1);
        }
        return __element_125;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceComponent?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceComponent? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceComponent ___notNullable_1 = (global::Natrix.StdWeb.RTCIceComponent)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceComponent?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceComponent? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceComponent ___notNullable_1 = (global::Natrix.StdWeb.RTCIceComponent)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceProtocol? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceProtocol?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceProtocol? __element_126;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_126 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_126 = global::Natrix.StdWeb.RTCIceProtocol.Create(___notNullable_1);
        }
        return __element_126;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceProtocol? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceProtocol?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceProtocol? __element_126;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_126 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_126 = global::Natrix.StdWeb.RTCIceProtocol.Create(___notNullable_1);
        }
        return __element_126;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceProtocol?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceProtocol? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceProtocol ___notNullable_1 = (global::Natrix.StdWeb.RTCIceProtocol)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceProtocol?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceProtocol? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceProtocol ___notNullable_1 = (global::Natrix.StdWeb.RTCIceProtocol)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceCandidateType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidateType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceCandidateType? __element_127;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_127 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_127 = global::Natrix.StdWeb.RTCIceCandidateType.Create(___notNullable_1);
        }
        return __element_127;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceCandidateType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidateType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceCandidateType? __element_127;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_127 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_127 = global::Natrix.StdWeb.RTCIceCandidateType.Create(___notNullable_1);
        }
        return __element_127;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidateType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceCandidateType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceCandidateType ___notNullable_1 = (global::Natrix.StdWeb.RTCIceCandidateType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidateType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceCandidateType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceCandidateType ___notNullable_1 = (global::Natrix.StdWeb.RTCIceCandidateType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceTcpCandidateType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceTcpCandidateType? __element_128;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_128 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_128 = global::Natrix.StdWeb.RTCIceTcpCandidateType.Create(___notNullable_1);
        }
        return __element_128;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceTcpCandidateType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceTcpCandidateType? __element_128;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_128 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_128 = global::Natrix.StdWeb.RTCIceTcpCandidateType.Create(___notNullable_1);
        }
        return __element_128;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceTcpCandidateType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceTcpCandidateType ___notNullable_1 = (global::Natrix.StdWeb.RTCIceTcpCandidateType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceTcpCandidateType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceTcpCandidateType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceTcpCandidateType ___notNullable_1 = (global::Natrix.StdWeb.RTCIceTcpCandidateType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceServerTransportProtocol? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceServerTransportProtocol? __element_129;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_129 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_129 = global::Natrix.StdWeb.RTCIceServerTransportProtocol.Create(___notNullable_1);
        }
        return __element_129;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceServerTransportProtocol? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceServerTransportProtocol? __element_129;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_129 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_129 = global::Natrix.StdWeb.RTCIceServerTransportProtocol.Create(___notNullable_1);
        }
        return __element_129;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceServerTransportProtocol? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceServerTransportProtocol ___notNullable_1 = (global::Natrix.StdWeb.RTCIceServerTransportProtocol)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceServerTransportProtocol?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceServerTransportProtocol? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceServerTransportProtocol ___notNullable_1 = (global::Natrix.StdWeb.RTCIceServerTransportProtocol)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceCandidate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceCandidate? __element_130;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_130 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_130 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCIceCandidate>(___notNullable_1);
        }
        return __element_130;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceCandidate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceCandidate? __element_130;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_130 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_130 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCIceCandidate>(___notNullable_1);
        }
        return __element_130;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceCandidate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceCandidate ___notNullable_1 = (global::Natrix.StdWeb.RTCIceCandidate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceCandidate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceCandidate ___notNullable_1 = (global::Natrix.StdWeb.RTCIceCandidate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCRtpTransceiverDirection? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCRtpTransceiverDirection? __element_131;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_131 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_131 = global::Natrix.StdWeb.RTCRtpTransceiverDirection.Create(___notNullable_1);
        }
        return __element_131;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCRtpTransceiverDirection? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCRtpTransceiverDirection? __element_131;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_131 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_131 = global::Natrix.StdWeb.RTCRtpTransceiverDirection.Create(___notNullable_1);
        }
        return __element_131;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCRtpTransceiverDirection? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCRtpTransceiverDirection ___notNullable_1 = (global::Natrix.StdWeb.RTCRtpTransceiverDirection)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCRtpTransceiverDirection?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCRtpTransceiverDirection? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCRtpTransceiverDirection ___notNullable_1 = (global::Natrix.StdWeb.RTCRtpTransceiverDirection)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceCandidatePair? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidatePair?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceCandidatePair? __element_132;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_132 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_132 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCIceCandidatePair>(___notNullable_1);
        }
        return __element_132;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceCandidatePair? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidatePair?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceCandidatePair? __element_132;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_132 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_132 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.RTCIceCandidatePair>(___notNullable_1);
        }
        return __element_132;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidatePair?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceCandidatePair? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceCandidatePair ___notNullable_1 = (global::Natrix.StdWeb.RTCIceCandidatePair)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceCandidatePair?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceCandidatePair? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceCandidatePair ___notNullable_1 = (global::Natrix.StdWeb.RTCIceCandidatePair)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceParameters? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceParameters?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RTCIceParameters? __element_133;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_133 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_133 = new global::Natrix.StdWeb.RTCIceParameters(___notNullable_1);
        }
        return __element_133;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RTCIceParameters? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceParameters?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RTCIceParameters? __element_133;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_133 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_133 = new global::Natrix.StdWeb.RTCIceParameters(___notNullable_1);
        }
        return __element_133;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceParameters?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RTCIceParameters? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceParameters ___notNullable_1 = (global::Natrix.StdWeb.RTCIceParameters)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RTCIceParameters?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RTCIceParameters? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RTCIceParameters ___notNullable_1 = (global::Natrix.StdWeb.RTCIceParameters)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static int? global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        int? __element_134;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_134 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_134 = Convert.ToInt32(___notNullable_1);
        }
        return __element_134;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static int? global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        int? __element_134;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_134 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_134 = Convert.ToInt32(___notNullable_1);
        }
        return __element_134;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, int? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            int ___notNullable_1 = (int)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<int?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, int? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            int ___notNullable_1 = (int)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GamepadPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GamepadPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GamepadPose? __element_135;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_135 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_135 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GamepadPose>(___notNullable_1);
        }
        return __element_135;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GamepadPose? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GamepadPose?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GamepadPose? __element_135;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_135 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_135 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GamepadPose>(___notNullable_1);
        }
        return __element_135;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GamepadPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GamepadPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GamepadPose ___notNullable_1 = (global::Natrix.StdWeb.GamepadPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GamepadPose?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GamepadPose? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GamepadPose ___notNullable_1 = (global::Natrix.StdWeb.GamepadPose)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebTransportSendGroup? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebTransportSendGroup?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebTransportSendGroup? __element_136;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_136 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_136 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebTransportSendGroup>(___notNullable_1);
        }
        return __element_136;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebTransportSendGroup? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebTransportSendGroup?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebTransportSendGroup? __element_136;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_136 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_136 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebTransportSendGroup>(___notNullable_1);
        }
        return __element_136;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebTransportSendGroup?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebTransportSendGroup? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebTransportSendGroup ___notNullable_1 = (global::Natrix.StdWeb.WebTransportSendGroup)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebTransportSendGroup?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebTransportSendGroup? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebTransportSendGroup ___notNullable_1 = (global::Natrix.StdWeb.WebTransportSendGroup)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Headers? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Headers?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Headers? __element_137;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_137 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_137 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Headers>(___notNullable_1);
        }
        return __element_137;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Headers? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Headers?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Headers? __element_137;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_137 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_137 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Headers>(___notNullable_1);
        }
        return __element_137;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Headers?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Headers? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Headers ___notNullable_1 = (global::Natrix.StdWeb.Headers)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Headers?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Headers? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Headers ___notNullable_1 = (global::Natrix.StdWeb.Headers)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGPathSegment? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGPathSegment?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SVGPathSegment? __element_138;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_138 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_138 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGPathSegment>(___notNullable_1);
        }
        return __element_138;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SVGPathSegment? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGPathSegment?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SVGPathSegment? __element_138;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_138 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_138 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SVGPathSegment>(___notNullable_1);
        }
        return __element_138;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGPathSegment?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SVGPathSegment? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGPathSegment ___notNullable_1 = (global::Natrix.StdWeb.SVGPathSegment)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SVGPathSegment?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SVGPathSegment? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SVGPathSegment ___notNullable_1 = (global::Natrix.StdWeb.SVGPathSegment)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PresentationRequest? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationRequest?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PresentationRequest? __element_139;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_139 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_139 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PresentationRequest>(___notNullable_1);
        }
        return __element_139;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PresentationRequest? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationRequest?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PresentationRequest? __element_139;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_139 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_139 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PresentationRequest>(___notNullable_1);
        }
        return __element_139;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationRequest?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PresentationRequest? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PresentationRequest ___notNullable_1 = (global::Natrix.StdWeb.PresentationRequest)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationRequest?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PresentationRequest? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PresentationRequest ___notNullable_1 = (global::Natrix.StdWeb.PresentationRequest)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PresentationReceiver? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationReceiver?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PresentationReceiver? __element_140;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_140 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_140 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PresentationReceiver>(___notNullable_1);
        }
        return __element_140;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PresentationReceiver? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationReceiver?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PresentationReceiver? __element_140;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_140 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_140 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PresentationReceiver>(___notNullable_1);
        }
        return __element_140;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationReceiver?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PresentationReceiver? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PresentationReceiver ___notNullable_1 = (global::Natrix.StdWeb.PresentationReceiver)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PresentationReceiver?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PresentationReceiver? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PresentationReceiver ___notNullable_1 = (global::Natrix.StdWeb.PresentationReceiver)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_141;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_141 = null;
        }
        else
        {
            __element_141 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_141;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_141;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_141 = null;
        }
        else
        {
            __element_141 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_141;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.ReadableStream, global::Natrix.StdWeb.Blob, global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.FormData, global::Natrix.StdWeb.URLSearchParams, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AbortSignal? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AbortSignal?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AbortSignal? __element_142;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_142 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_142 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AbortSignal>(___notNullable_1);
        }
        return __element_142;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AbortSignal? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AbortSignal?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AbortSignal? __element_142;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_142 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_142 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AbortSignal>(___notNullable_1);
        }
        return __element_142;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AbortSignal?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AbortSignal? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AbortSignal ___notNullable_1 = (global::Natrix.StdWeb.AbortSignal)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AbortSignal?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AbortSignal? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AbortSignal ___notNullable_1 = (global::Natrix.StdWeb.AbortSignal)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ReadableStream? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStream?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ReadableStream? __element_143;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_143 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_143 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStream>(___notNullable_1);
        }
        return __element_143;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ReadableStream? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStream?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ReadableStream? __element_143;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_143 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_143 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ReadableStream>(___notNullable_1);
        }
        return __element_143;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStream?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ReadableStream? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ReadableStream ___notNullable_1 = (global::Natrix.StdWeb.ReadableStream)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReadableStream?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ReadableStream? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ReadableStream ___notNullable_1 = (global::Natrix.StdWeb.ReadableStream)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSTransition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSTransition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSTransition? __element_144;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_144 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_144 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSTransition>(___notNullable_1);
        }
        return __element_144;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSTransition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSTransition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSTransition? __element_144;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_144 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_144 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSTransition>(___notNullable_1);
        }
        return __element_144;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSTransition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSTransition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSTransition ___notNullable_1 = (global::Natrix.StdWeb.CSSTransition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSTransition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSTransition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSTransition ___notNullable_1 = (global::Natrix.StdWeb.CSSTransition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CaptureHandle? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaptureHandle?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CaptureHandle? __element_145;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_145 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_145 = new global::Natrix.StdWeb.CaptureHandle(___notNullable_1);
        }
        return __element_145;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CaptureHandle? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaptureHandle?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CaptureHandle? __element_145;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_145 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_145 = new global::Natrix.StdWeb.CaptureHandle(___notNullable_1);
        }
        return __element_145;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaptureHandle?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CaptureHandle? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CaptureHandle ___notNullable_1 = (global::Natrix.StdWeb.CaptureHandle)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CaptureHandle?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CaptureHandle? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CaptureHandle ___notNullable_1 = (global::Natrix.StdWeb.CaptureHandle)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Credential? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Credential?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Credential? __element_146;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_146 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_146 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Credential>(___notNullable_1);
        }
        return __element_146;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Credential? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Credential?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Credential? __element_146;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_146 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_146 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Credential>(___notNullable_1);
        }
        return __element_146;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Credential?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Credential? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Credential ___notNullable_1 = (global::Natrix.StdWeb.Credential)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Credential?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Credential? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Credential ___notNullable_1 = (global::Natrix.StdWeb.Credential)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AudioSampleFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioSampleFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AudioSampleFormat? __element_147;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_147 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_147 = global::Natrix.StdWeb.AudioSampleFormat.Create(___notNullable_1);
        }
        return __element_147;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AudioSampleFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioSampleFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AudioSampleFormat? __element_147;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_147 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_147 = global::Natrix.StdWeb.AudioSampleFormat.Create(___notNullable_1);
        }
        return __element_147;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioSampleFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AudioSampleFormat? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AudioSampleFormat ___notNullable_1 = (global::Natrix.StdWeb.AudioSampleFormat)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioSampleFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AudioSampleFormat? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AudioSampleFormat ___notNullable_1 = (global::Natrix.StdWeb.AudioSampleFormat)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoPixelFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoPixelFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VideoPixelFormat? __element_148;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_148 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_148 = global::Natrix.StdWeb.VideoPixelFormat.Create(___notNullable_1);
        }
        return __element_148;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoPixelFormat? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoPixelFormat?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VideoPixelFormat? __element_148;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_148 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_148 = global::Natrix.StdWeb.VideoPixelFormat.Create(___notNullable_1);
        }
        return __element_148;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoPixelFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VideoPixelFormat? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoPixelFormat ___notNullable_1 = (global::Natrix.StdWeb.VideoPixelFormat)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoPixelFormat?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VideoPixelFormat? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoPixelFormat ___notNullable_1 = (global::Natrix.StdWeb.VideoPixelFormat)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMRectReadOnly? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectReadOnly?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DOMRectReadOnly? __element_149;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_149 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_149 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMRectReadOnly>(___notNullable_1);
        }
        return __element_149;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMRectReadOnly? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectReadOnly?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DOMRectReadOnly? __element_149;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_149 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_149 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMRectReadOnly>(___notNullable_1);
        }
        return __element_149;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectReadOnly?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DOMRectReadOnly? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMRectReadOnly ___notNullable_1 = (global::Natrix.StdWeb.DOMRectReadOnly)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectReadOnly?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DOMRectReadOnly? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMRectReadOnly ___notNullable_1 = (global::Natrix.StdWeb.DOMRectReadOnly)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoColorPrimaries? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoColorPrimaries?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VideoColorPrimaries? __element_150;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_150 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_150 = global::Natrix.StdWeb.VideoColorPrimaries.Create(___notNullable_1);
        }
        return __element_150;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoColorPrimaries? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoColorPrimaries?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VideoColorPrimaries? __element_150;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_150 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_150 = global::Natrix.StdWeb.VideoColorPrimaries.Create(___notNullable_1);
        }
        return __element_150;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoColorPrimaries?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VideoColorPrimaries? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoColorPrimaries ___notNullable_1 = (global::Natrix.StdWeb.VideoColorPrimaries)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoColorPrimaries?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VideoColorPrimaries? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoColorPrimaries ___notNullable_1 = (global::Natrix.StdWeb.VideoColorPrimaries)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoTransferCharacteristics? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VideoTransferCharacteristics? __element_151;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_151 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_151 = global::Natrix.StdWeb.VideoTransferCharacteristics.Create(___notNullable_1);
        }
        return __element_151;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoTransferCharacteristics? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VideoTransferCharacteristics? __element_151;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_151 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_151 = global::Natrix.StdWeb.VideoTransferCharacteristics.Create(___notNullable_1);
        }
        return __element_151;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VideoTransferCharacteristics? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoTransferCharacteristics ___notNullable_1 = (global::Natrix.StdWeb.VideoTransferCharacteristics)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTransferCharacteristics?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VideoTransferCharacteristics? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoTransferCharacteristics ___notNullable_1 = (global::Natrix.StdWeb.VideoTransferCharacteristics)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoMatrixCoefficients? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VideoMatrixCoefficients? __element_152;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_152 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_152 = global::Natrix.StdWeb.VideoMatrixCoefficients.Create(___notNullable_1);
        }
        return __element_152;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoMatrixCoefficients? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VideoMatrixCoefficients? __element_152;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_152 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_152 = global::Natrix.StdWeb.VideoMatrixCoefficients.Create(___notNullable_1);
        }
        return __element_152;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VideoMatrixCoefficients? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoMatrixCoefficients ___notNullable_1 = (global::Natrix.StdWeb.VideoMatrixCoefficients)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoMatrixCoefficients?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VideoMatrixCoefficients? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoMatrixCoefficients ___notNullable_1 = (global::Natrix.StdWeb.VideoMatrixCoefficients)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ImageTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ImageTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ImageTrack? __element_153;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_153 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_153 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ImageTrack>(___notNullable_1);
        }
        return __element_153;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ImageTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ImageTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ImageTrack? __element_153;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_153 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_153 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ImageTrack>(___notNullable_1);
        }
        return __element_153;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ImageTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ImageTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ImageTrack ___notNullable_1 = (global::Natrix.StdWeb.ImageTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ImageTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ImageTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ImageTrack ___notNullable_1 = (global::Natrix.StdWeb.ImageTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_154;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_154 = null;
        }
        else
        {
            __element_154 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_154;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_154;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_154 = null;
        }
        else
        {
            __element_154 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_154;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.Document, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMRectInit? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectInit?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DOMRectInit? __element_155;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_155 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_155 = new global::Natrix.StdWeb.DOMRectInit(___notNullable_1);
        }
        return __element_155;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMRectInit? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectInit?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DOMRectInit? __element_155;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_155 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_155 = new global::Natrix.StdWeb.DOMRectInit(___notNullable_1);
        }
        return __element_155;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectInit?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DOMRectInit? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMRectInit ___notNullable_1 = (global::Natrix.StdWeb.DOMRectInit)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMRectInit?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DOMRectInit? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMRectInit ___notNullable_1 = (global::Natrix.StdWeb.DOMRectInit)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.BluetoothDevice? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothDevice?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.BluetoothDevice? __element_156;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_156 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_156 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.BluetoothDevice>(___notNullable_1);
        }
        return __element_156;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.BluetoothDevice? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothDevice?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.BluetoothDevice? __element_156;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_156 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_156 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.BluetoothDevice>(___notNullable_1);
        }
        return __element_156;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothDevice?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.BluetoothDevice? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.BluetoothDevice ___notNullable_1 = (global::Natrix.StdWeb.BluetoothDevice)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothDevice?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.BluetoothDevice? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.BluetoothDevice ___notNullable_1 = (global::Natrix.StdWeb.BluetoothDevice)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.BluetoothRemoteGATTServer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.BluetoothRemoteGATTServer? __element_157;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_157 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_157 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.BluetoothRemoteGATTServer>(___notNullable_1);
        }
        return __element_157;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.BluetoothRemoteGATTServer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.BluetoothRemoteGATTServer? __element_157;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_157 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_157 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.BluetoothRemoteGATTServer>(___notNullable_1);
        }
        return __element_157;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.BluetoothRemoteGATTServer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.BluetoothRemoteGATTServer ___notNullable_1 = (global::Natrix.StdWeb.BluetoothRemoteGATTServer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BluetoothRemoteGATTServer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.BluetoothRemoteGATTServer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.BluetoothRemoteGATTServer ___notNullable_1 = (global::Natrix.StdWeb.BluetoothRemoteGATTServer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static sbyte? global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        sbyte? __element_158;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_158 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_158 = Convert.ToSByte(___notNullable_1);
        }
        return __element_158;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static sbyte? global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        sbyte? __element_158;
        double? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsDoubleV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_158 = null;
        }
        else
        {
            double ___notNullable_1 = (double)___res_0;
            __element_158 = Convert.ToSByte(___notNullable_1);
        }
        return __element_158;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, sbyte? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            sbyte ___notNullable_1 = (sbyte)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<sbyte?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, sbyte? value)
    {
        double? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            sbyte ___notNullable_1 = (sbyte)value;
            ___marshalledValue_0 = Convert.ToDouble(___notNullable_1);
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsDoubleV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.DataView? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.DataView?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.DataView? __element_159;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_159 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_159 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.DataView>(___notNullable_1);
        }
        return __element_159;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.DataView? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.DataView?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.DataView? __element_159;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_159 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_159 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.DataView>(___notNullable_1);
        }
        return __element_159;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.DataView?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.DataView? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.DataView ___notNullable_1 = (global::Natrix.JSCore.DataView)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.DataView?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.DataView? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.DataView ___notNullable_1 = (global::Natrix.JSCore.DataView)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.UserIdleState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.UserIdleState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.UserIdleState? __element_160;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_160 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_160 = global::Natrix.StdWeb.UserIdleState.Create(___notNullable_1);
        }
        return __element_160;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.UserIdleState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.UserIdleState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.UserIdleState? __element_160;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_160 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_160 = global::Natrix.StdWeb.UserIdleState.Create(___notNullable_1);
        }
        return __element_160;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.UserIdleState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.UserIdleState? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.UserIdleState ___notNullable_1 = (global::Natrix.StdWeb.UserIdleState)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.UserIdleState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.UserIdleState? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.UserIdleState ___notNullable_1 = (global::Natrix.StdWeb.UserIdleState)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ScreenIdleState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ScreenIdleState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ScreenIdleState? __element_161;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_161 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_161 = global::Natrix.StdWeb.ScreenIdleState.Create(___notNullable_1);
        }
        return __element_161;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ScreenIdleState? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ScreenIdleState?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ScreenIdleState? __element_161;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_161 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_161 = global::Natrix.StdWeb.ScreenIdleState.Create(___notNullable_1);
        }
        return __element_161;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ScreenIdleState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ScreenIdleState? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ScreenIdleState ___notNullable_1 = (global::Natrix.StdWeb.ScreenIdleState)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ScreenIdleState?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ScreenIdleState? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ScreenIdleState ___notNullable_1 = (global::Natrix.StdWeb.ScreenIdleState)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUTexture? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTexture?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GPUTexture? __element_162;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_162 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_162 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUTexture>(___notNullable_1);
        }
        return __element_162;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GPUTexture? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTexture?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GPUTexture? __element_162;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_162 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_162 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GPUTexture>(___notNullable_1);
        }
        return __element_162;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTexture?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GPUTexture? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUTexture ___notNullable_1 = (global::Natrix.StdWeb.GPUTexture)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GPUTexture?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GPUTexture? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GPUTexture ___notNullable_1 = (global::Natrix.StdWeb.GPUTexture)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.ArrayBuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.ArrayBuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.ArrayBuffer? __element_163;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_163 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_163 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.ArrayBuffer>(___notNullable_1);
        }
        return __element_163;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.ArrayBuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.ArrayBuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.ArrayBuffer? __element_163;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_163 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_163 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.JSCore.ArrayBuffer>(___notNullable_1);
        }
        return __element_163;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.ArrayBuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.ArrayBuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.ArrayBuffer ___notNullable_1 = (global::Natrix.JSCore.ArrayBuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.ArrayBuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.ArrayBuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.JSCore.ArrayBuffer ___notNullable_1 = (global::Natrix.JSCore.ArrayBuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DeviceMotionEventAcceleration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventAcceleration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DeviceMotionEventAcceleration? __element_164;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_164 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_164 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DeviceMotionEventAcceleration>(___notNullable_1);
        }
        return __element_164;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DeviceMotionEventAcceleration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventAcceleration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DeviceMotionEventAcceleration? __element_164;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_164 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_164 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DeviceMotionEventAcceleration>(___notNullable_1);
        }
        return __element_164;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventAcceleration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DeviceMotionEventAcceleration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DeviceMotionEventAcceleration ___notNullable_1 = (global::Natrix.StdWeb.DeviceMotionEventAcceleration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventAcceleration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DeviceMotionEventAcceleration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DeviceMotionEventAcceleration ___notNullable_1 = (global::Natrix.StdWeb.DeviceMotionEventAcceleration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DeviceMotionEventRotationRate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DeviceMotionEventRotationRate? __element_165;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_165 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_165 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DeviceMotionEventRotationRate>(___notNullable_1);
        }
        return __element_165;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DeviceMotionEventRotationRate? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRate?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DeviceMotionEventRotationRate? __element_165;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_165 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_165 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DeviceMotionEventRotationRate>(___notNullable_1);
        }
        return __element_165;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DeviceMotionEventRotationRate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DeviceMotionEventRotationRate ___notNullable_1 = (global::Natrix.StdWeb.DeviceMotionEventRotationRate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DeviceMotionEventRotationRate?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DeviceMotionEventRotationRate? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DeviceMotionEventRotationRate ___notNullable_1 = (global::Natrix.StdWeb.DeviceMotionEventRotationRate)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CanvasPattern? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CanvasPattern?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CanvasPattern? __element_166;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_166 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_166 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CanvasPattern>(___notNullable_1);
        }
        return __element_166;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CanvasPattern? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CanvasPattern?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CanvasPattern? __element_166;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_166 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_166 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CanvasPattern>(___notNullable_1);
        }
        return __element_166;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CanvasPattern?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CanvasPattern? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CanvasPattern ___notNullable_1 = (global::Natrix.StdWeb.CanvasPattern)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CanvasPattern?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CanvasPattern? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CanvasPattern ___notNullable_1 = (global::Natrix.StdWeb.CanvasPattern)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Touch? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Touch?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Touch? __element_167;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_167 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_167 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Touch>(___notNullable_1);
        }
        return __element_167;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Touch? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Touch?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Touch? __element_167;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_167 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_167 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Touch>(___notNullable_1);
        }
        return __element_167;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Touch?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Touch? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Touch ___notNullable_1 = (global::Natrix.StdWeb.Touch)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Touch?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Touch? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Touch ___notNullable_1 = (global::Natrix.StdWeb.Touch)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSAnimation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSAnimation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSAnimation? __element_168;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_168 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_168 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSAnimation>(___notNullable_1);
        }
        return __element_168;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSAnimation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSAnimation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSAnimation? __element_168;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_168 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_168 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSAnimation>(___notNullable_1);
        }
        return __element_168;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSAnimation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSAnimation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSAnimation ___notNullable_1 = (global::Natrix.StdWeb.CSSAnimation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSAnimation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSAnimation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSAnimation ___notNullable_1 = (global::Natrix.StdWeb.CSSAnimation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSKeyframeRule? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSKeyframeRule?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSKeyframeRule? __element_169;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_169 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_169 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSKeyframeRule>(___notNullable_1);
        }
        return __element_169;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSKeyframeRule? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSKeyframeRule?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSKeyframeRule? __element_169;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_169 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_169 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSKeyframeRule>(___notNullable_1);
        }
        return __element_169;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSKeyframeRule?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSKeyframeRule? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSKeyframeRule ___notNullable_1 = (global::Natrix.StdWeb.CSSKeyframeRule)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSKeyframeRule?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSKeyframeRule? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSKeyframeRule ___notNullable_1 = (global::Natrix.StdWeb.CSSKeyframeRule)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSRule? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSRule?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CSSRule? __element_170;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_170 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_170 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSRule>(___notNullable_1);
        }
        return __element_170;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CSSRule? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSRule?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CSSRule? __element_170;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_170 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_170 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.CSSRule>(___notNullable_1);
        }
        return __element_170;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSRule?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CSSRule? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSRule ___notNullable_1 = (global::Natrix.StdWeb.CSSRule)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CSSRule?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CSSRule? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CSSRule ___notNullable_1 = (global::Natrix.StdWeb.CSSRule)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NodeFilter? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeFilter?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NodeFilter? __element_171;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_171 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_171 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NodeFilter>(___notNullable_1);
        }
        return __element_171;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NodeFilter? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeFilter?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NodeFilter? __element_171;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_171 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_171 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NodeFilter>(___notNullable_1);
        }
        return __element_171;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeFilter?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NodeFilter? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NodeFilter ___notNullable_1 = (global::Natrix.StdWeb.NodeFilter)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NodeFilter?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NodeFilter? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NodeFilter ___notNullable_1 = (global::Natrix.StdWeb.NodeFilter)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ReportBody? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReportBody?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ReportBody? __element_172;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_172 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_172 = new global::Natrix.StdWeb.ReportBody(___notNullable_1);
        }
        return __element_172;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ReportBody? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReportBody?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ReportBody? __element_172;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_172 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_172 = new global::Natrix.StdWeb.ReportBody(___notNullable_1);
        }
        return __element_172;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReportBody?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ReportBody? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ReportBody ___notNullable_1 = (global::Natrix.StdWeb.ReportBody)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ReportBody?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ReportBody? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ReportBody ___notNullable_1 = (global::Natrix.StdWeb.ReportBody)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.BackgroundFetchRegistration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.BackgroundFetchRegistration? __element_173;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_173 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_173 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.BackgroundFetchRegistration>(___notNullable_1);
        }
        return __element_173;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.BackgroundFetchRegistration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.BackgroundFetchRegistration? __element_173;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_173 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_173 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.BackgroundFetchRegistration>(___notNullable_1);
        }
        return __element_173;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.BackgroundFetchRegistration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.BackgroundFetchRegistration ___notNullable_1 = (global::Natrix.StdWeb.BackgroundFetchRegistration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.BackgroundFetchRegistration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.BackgroundFetchRegistration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.BackgroundFetchRegistration ___notNullable_1 = (global::Natrix.StdWeb.BackgroundFetchRegistration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ContactAddress? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ContactAddress?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ContactAddress? __element_174;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_174 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_174 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ContactAddress>(___notNullable_1);
        }
        return __element_174;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ContactAddress? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ContactAddress?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ContactAddress? __element_174;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_174 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_174 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ContactAddress>(___notNullable_1);
        }
        return __element_174;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ContactAddress?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ContactAddress? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ContactAddress ___notNullable_1 = (global::Natrix.StdWeb.ContactAddress)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ContactAddress?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ContactAddress? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ContactAddress ___notNullable_1 = (global::Natrix.StdWeb.ContactAddress)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PaymentShippingType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentShippingType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PaymentShippingType? __element_175;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_175 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_175 = global::Natrix.StdWeb.PaymentShippingType.Create(___notNullable_1);
        }
        return __element_175;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PaymentShippingType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentShippingType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PaymentShippingType? __element_175;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_175 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_175 = global::Natrix.StdWeb.PaymentShippingType.Create(___notNullable_1);
        }
        return __element_175;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentShippingType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PaymentShippingType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PaymentShippingType ___notNullable_1 = (global::Natrix.StdWeb.PaymentShippingType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PaymentShippingType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PaymentShippingType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PaymentShippingType ___notNullable_1 = (global::Natrix.StdWeb.PaymentShippingType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRHand? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRHand?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRHand? __element_176;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_176 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_176 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRHand>(___notNullable_1);
        }
        return __element_176;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRHand? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRHand?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRHand? __element_176;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_176 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_176 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRHand>(___notNullable_1);
        }
        return __element_176;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRHand?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRHand? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRHand ___notNullable_1 = (global::Natrix.StdWeb.XRHand)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRHand?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRHand? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRHand ___notNullable_1 = (global::Natrix.StdWeb.XRHand)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRSpace? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRSpace?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRSpace? __element_177;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_177 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_177 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRSpace>(___notNullable_1);
        }
        return __element_177;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRSpace? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRSpace?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRSpace? __element_177;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_177 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_177 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRSpace>(___notNullable_1);
        }
        return __element_177;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRSpace?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRSpace? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRSpace ___notNullable_1 = (global::Natrix.StdWeb.XRSpace)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRSpace?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRSpace? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRSpace ___notNullable_1 = (global::Natrix.StdWeb.XRSpace)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.LanguageModelParams? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LanguageModelParams?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.LanguageModelParams? __element_178;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_178 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_178 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.LanguageModelParams>(___notNullable_1);
        }
        return __element_178;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.LanguageModelParams? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LanguageModelParams?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.LanguageModelParams? __element_178;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_178 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_178 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.LanguageModelParams>(___notNullable_1);
        }
        return __element_178;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LanguageModelParams?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.LanguageModelParams? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.LanguageModelParams ___notNullable_1 = (global::Natrix.StdWeb.LanguageModelParams)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LanguageModelParams?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.LanguageModelParams? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.LanguageModelParams ___notNullable_1 = (global::Natrix.StdWeb.LanguageModelParams)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.URL? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URL?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.URL? __element_179;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_179 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_179 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.URL>(___notNullable_1);
        }
        return __element_179;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.URL? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URL?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.URL? __element_179;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_179 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_179 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.URL>(___notNullable_1);
        }
        return __element_179;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URL?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.URL? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.URL ___notNullable_1 = (global::Natrix.StdWeb.URL)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.URL?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.URL? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.URL ___notNullable_1 = (global::Natrix.StdWeb.URL)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_180;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_180 = null;
        }
        else
        {
            __element_180 = new global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_180;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_180;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_180 = null;
        }
        else
        {
            __element_180 = new global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_180;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.Blob, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.InputDeviceCapabilities? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.InputDeviceCapabilities? __element_181;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_181 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_181 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.InputDeviceCapabilities>(___notNullable_1);
        }
        return __element_181;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.InputDeviceCapabilities? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.InputDeviceCapabilities? __element_181;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_181 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_181 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.InputDeviceCapabilities>(___notNullable_1);
        }
        return __element_181;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.InputDeviceCapabilities? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.InputDeviceCapabilities ___notNullable_1 = (global::Natrix.StdWeb.InputDeviceCapabilities)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.InputDeviceCapabilities?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.InputDeviceCapabilities? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.InputDeviceCapabilities ___notNullable_1 = (global::Natrix.StdWeb.InputDeviceCapabilities)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SpeechSynthesisVoice? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SpeechSynthesisVoice? __element_182;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_182 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_182 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SpeechSynthesisVoice>(___notNullable_1);
        }
        return __element_182;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SpeechSynthesisVoice? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SpeechSynthesisVoice? __element_182;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_182 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_182 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SpeechSynthesisVoice>(___notNullable_1);
        }
        return __element_182;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SpeechSynthesisVoice? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SpeechSynthesisVoice ___notNullable_1 = (global::Natrix.StdWeb.SpeechSynthesisVoice)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SpeechSynthesisVoice?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SpeechSynthesisVoice? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SpeechSynthesisVoice ___notNullable_1 = (global::Natrix.StdWeb.SpeechSynthesisVoice)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>? __element_183;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_183 = null;
        }
        else
        {
            __element_183 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_183;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>? __element_183;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_183 = null;
        }
        else
        {
            __element_183 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_183;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.XRLayer, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLFramebuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLFramebuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLFramebuffer? __element_184;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_184 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_184 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLFramebuffer>(___notNullable_1);
        }
        return __element_184;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLFramebuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLFramebuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLFramebuffer? __element_184;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_184 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_184 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLFramebuffer>(___notNullable_1);
        }
        return __element_184;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLFramebuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLFramebuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLFramebuffer ___notNullable_1 = (global::Natrix.StdWeb.WebGLFramebuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLFramebuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLFramebuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLFramebuffer ___notNullable_1 = (global::Natrix.StdWeb.WebGLFramebuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRViewport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.XRViewport? __element_185;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_185 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_185 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRViewport>(___notNullable_1);
        }
        return __element_185;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.XRViewport? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewport?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.XRViewport? __element_185;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_185 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_185 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.XRViewport>(___notNullable_1);
        }
        return __element_185;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.XRViewport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRViewport ___notNullable_1 = (global::Natrix.StdWeb.XRViewport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.XRViewport?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.XRViewport? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.XRViewport ___notNullable_1 = (global::Natrix.StdWeb.XRViewport)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WritableStream? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WritableStream?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WritableStream? __element_186;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_186 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_186 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WritableStream>(___notNullable_1);
        }
        return __element_186;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WritableStream? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WritableStream?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WritableStream? __element_186;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_186 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_186 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WritableStream>(___notNullable_1);
        }
        return __element_186;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WritableStream?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WritableStream? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WritableStream ___notNullable_1 = (global::Natrix.StdWeb.WritableStream)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WritableStream?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WritableStream? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WritableStream ___notNullable_1 = (global::Natrix.StdWeb.WritableStream)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ServiceWorkerRegistration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ServiceWorkerRegistration? __element_187;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_187 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_187 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ServiceWorkerRegistration>(___notNullable_1);
        }
        return __element_187;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ServiceWorkerRegistration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ServiceWorkerRegistration? __element_187;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_187 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_187 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ServiceWorkerRegistration>(___notNullable_1);
        }
        return __element_187;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ServiceWorkerRegistration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ServiceWorkerRegistration ___notNullable_1 = (global::Natrix.StdWeb.ServiceWorkerRegistration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ServiceWorkerRegistration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ServiceWorkerRegistration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ServiceWorkerRegistration ___notNullable_1 = (global::Natrix.StdWeb.ServiceWorkerRegistration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Client? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Client?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Client? __element_188;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_188 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_188 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Client>(___notNullable_1);
        }
        return __element_188;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Client? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Client?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Client? __element_188;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_188 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_188 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Client>(___notNullable_1);
        }
        return __element_188;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Client?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Client? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Client ___notNullable_1 = (global::Natrix.StdWeb.Client)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Client?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Client? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Client ___notNullable_1 = (global::Natrix.StdWeb.Client)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_189;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_189 = null;
        }
        else
        {
            __element_189 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_189;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_189;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_189 = null;
        }
        else
        {
            __element_189 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_189;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Client, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Response? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Response?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Response? __element_190;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_190 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_190 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Response>(___notNullable_1);
        }
        return __element_190;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Response? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Response?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Response? __element_190;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_190 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_190 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Response>(___notNullable_1);
        }
        return __element_190;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Response?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Response? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Response ___notNullable_1 = (global::Natrix.StdWeb.Response)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Response?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Response? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Response ___notNullable_1 = (global::Natrix.StdWeb.Response)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>? __element_191;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_191 = null;
        }
        else
        {
            __element_191 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_191;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>? __element_191;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_191 = null;
        }
        else
        {
            __element_191 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_191;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.NDEFRecord, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PushSubscription? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushSubscription?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PushSubscription? __element_192;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_192 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_192 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PushSubscription>(___notNullable_1);
        }
        return __element_192;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PushSubscription? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushSubscription?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PushSubscription? __element_192;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_192 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_192 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PushSubscription>(___notNullable_1);
        }
        return __element_192;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushSubscription?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PushSubscription? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PushSubscription ___notNullable_1 = (global::Natrix.StdWeb.PushSubscription)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushSubscription?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PushSubscription? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PushSubscription ___notNullable_1 = (global::Natrix.StdWeb.PushSubscription)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_193;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_193 = null;
        }
        else
        {
            __element_193 = new global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_193;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_193;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_193 = null;
        }
        else
        {
            __element_193 = new global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_193;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Int8Array, global::Natrix.JSCore.Int16Array, global::Natrix.JSCore.Int32Array, global::Natrix.JSCore.Uint8Array, global::Natrix.JSCore.Uint16Array, global::Natrix.JSCore.Uint32Array, global::Natrix.JSCore.Uint8ClampedArray, global::Natrix.JSCore.BigInt64Array, global::Natrix.JSCore.BigUint64Array, global::Natrix.JSCore.Float16Array, global::Natrix.JSCore.Float32Array, global::Natrix.JSCore.Float64Array, global::Natrix.JSCore.DataView, global::Natrix.JSCore.ArrayBuffer, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PushMessageData? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushMessageData?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.PushMessageData? __element_194;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_194 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_194 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PushMessageData>(___notNullable_1);
        }
        return __element_194;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.PushMessageData? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushMessageData?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.PushMessageData? __element_194;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_194 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_194 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.PushMessageData>(___notNullable_1);
        }
        return __element_194;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushMessageData?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.PushMessageData? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PushMessageData ___notNullable_1 = (global::Natrix.StdWeb.PushMessageData)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.PushMessageData?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.PushMessageData? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.PushMessageData ___notNullable_1 = (global::Natrix.StdWeb.PushMessageData)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Notification? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Notification?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Notification? __element_195;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_195 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_195 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Notification>(___notNullable_1);
        }
        return __element_195;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Notification? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Notification?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Notification? __element_195;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_195 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_195 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Notification>(___notNullable_1);
        }
        return __element_195;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Notification?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Notification? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Notification ___notNullable_1 = (global::Natrix.StdWeb.Notification)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Notification?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Notification? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Notification ___notNullable_1 = (global::Natrix.StdWeb.Notification)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.USBConfiguration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.USBConfiguration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.USBConfiguration? __element_196;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_196 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_196 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.USBConfiguration>(___notNullable_1);
        }
        return __element_196;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.USBConfiguration? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.USBConfiguration?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.USBConfiguration? __element_196;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_196 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_196 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.USBConfiguration>(___notNullable_1);
        }
        return __element_196;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.USBConfiguration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.USBConfiguration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.USBConfiguration ___notNullable_1 = (global::Natrix.StdWeb.USBConfiguration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.USBConfiguration?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.USBConfiguration? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.USBConfiguration ___notNullable_1 = (global::Natrix.StdWeb.USBConfiguration)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.LoadDocumentCallback? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LoadDocumentCallback?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.LoadDocumentCallback? __element_197;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_197 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_197 = new global::Natrix.StdWeb.LoadDocumentCallback(___notNullable_1);
        }
        return __element_197;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.LoadDocumentCallback? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LoadDocumentCallback?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.LoadDocumentCallback? __element_197;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_197 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_197 = new global::Natrix.StdWeb.LoadDocumentCallback(___notNullable_1);
        }
        return __element_197;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LoadDocumentCallback?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.LoadDocumentCallback? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.LoadDocumentCallback ___notNullable_1 = (global::Natrix.StdWeb.LoadDocumentCallback)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.LoadDocumentCallback?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.LoadDocumentCallback? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.LoadDocumentCallback ___notNullable_1 = (global::Natrix.StdWeb.LoadDocumentCallback)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_198;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_198 = null;
        }
        else
        {
            __element_198 = new global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_198;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_198;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_198 = null;
        }
        else
        {
            __element_198 = new global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_198;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.JSCore.Generics.Record<global::Natrix.JSCore.Generics.Union<double, global::System.Numerics.BigInteger, string, bool, global::System.Runtime.InteropServices.JavaScript.JSObject, object, global::Natrix.StdWeb.GenericMarshaller.Union>?, global::Natrix.StdWeb.PropertyAccessorNullable>, string, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>? __element_199;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_199 = null;
        }
        else
        {
            __element_199 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_199;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>? __element_199;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_199 = null;
        }
        else
        {
            __element_199 = new global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_199;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<global::Natrix.StdWeb.Node, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaKeyStatus? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeyStatus?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MediaKeyStatus? __element_200;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_200 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_200 = global::Natrix.StdWeb.MediaKeyStatus.Create(___notNullable_1);
        }
        return __element_200;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MediaKeyStatus? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeyStatus?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MediaKeyStatus? __element_200;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_200 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_200 = global::Natrix.StdWeb.MediaKeyStatus.Create(___notNullable_1);
        }
        return __element_200;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeyStatus?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MediaKeyStatus? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeyStatus ___notNullable_1 = (global::Natrix.StdWeb.MediaKeyStatus)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MediaKeyStatus?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MediaKeyStatus? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MediaKeyStatus ___notNullable_1 = (global::Natrix.StdWeb.MediaKeyStatus)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationTriggerBehavior? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AnimationTriggerBehavior? __element_201;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_201 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_201 = global::Natrix.StdWeb.AnimationTriggerBehavior.Create(___notNullable_1);
        }
        return __element_201;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AnimationTriggerBehavior? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AnimationTriggerBehavior? __element_201;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_201 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_201 = global::Natrix.StdWeb.AnimationTriggerBehavior.Create(___notNullable_1);
        }
        return __element_201;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AnimationTriggerBehavior? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTriggerBehavior ___notNullable_1 = (global::Natrix.StdWeb.AnimationTriggerBehavior)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AnimationTriggerBehavior?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AnimationTriggerBehavior? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AnimationTriggerBehavior ___notNullable_1 = (global::Natrix.StdWeb.AnimationTriggerBehavior)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_202;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_202 = null;
        }
        else
        {
            __element_202 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_202;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_202;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_202 = null;
        }
        else
        {
            __element_202 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_202;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.HTMLCollection, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_203;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_203 = null;
        }
        else
        {
            __element_203 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_203;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_203;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_203 = null;
        }
        else
        {
            __element_203 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_203;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.RadioNodeList, global::Natrix.StdWeb.Element, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AudioTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AudioTrack? __element_204;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_204 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_204 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioTrack>(___notNullable_1);
        }
        return __element_204;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AudioTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AudioTrack? __element_204;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_204 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_204 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioTrack>(___notNullable_1);
        }
        return __element_204;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AudioTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AudioTrack ___notNullable_1 = (global::Natrix.StdWeb.AudioTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AudioTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AudioTrack ___notNullable_1 = (global::Natrix.StdWeb.AudioTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SourceBuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SourceBuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.SourceBuffer? __element_205;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_205 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_205 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SourceBuffer>(___notNullable_1);
        }
        return __element_205;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.SourceBuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SourceBuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.SourceBuffer? __element_205;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_205 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_205 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.SourceBuffer>(___notNullable_1);
        }
        return __element_205;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SourceBuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.SourceBuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SourceBuffer ___notNullable_1 = (global::Natrix.StdWeb.SourceBuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.SourceBuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.SourceBuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.SourceBuffer ___notNullable_1 = (global::Natrix.StdWeb.SourceBuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VideoTrack? __element_206;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_206 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_206 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VideoTrack>(___notNullable_1);
        }
        return __element_206;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VideoTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VideoTrack? __element_206;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_206 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_206 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VideoTrack>(___notNullable_1);
        }
        return __element_206;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VideoTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoTrack ___notNullable_1 = (global::Natrix.StdWeb.VideoTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VideoTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VideoTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VideoTrack ___notNullable_1 = (global::Natrix.StdWeb.VideoTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TextTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.TextTrack? __element_207;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_207 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_207 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrack>(___notNullable_1);
        }
        return __element_207;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TextTrack? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrack?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.TextTrack? __element_207;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_207 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_207 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrack>(___notNullable_1);
        }
        return __element_207;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.TextTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TextTrack ___notNullable_1 = (global::Natrix.StdWeb.TextTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrack?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.TextTrack? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TextTrack ___notNullable_1 = (global::Natrix.StdWeb.TextTrack)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TextTrackCueList? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCueList?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.TextTrackCueList? __element_208;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_208 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_208 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrackCueList>(___notNullable_1);
        }
        return __element_208;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TextTrackCueList? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCueList?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.TextTrackCueList? __element_208;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_208 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_208 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrackCueList>(___notNullable_1);
        }
        return __element_208;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCueList?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.TextTrackCueList? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TextTrackCueList ___notNullable_1 = (global::Natrix.StdWeb.TextTrackCueList)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCueList?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.TextTrackCueList? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TextTrackCueList ___notNullable_1 = (global::Natrix.StdWeb.TextTrackCueList)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TextTrackCue? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCue?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.TextTrackCue? __element_209;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_209 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_209 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrackCue>(___notNullable_1);
        }
        return __element_209;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.TextTrackCue? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCue?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.TextTrackCue? __element_209;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_209 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_209 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.TextTrackCue>(___notNullable_1);
        }
        return __element_209;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCue?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.TextTrackCue? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TextTrackCue ___notNullable_1 = (global::Natrix.StdWeb.TextTrackCue)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.TextTrackCue?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.TextTrackCue? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.TextTrackCue ___notNullable_1 = (global::Natrix.StdWeb.TextTrackCue)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_210;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_210 = null;
        }
        else
        {
            __element_210 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_210;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_210;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_210 = null;
        }
        else
        {
            __element_210 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_210;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.VideoTrack, global::Natrix.StdWeb.AudioTrack, global::Natrix.StdWeb.TextTrack, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLTableCaptionElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableCaptionElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLTableCaptionElement? __element_211;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_211 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_211 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLTableCaptionElement>(___notNullable_1);
        }
        return __element_211;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLTableCaptionElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableCaptionElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLTableCaptionElement? __element_211;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_211 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_211 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLTableCaptionElement>(___notNullable_1);
        }
        return __element_211;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableCaptionElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLTableCaptionElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLTableCaptionElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLTableCaptionElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableCaptionElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLTableCaptionElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLTableCaptionElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLTableCaptionElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLTableSectionElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableSectionElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLTableSectionElement? __element_212;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_212 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_212 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLTableSectionElement>(___notNullable_1);
        }
        return __element_212;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLTableSectionElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableSectionElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLTableSectionElement? __element_212;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_212 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_212 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLTableSectionElement>(___notNullable_1);
        }
        return __element_212;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableSectionElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLTableSectionElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLTableSectionElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLTableSectionElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLTableSectionElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLTableSectionElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLTableSectionElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLTableSectionElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLOptionElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLOptionElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.HTMLOptionElement? __element_213;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_213 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_213 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLOptionElement>(___notNullable_1);
        }
        return __element_213;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.HTMLOptionElement? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLOptionElement?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.HTMLOptionElement? __element_213;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_213 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_213 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.HTMLOptionElement>(___notNullable_1);
        }
        return __element_213;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLOptionElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.HTMLOptionElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLOptionElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLOptionElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.HTMLOptionElement?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.HTMLOptionElement? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.HTMLOptionElement ___notNullable_1 = (global::Natrix.StdWeb.HTMLOptionElement)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_214;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_214 = null;
        }
        else
        {
            __element_214 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_214;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_214;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_214 = null;
        }
        else
        {
            __element_214 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_214;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.OffscreenCanvasRenderingContext2D, global::Natrix.StdWeb.ImageBitmapRenderingContext, global::Natrix.StdWeb.WebGLRenderingContext, global::Natrix.StdWeb.WebGL2RenderingContext, global::Natrix.StdWeb.GPUCanvasContext, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CustomElementConstructor? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementConstructor?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.CustomElementConstructor? __element_215;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_215 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_215 = new global::Natrix.StdWeb.CustomElementConstructor(___notNullable_1);
        }
        return __element_215;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.CustomElementConstructor? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementConstructor?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.CustomElementConstructor? __element_215;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_215 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_215 = new global::Natrix.StdWeb.CustomElementConstructor(___notNullable_1);
        }
        return __element_215;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementConstructor?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.CustomElementConstructor? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CustomElementConstructor ___notNullable_1 = (global::Natrix.StdWeb.CustomElementConstructor)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.CustomElementConstructor?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.CustomElementConstructor? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.CustomElementConstructor ___notNullable_1 = (global::Natrix.StdWeb.CustomElementConstructor)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DataTransferItem? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransferItem?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DataTransferItem? __element_216;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_216 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_216 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DataTransferItem>(___notNullable_1);
        }
        return __element_216;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DataTransferItem? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransferItem?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DataTransferItem? __element_216;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_216 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_216 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DataTransferItem>(___notNullable_1);
        }
        return __element_216;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransferItem?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DataTransferItem? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DataTransferItem ___notNullable_1 = (global::Natrix.StdWeb.DataTransferItem)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DataTransferItem?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DataTransferItem? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DataTransferItem ___notNullable_1 = (global::Natrix.StdWeb.DataTransferItem)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationHistoryEntry? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NavigationHistoryEntry? __element_217;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_217 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_217 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NavigationHistoryEntry>(___notNullable_1);
        }
        return __element_217;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationHistoryEntry? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NavigationHistoryEntry? __element_217;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_217 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_217 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NavigationHistoryEntry>(___notNullable_1);
        }
        return __element_217;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NavigationHistoryEntry? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationHistoryEntry ___notNullable_1 = (global::Natrix.StdWeb.NavigationHistoryEntry)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationHistoryEntry?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NavigationHistoryEntry? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationHistoryEntry ___notNullable_1 = (global::Natrix.StdWeb.NavigationHistoryEntry)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationTransition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationTransition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NavigationTransition? __element_218;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_218 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_218 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NavigationTransition>(___notNullable_1);
        }
        return __element_218;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationTransition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationTransition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NavigationTransition? __element_218;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_218 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_218 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NavigationTransition>(___notNullable_1);
        }
        return __element_218;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationTransition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NavigationTransition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationTransition ___notNullable_1 = (global::Natrix.StdWeb.NavigationTransition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationTransition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NavigationTransition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationTransition ___notNullable_1 = (global::Natrix.StdWeb.NavigationTransition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationActivation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationActivation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NavigationActivation? __element_219;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_219 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_219 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NavigationActivation>(___notNullable_1);
        }
        return __element_219;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationActivation? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationActivation?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NavigationActivation? __element_219;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_219 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_219 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.NavigationActivation>(___notNullable_1);
        }
        return __element_219;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationActivation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NavigationActivation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationActivation ___notNullable_1 = (global::Natrix.StdWeb.NavigationActivation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationActivation?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NavigationActivation? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationActivation ___notNullable_1 = (global::Natrix.StdWeb.NavigationActivation)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FormData? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FormData?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.FormData? __element_220;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_220 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_220 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FormData>(___notNullable_1);
        }
        return __element_220;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FormData? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FormData?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.FormData? __element_220;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_220 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_220 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FormData>(___notNullable_1);
        }
        return __element_220;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FormData?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.FormData? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FormData ___notNullable_1 = (global::Natrix.StdWeb.FormData)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FormData?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.FormData? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FormData ___notNullable_1 = (global::Natrix.StdWeb.FormData)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.NavigationType? __element_221;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_221 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_221 = global::Natrix.StdWeb.NavigationType.Create(___notNullable_1);
        }
        return __element_221;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.NavigationType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.NavigationType? __element_221;
        string? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsStringV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_221 = null;
        }
        else
        {
            string ___notNullable_1 = (string)___res_0;
            __element_221 = global::Natrix.StdWeb.NavigationType.Create(___notNullable_1);
        }
        return __element_221;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.NavigationType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationType ___notNullable_1 = (global::Natrix.StdWeb.NavigationType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.NavigationType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.NavigationType? value)
    {
        string? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.NavigationType ___notNullable_1 = (global::Natrix.StdWeb.NavigationType)value;
            ___marshalledValue_0 = ___notNullable_1.ToString();
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsStringV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? __element_222;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_222 = null;
        }
        else
        {
            __element_222 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_222;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? __element_222;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_222 = null;
        }
        else
        {
            __element_222 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_222;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasonDetails, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? __element_223;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_223 = null;
        }
        else
        {
            __element_223 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_223;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? __element_223;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_223 = null;
        }
        else
        {
            __element_223 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_223;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.NotRestoredReasons, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Plugin? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Plugin?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Plugin? __element_224;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_224 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_224 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Plugin>(___notNullable_1);
        }
        return __element_224;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Plugin? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Plugin?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Plugin? __element_224;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_224 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_224 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Plugin>(___notNullable_1);
        }
        return __element_224;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Plugin?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Plugin? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Plugin ___notNullable_1 = (global::Natrix.StdWeb.Plugin)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Plugin?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Plugin? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Plugin ___notNullable_1 = (global::Natrix.StdWeb.Plugin)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MimeType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MimeType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MimeType? __element_225;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_225 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_225 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MimeType>(___notNullable_1);
        }
        return __element_225;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MimeType? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MimeType?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MimeType? __element_225;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_225 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_225 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MimeType>(___notNullable_1);
        }
        return __element_225;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MimeType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MimeType? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MimeType ___notNullable_1 = (global::Natrix.StdWeb.MimeType)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MimeType?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MimeType? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MimeType ___notNullable_1 = (global::Natrix.StdWeb.MimeType)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_226;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_226 = null;
        }
        else
        {
            __element_226 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_226;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_226;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_226 = null;
        }
        else
        {
            __element_226 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_226;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Window, global::Natrix.StdWeb.MessagePort, global::Natrix.StdWeb.ServiceWorker, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Storage? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Storage?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.Storage? __element_227;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_227 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_227 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Storage>(___notNullable_1);
        }
        return __element_227;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.Storage? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Storage?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.Storage? __element_227;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_227 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_227 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.Storage>(___notNullable_1);
        }
        return __element_227;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Storage?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.Storage? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Storage ___notNullable_1 = (global::Natrix.StdWeb.Storage)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.Storage?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.Storage? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.Storage ___notNullable_1 = (global::Natrix.StdWeb.Storage)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GeolocationPosition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPosition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GeolocationPosition? __element_228;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_228 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_228 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GeolocationPosition>(___notNullable_1);
        }
        return __element_228;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GeolocationPosition? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPosition?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GeolocationPosition? __element_228;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_228 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_228 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GeolocationPosition>(___notNullable_1);
        }
        return __element_228;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPosition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GeolocationPosition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GeolocationPosition ___notNullable_1 = (global::Natrix.StdWeb.GeolocationPosition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPosition?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GeolocationPosition? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GeolocationPosition ___notNullable_1 = (global::Natrix.StdWeb.GeolocationPosition)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GeolocationPositionError? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPositionError?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.GeolocationPositionError? __element_229;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_229 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_229 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GeolocationPositionError>(___notNullable_1);
        }
        return __element_229;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.GeolocationPositionError? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPositionError?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.GeolocationPositionError? __element_229;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_229 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_229 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.GeolocationPositionError>(___notNullable_1);
        }
        return __element_229;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPositionError?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.GeolocationPositionError? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GeolocationPositionError ___notNullable_1 = (global::Natrix.StdWeb.GeolocationPositionError)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.GeolocationPositionError?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.GeolocationPositionError? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.GeolocationPositionError ___notNullable_1 = (global::Natrix.StdWeb.GeolocationPositionError)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FencedFrameConfig? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FencedFrameConfig?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.FencedFrameConfig? __element_230;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_230 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_230 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FencedFrameConfig>(___notNullable_1);
        }
        return __element_230;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.FencedFrameConfig? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FencedFrameConfig?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.FencedFrameConfig? __element_230;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_230 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_230 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.FencedFrameConfig>(___notNullable_1);
        }
        return __element_230;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FencedFrameConfig?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.FencedFrameConfig? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FencedFrameConfig ___notNullable_1 = (global::Natrix.StdWeb.FencedFrameConfig)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.FencedFrameConfig?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.FencedFrameConfig? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.FencedFrameConfig ___notNullable_1 = (global::Natrix.StdWeb.FencedFrameConfig)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLQuery? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLQuery?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLQuery? __element_231;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_231 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_231 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLQuery>(___notNullable_1);
        }
        return __element_231;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLQuery? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLQuery?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLQuery? __element_231;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_231 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_231 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLQuery>(___notNullable_1);
        }
        return __element_231;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLQuery?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLQuery? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLQuery ___notNullable_1 = (global::Natrix.StdWeb.WebGLQuery)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLQuery?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLQuery? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLQuery ___notNullable_1 = (global::Natrix.StdWeb.WebGLQuery)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLSync? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLSync?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.WebGLSync? __element_232;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_232 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_232 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLSync>(___notNullable_1);
        }
        return __element_232;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.WebGLSync? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLSync?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.WebGLSync? __element_232;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_232 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_232 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.WebGLSync>(___notNullable_1);
        }
        return __element_232;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLSync?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.WebGLSync? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLSync ___notNullable_1 = (global::Natrix.StdWeb.WebGLSync)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.WebGLSync?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.WebGLSync? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.WebGLSync ___notNullable_1 = (global::Natrix.StdWeb.WebGLSync)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>? __element_233;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_233 = null;
        }
        else
        {
            __element_233 = new global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_233;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>? __element_233;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_233 = null;
        }
        else
        {
            __element_233 = new global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_233;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.JSArray<uint, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VTTRegion? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VTTRegion?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.VTTRegion? __element_234;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_234 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_234 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VTTRegion>(___notNullable_1);
        }
        return __element_234;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.VTTRegion? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VTTRegion?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.VTTRegion? __element_234;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_234 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_234 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.VTTRegion>(___notNullable_1);
        }
        return __element_234;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VTTRegion?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.VTTRegion? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VTTRegion ___notNullable_1 = (global::Natrix.StdWeb.VTTRegion)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.VTTRegion?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.VTTRegion? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.VTTRegion ___notNullable_1 = (global::Natrix.StdWeb.VTTRegion)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ViewTransitionUpdateCallback? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransitionUpdateCallback?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ViewTransitionUpdateCallback? __element_235;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_235 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_235 = new global::Natrix.StdWeb.ViewTransitionUpdateCallback(___notNullable_1);
        }
        return __element_235;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ViewTransitionUpdateCallback? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransitionUpdateCallback?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ViewTransitionUpdateCallback? __element_235;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_235 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_235 = new global::Natrix.StdWeb.ViewTransitionUpdateCallback(___notNullable_1);
        }
        return __element_235;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransitionUpdateCallback?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ViewTransitionUpdateCallback? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ViewTransitionUpdateCallback ___notNullable_1 = (global::Natrix.StdWeb.ViewTransitionUpdateCallback)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ViewTransitionUpdateCallback?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ViewTransitionUpdateCallback? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ViewTransitionUpdateCallback ___notNullable_1 = (global::Natrix.StdWeb.ViewTransitionUpdateCallback)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_236;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_236 = null;
        }
        else
        {
            __element_236 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_236;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_236;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_236 = null;
        }
        else
        {
            __element_236 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_236;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.Element, global::Natrix.StdWeb.ProcessingInstruction, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MIDIPort? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MIDIPort?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.MIDIPort? __element_237;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_237 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_237 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MIDIPort>(___notNullable_1);
        }
        return __element_237;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.MIDIPort? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MIDIPort?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.MIDIPort? __element_237;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_237 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_237 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.MIDIPort>(___notNullable_1);
        }
        return __element_237;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MIDIPort?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.MIDIPort? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MIDIPort ___notNullable_1 = (global::Natrix.StdWeb.MIDIPort)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.MIDIPort?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.MIDIPort? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.MIDIPort ___notNullable_1 = (global::Natrix.StdWeb.MIDIPort)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>? __element_238;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_238 = null;
        }
        else
        {
            __element_238 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_238;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>? __element_238;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_238 = null;
        }
        else
        {
            __element_238 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_238;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.CSSParserRule, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMException? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMException?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.DOMException? __element_239;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_239 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_239 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMException>(___notNullable_1);
        }
        return __element_239;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.DOMException? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMException?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.DOMException? __element_239;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_239 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_239 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.DOMException>(___notNullable_1);
        }
        return __element_239;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMException?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.DOMException? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMException ___notNullable_1 = (global::Natrix.StdWeb.DOMException)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.DOMException?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.DOMException? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.DOMException ___notNullable_1 = (global::Natrix.StdWeb.DOMException)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_240;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_240 = null;
        }
        else
        {
            __element_240 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_240;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_240;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_240 = null;
        }
        else
        {
            __element_240 = new global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_240;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<global::Natrix.StdWeb.IDBObjectStore, global::Natrix.StdWeb.IDBIndex, global::Natrix.StdWeb.IDBCursor, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.IDBTransaction? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.IDBTransaction?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.IDBTransaction? __element_241;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_241 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_241 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.IDBTransaction>(___notNullable_1);
        }
        return __element_241;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.IDBTransaction? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.IDBTransaction?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.IDBTransaction? __element_241;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_241 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_241 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.IDBTransaction>(___notNullable_1);
        }
        return __element_241;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.IDBTransaction?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.IDBTransaction? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.IDBTransaction ___notNullable_1 = (global::Natrix.StdWeb.IDBTransaction)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.IDBTransaction?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.IDBTransaction? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.IDBTransaction ___notNullable_1 = (global::Natrix.StdWeb.IDBTransaction)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_242;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_242 = null;
        }
        else
        {
            __element_242 = new global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_242;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_242;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_242 = null;
        }
        else
        {
            __element_242 = new global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_242;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.Generics.JSArray<string, global::Natrix.StdWeb.PropertyAccessor>, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ChildBreakToken? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ChildBreakToken?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.ChildBreakToken? __element_243;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_243 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_243 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ChildBreakToken>(___notNullable_1);
        }
        return __element_243;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.ChildBreakToken? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ChildBreakToken?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.ChildBreakToken? __element_243;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_243 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_243 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.ChildBreakToken>(___notNullable_1);
        }
        return __element_243;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ChildBreakToken?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.ChildBreakToken? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ChildBreakToken ___notNullable_1 = (global::Natrix.StdWeb.ChildBreakToken)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.ChildBreakToken?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.ChildBreakToken? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.ChildBreakToken ___notNullable_1 = (global::Natrix.StdWeb.ChildBreakToken)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_244;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_244 = null;
        }
        else
        {
            __element_244 = new global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_244;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>? __element_244;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsUnionV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_244 = null;
        }
        else
        {
            __element_244 = new global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>(___propObject_0);
        }
        return __element_244;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.Union<string, global::Natrix.JSCore.ArrayBuffer, global::Natrix.StdWeb.GenericMarshaller.Union>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsUnionAsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? __element_245;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___propObject_0 is null)
        {
            __element_245 = null;
        }
        else
        {
            __element_245 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_245;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? __element_245;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        ___propObject_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___propObject_0 is null)
        {
            __element_245 = null;
        }
        else
        {
            __element_245 = new global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>(___propObject_0);
        }
        return __element_245;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.JSCore.Generics.FrozenArray<global::Natrix.StdWeb.DOMRect, global::Natrix.StdWeb.PropertyAccessor>? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___propObject_0;
        if (value is null)
        {
            ___propObject_0 = null;
        }
        else
        {
            ___propObject_0 = value.JSObject;
        }

        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___propObject_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AudioBuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioBuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.AudioBuffer? __element_246;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_246 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_246 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioBuffer>(___notNullable_1);
        }
        return __element_246;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.AudioBuffer? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioBuffer?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.AudioBuffer? __element_246;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_246 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_246 = global::Natrix.JSCore.JSObjectProxyFactory.GetProxy<global::Natrix.StdWeb.AudioBuffer>(___notNullable_1);
        }
        return __element_246;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioBuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.AudioBuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AudioBuffer ___notNullable_1 = (global::Natrix.StdWeb.AudioBuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.AudioBuffer?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.AudioBuffer? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.AudioBuffer ___notNullable_1 = (global::Natrix.StdWeb.AudioBuffer)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RefillCallback? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RefillCallback?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex)
    {
        global::Natrix.StdWeb.RefillCallback? __element_247;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyIndex);
        if (___res_0 is null)
        {
            __element_247 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_247 = new global::Natrix.StdWeb.RefillCallback(___notNullable_1);
        }
        return __element_247;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static global::Natrix.StdWeb.RefillCallback? global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RefillCallback?>.Get(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName)
    {
        global::Natrix.StdWeb.RefillCallback? __element_247;
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___res_0 = global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.GetPropertyAsJSObjectV2AsNullable(obj, propertyName);
        if (___res_0 is null)
        {
            __element_247 = null;
        }
        else
        {
            global::System.Runtime.InteropServices.JavaScript.JSObject ___notNullable_1 = (global::System.Runtime.InteropServices.JavaScript.JSObject)___res_0;
            __element_247 = new global::Natrix.StdWeb.RefillCallback(___notNullable_1);
        }
        return __element_247;
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RefillCallback?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, int propertyIndex, global::Natrix.StdWeb.RefillCallback? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RefillCallback ___notNullable_1 = (global::Natrix.StdWeb.RefillCallback)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyIndex, ___marshalledValue_0);
    }

    [global::System.Runtime.Versioning.SupportedOSPlatform("browser")]
    static void global::Natrix.JSCore.Generics.IPropertyAccessor<global::Natrix.StdWeb.RefillCallback?>.Set(global::System.Runtime.InteropServices.JavaScript.JSObject obj, string propertyName, global::Natrix.StdWeb.RefillCallback? value)
    {
        global::System.Runtime.InteropServices.JavaScript.JSObject? ___marshalledValue_0;
        if (value is null)
        {
            ___marshalledValue_0 = null;
        }
        else
        {
            global::Natrix.StdWeb.RefillCallback ___notNullable_1 = (global::Natrix.StdWeb.RefillCallback)value;
            ___marshalledValue_0 = ___notNullable_1.JSObject;
        }
        global::Natrix.JSCore.Extensions.JSObjectPropertyExtensions.SetPropertyAsJSObjectV2AsNullable(obj, propertyName, ___marshalledValue_0);
    }
}

#nullable disable
