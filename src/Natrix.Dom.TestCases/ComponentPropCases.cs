using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.Signals;

namespace Natrix.Dom.TestCases;

/// <summary>
/// Every prop a DOM component declares itself, one case each. The props every element inherits are
/// in <see cref="GlobalPropCases"/>, checked once on <see cref="Div"/>.
/// </summary>
public static class ComponentPropCases
{
    public static IEnumerable<DomCase> All() =>
    [
        Case("A.Href", () => new A { Props = new() { Href = S("/docs") } }, """<a href="/docs"></a>"""),
        Case("A.Target", () => new A { Props = new() { Target = S("_blank") } }, """<a target="_blank"></a>"""),
        Case("A.Rel", () => new A { Props = new() { Rel = S("noopener") } }, """<a rel="noopener"></a>"""),
        Case("A.Download", () => new A { Props = new() { Download = S("report.pdf") } }, """<a download="report.pdf"></a>"""),
        Case("A.Hreflang", () => new A { Props = new() { Hreflang = S("en") } }, """<a hreflang="en"></a>"""),
        Case("A.Ping", () => new A { Props = new() { Ping = S("/ping") } }, """<a ping="/ping"></a>"""),
        Case("A.ReferrerPolicy", () => new A { Props = new() { ReferrerPolicy = S("no-referrer") } }, """<a referrerpolicy="no-referrer"></a>"""),
        Case("A.Type", () => new A { Props = new() { Type = S("text/html") } }, """<a type="text/html"></a>"""),

        Case("Area.Alt", () => new Area { Props = new() { Alt = S("Logo") } }, """<area alt="Logo">"""),
        Case("Area.Coords", () => new Area { Props = new() { Coords = S("0,0,10,10") } }, """<area coords="0,0,10,10">"""),
        Case("Area.Shape", () => new Area { Props = new() { Shape = S("rect") } }, """<area shape="rect">"""),
        Case("Area.Href", () => new Area { Props = new() { Href = S("/docs") } }, """<area href="/docs">"""),
        Case("Area.Target", () => new Area { Props = new() { Target = S("_blank") } }, """<area target="_blank">"""),
        Case("Area.Download", () => new Area { Props = new() { Download = S("report.pdf") } }, """<area download="report.pdf">"""),
        Case("Area.Ping", () => new Area { Props = new() { Ping = S("/ping") } }, """<area ping="/ping">"""),
        Case("Area.Rel", () => new Area { Props = new() { Rel = S("noopener") } }, """<area rel="noopener">"""),
        Case("Area.ReferrerPolicy", () => new Area { Props = new() { ReferrerPolicy = S("no-referrer") } }, """<area referrerpolicy="no-referrer">"""),

        Case("Audio.Src", () => new Audio { Props = new() { Src = S("/media/clip") } }, """<audio src="/media/clip"></audio>"""),
        Case("Audio.Autoplay", () => new Audio { Props = new() { Autoplay = S(true) } }, """<audio autoplay></audio>"""),
        Case("Audio.Controls", () => new Audio { Props = new() { Controls = S(true) } }, """<audio controls></audio>"""),
        Case("Audio.Loop", () => new Audio { Props = new() { Loop = S(true) } }, """<audio loop></audio>"""),
        Case("Audio.Muted", () => new Audio { Props = new() { Muted = S(true) } }, """<audio muted></audio>""", browserHtml: """<audio></audio>""", property: ("muted", true)),
        Case("Audio.Preload", () => new Audio { Props = new() { Preload = S("none") } }, """<audio preload="none"></audio>"""),
        Case("Audio.CrossOrigin", () => new Audio { Props = new() { CrossOrigin = S<string?>("anonymous") } }, """<audio crossorigin="anonymous"></audio>"""),
        Case("Audio.DisableRemotePlayback", () => new Audio { Props = new() { DisableRemotePlayback = S(true) } }, """<audio disableremoteplayback></audio>"""),

        Case("Base.Href", () => new Base { Props = new() { Href = S("/docs") } }, """<base href="/docs">"""),
        Case("Base.Target", () => new Base { Props = new() { Target = S("_blank") } }, """<base target="_blank">"""),

        Case("Blockquote.Cite", () => new Blockquote { Props = new() { Cite = S("/source") } }, """<blockquote cite="/source"></blockquote>"""),

        Case("Button.Disabled", () => new Button { Props = new() { Disabled = S(true) } }, """<button disabled></button>"""),
        Case("Button.Name", () => new Button { Props = new() { Name = S("field") } }, """<button name="field"></button>"""),
        Case("Button.Type", () => new Button { Props = new() { Type = S("submit") } }, """<button type="submit"></button>"""),
        Case("Button.Value", () => new Button { Props = new() { Value = S("v") } }, """<button value="v"></button>"""),
        Case("Button.FormAction", () => new Button { Props = new() { FormAction = S("/submit") } }, """<button formaction="/submit"></button>"""),
        Case("Button.FormEnctype", () => new Button { Props = new() { FormEnctype = S("multipart/form-data") } }, """<button formenctype="multipart/form-data"></button>"""),
        Case("Button.FormMethod", () => new Button { Props = new() { FormMethod = S("post") } }, """<button formmethod="post"></button>"""),
        Case("Button.FormNoValidate", () => new Button { Props = new() { FormNoValidate = S(true) } }, """<button formnovalidate></button>"""),
        Case("Button.FormTarget", () => new Button { Props = new() { FormTarget = S("_self") } }, """<button formtarget="_self"></button>"""),

        Case("Canvas.Width", () => new Canvas { Props = new() { Width = S(3u) } }, """<canvas width="3"></canvas>"""),
        Case("Canvas.Height", () => new Canvas { Props = new() { Height = S(3u) } }, """<canvas height="3"></canvas>"""),

        Case("Col.Span", () => new Col { Props = new() { Span = S(3u) } }, """<col span="3">"""),

        Case("Colgroup.Span", () => new Colgroup { Props = new() { Span = S(3u) } }, """<colgroup span="3"></colgroup>"""),

        Case("Data.Value", () => new Data { Props = new() { Value = S("v") } }, """<data value="v"></data>"""),

        Case("Del.Cite", () => new Del { Props = new() { Cite = S("/source") } }, """<del cite="/source"></del>"""),
        Case("Del.DateTime", () => new Del { Props = new() { DateTime = S("2026-10-10") } }, """<del datetime="2026-10-10"></del>"""),

        Case("Details.Name", () => new Details { Props = new() { Name = S("field") } }, """<details name="field"></details>"""),
        Case("Details.Open", () => new Details { Props = new() { Open = S(true) } }, """<details open></details>"""),

        Case("Dialog.Open", () => new Dialog { Props = new() { Open = S(true) } }, """<dialog open></dialog>"""),

        Case("Embed.Src", () => new Embed { Props = new() { Src = S("/media/clip") } }, """<embed src="/media/clip">"""),
        Case("Embed.Type", () => new Embed { Props = new() { Type = S("video/mp4") } }, """<embed type="video/mp4">"""),
        Case("Embed.Width", () => new Embed { Props = new() { Width = S("300") } }, """<embed width="300">"""),
        Case("Embed.Height", () => new Embed { Props = new() { Height = S("150") } }, """<embed height="150">"""),

        Case("FieldSet.Disabled", () => new FieldSet { Props = new() { Disabled = S(true) } }, """<fieldset disabled></fieldset>"""),
        Case("FieldSet.Name", () => new FieldSet { Props = new() { Name = S("field") } }, """<fieldset name="field"></fieldset>"""),

        Case("Form.Action", () => new Form { Props = new() { Action = S("/submit") } }, """<form action="/submit"></form>"""),
        Case("Form.Autocomplete", () => new Form { Props = new() { Autocomplete = S("off") } }, """<form autocomplete="off"></form>"""),
        Case("Form.Enctype", () => new Form { Props = new() { Enctype = S("multipart/form-data") } }, """<form enctype="multipart/form-data"></form>"""),
        Case("Form.Method", () => new Form { Props = new() { Method = S("post") } }, """<form method="post"></form>"""),
        Case("Form.Name", () => new Form { Props = new() { Name = S("field") } }, """<form name="field"></form>"""),
        Case("Form.NoValidate", () => new Form { Props = new() { NoValidate = S(true) } }, """<form novalidate></form>"""),
        Case("Form.Target", () => new Form { Props = new() { Target = S("_blank") } }, """<form target="_blank"></form>"""),
        Case("Form.Rel", () => new Form { Props = new() { Rel = S("noopener") } }, """<form rel="noopener"></form>"""),

        Case("IFrame.Src", () => new IFrame { Props = new() { Src = S("/media/clip") } }, """<iframe src="/media/clip"></iframe>"""),
        Case("IFrame.Name", () => new IFrame { Props = new() { Name = S("field") } }, """<iframe name="field"></iframe>"""),
        Case("IFrame.Allow", () => new IFrame { Props = new() { Allow = S("fullscreen") } }, """<iframe allow="fullscreen"></iframe>"""),
        Case("IFrame.AllowFullscreen", () => new IFrame { Props = new() { AllowFullscreen = S(true) } }, """<iframe allowfullscreen></iframe>"""),
        Case("IFrame.Width", () => new IFrame { Props = new() { Width = S("300") } }, """<iframe width="300"></iframe>"""),
        Case("IFrame.Height", () => new IFrame { Props = new() { Height = S("150") } }, """<iframe height="150"></iframe>"""),
        Case("IFrame.ReferrerPolicy", () => new IFrame { Props = new() { ReferrerPolicy = S("no-referrer") } }, """<iframe referrerpolicy="no-referrer"></iframe>"""),
        Case("IFrame.Loading", () => new IFrame { Props = new() { Loading = S("lazy") } }, """<iframe loading="lazy"></iframe>"""),
        Case("IFrame.Sandbox", () => new IFrame { Props = new() { Sandbox = S("allow-scripts") } }, """<iframe sandbox="allow-scripts"></iframe>"""),
        Case("IFrame.SrcDoc", () => new IFrame { Props = new() { SrcDoc = S("Hello") } }, """<iframe srcdoc="Hello"></iframe>"""),

        Case("Img.Alt", () => new Img { Props = new() { Alt = S("Logo") } }, """<img alt="Logo">"""),
        Case("Img.Src", () => new Img { Props = new() { Src = S("/media/clip") } }, """<img src="/media/clip">"""),
        Case("Img.Srcset", () => new Img { Props = new() { Srcset = S("/a.png 2x") } }, """<img srcset="/a.png 2x">"""),
        Case("Img.Sizes", () => new Img { Props = new() { Sizes = S("100vw") } }, """<img sizes="100vw">"""),
        Case("Img.CrossOrigin", () => new Img { Props = new() { CrossOrigin = S<string?>("anonymous") } }, """<img crossorigin="anonymous">"""),
        Case("Img.UseMap", () => new Img { Props = new() { UseMap = S("#map") } }, """<img usemap="#map">"""),
        Case("Img.IsMap", () => new Img { Props = new() { IsMap = S(true) } }, """<img ismap>"""),
        Case("Img.Width", () => new Img { Props = new() { Width = S(3u) } }, """<img width="3">"""),
        Case("Img.Height", () => new Img { Props = new() { Height = S(3u) } }, """<img height="3">"""),
        Case("Img.Decoding", () => new Img { Props = new() { Decoding = S("async") } }, """<img decoding="async">"""),
        Case("Img.FetchPriority", () => new Img { Props = new() { FetchPriority = S("high") } }, """<img fetchpriority="high">"""),
        Case("Img.Loading", () => new Img { Props = new() { Loading = S("lazy") } }, """<img loading="lazy">"""),
        Case("Img.ReferrerPolicy", () => new Img { Props = new() { ReferrerPolicy = S("no-referrer") } }, """<img referrerpolicy="no-referrer">"""),

        Case("Input.Accept", () => new Input { Props = new() { Accept = S("image/*") } }, """<input accept="image/*">"""),
        Case("Input.Alt", () => new Input { Props = new() { Alt = S("Logo") } }, """<input alt="Logo">"""),
        Case("Input.Autocomplete", () => new Input { Props = new() { Autocomplete = S("off") } }, """<input autocomplete="off">"""),
        Case("Input.Capture", () => new Input { Props = new() { Capture = S("user") } }, """<input capture="user">"""),
        Case("Input.Checked", () => new Input { Props = new() { Checked = S(true) } }, """<input checked>""", browserHtml: """<input>""", property: ("checked", true)),
        Case("Input.DefaultChecked", () => new Input { Props = new() { DefaultChecked = S(true) } }, """<input checked>"""),
        Case("Input.DirName", () => new Input { Props = new() { DirName = S("field.dir") } }, """<input dirname="field.dir">"""),
        Case("Input.Disabled", () => new Input { Props = new() { Disabled = S(true) } }, """<input disabled>"""),
        Case("Input.FormAction", () => new Input { Props = new() { FormAction = S("/submit") } }, """<input formaction="/submit">"""),
        Case("Input.FormEnctype", () => new Input { Props = new() { FormEnctype = S("multipart/form-data") } }, """<input formenctype="multipart/form-data">"""),
        Case("Input.FormMethod", () => new Input { Props = new() { FormMethod = S("post") } }, """<input formmethod="post">"""),
        Case("Input.FormNoValidate", () => new Input { Props = new() { FormNoValidate = S(true) } }, """<input formnovalidate>"""),
        Case("Input.FormTarget", () => new Input { Props = new() { FormTarget = S("_self") } }, """<input formtarget="_self">"""),
        Case("Input.Height", () => new Input { Props = new() { Height = S(3u) } }, """<input height="3">"""),
        Case("Input.Max", () => new Input { Props = new() { Max = S("10") } }, """<input max="10">"""),
        Case("Input.MaxLength", () => new Input { Props = new() { MaxLength = S(5) } }, """<input maxlength="5">"""),
        Case("Input.Min", () => new Input { Props = new() { Min = S("1") } }, """<input min="1">"""),
        Case("Input.MinLength", () => new Input { Props = new() { MinLength = S(5) } }, """<input minlength="5">"""),
        Case("Input.Multiple", () => new Input { Props = new() { Multiple = S(true) } }, """<input multiple>"""),
        Case("Input.Name", () => new Input { Props = new() { Name = S("field") } }, """<input name="field">"""),
        Case("Input.Pattern", () => new Input { Props = new() { Pattern = S("[a-z]+") } }, """<input pattern="[a-z]+">"""),
        Case("Input.Placeholder", () => new Input { Props = new() { Placeholder = S("Name") } }, """<input placeholder="Name">"""),
        Case("Input.ReadOnly", () => new Input { Props = new() { ReadOnly = S(true) } }, """<input readonly>"""),
        Case("Input.Required", () => new Input { Props = new() { Required = S(true) } }, """<input required>"""),
        Case("Input.Size", () => new Input { Props = new() { Size = S(3u) } }, """<input size="3">"""),
        Case("Input.Src", () => new Input { Props = new() { Src = S("/media/clip") } }, """<input src="/media/clip">"""),
        Case("Input.Step", () => new Input { Props = new() { Step = S("2") } }, """<input step="2">"""),
        Case("Input.Type", () => new Input { Props = new() { Type = S("text") } }, """<input type="text">"""),
        Case("Input.Value", () => new Input { Props = new() { Value = S("v") } }, """<input value="v">""", browserHtml: """<input>""", property: ("value", "v")),
        Case("Input.DefaultValue", () => new Input { Props = new() { DefaultValue = S("v") } }, """<input value="v">"""),
        Case("Input.Width", () => new Input { Props = new() { Width = S(3u) } }, """<input width="3">"""),

        Case("Ins.Cite", () => new Ins { Props = new() { Cite = S("/source") } }, """<ins cite="/source"></ins>"""),
        Case("Ins.DateTime", () => new Ins { Props = new() { DateTime = S("2026-10-10") } }, """<ins datetime="2026-10-10"></ins>"""),

        Case("Label.HtmlFor", () => new Label { Props = new() { HtmlFor = S("field") } }, """<label for="field"></label>"""),

        Case("Li.Value", () => new Li { Props = new() { Value = S(5) } }, """<li value="5"></li>"""),

        Case("Link.Href", () => new Link { Props = new() { Href = S("/docs") } }, """<link href="/docs">"""),
        Case("Link.CrossOrigin", () => new Link { Props = new() { CrossOrigin = S<string?>("anonymous") } }, """<link crossorigin="anonymous">"""),
        Case("Link.Rel", () => new Link { Props = new() { Rel = S("noopener") } }, """<link rel="noopener">"""),
        Case("Link.As", () => new Link { Props = new() { As = S("style") } }, """<link as="style">"""),
        Case("Link.Media", () => new Link { Props = new() { Media = S("print") } }, """<link media="print">"""),
        Case("Link.Integrity", () => new Link { Props = new() { Integrity = S("sha384-abc") } }, """<link integrity="sha384-abc">"""),
        Case("Link.Hreflang", () => new Link { Props = new() { Hreflang = S("en") } }, """<link hreflang="en">"""),
        Case("Link.Type", () => new Link { Props = new() { Type = S("text/css") } }, """<link type="text/css">"""),
        Case("Link.ReferrerPolicy", () => new Link { Props = new() { ReferrerPolicy = S("no-referrer") } }, """<link referrerpolicy="no-referrer">"""),
        Case("Link.Disabled", () => new Link { Props = new() { Disabled = S(true) } }, """<link disabled>"""),
        Case("Link.FetchPriority", () => new Link { Props = new() { FetchPriority = S("high") } }, """<link fetchpriority="high">"""),
        Case("Link.Blocking", () => new Link { Props = new() { Blocking = S("render") } }, """<link blocking="render">"""),
        Case("Link.ImageSizes", () => new Link { Props = new() { ImageSizes = S("100vw") } }, """<link imagesizes="100vw">"""),
        Case("Link.ImageSrcset", () => new Link { Props = new() { ImageSrcset = S("/a.png 2x") } }, """<link imagesrcset="/a.png 2x">"""),

        Case("Map.Name", () => new Map { Props = new() { Name = S("field") } }, """<map name="field"></map>"""),

        Case("Meta.Name", () => new Meta { Props = new() { Name = S("field") } }, """<meta name="field">"""),
        Case("Meta.Property", () => new Meta { Props = new() { Property = S("og:title") } }, """<meta property="og:title">"""),
        Case("Meta.HttpEquiv", () => new Meta { Props = new() { HttpEquiv = S("refresh") } }, """<meta http-equiv="refresh">"""),
        Case("Meta.Content", () => new Meta { Props = new() { Content = S("5") } }, """<meta content="5">"""),
        Case("Meta.Media", () => new Meta { Props = new() { Media = S("print") } }, """<meta media="print">"""),

        Case("Meter.Value", () => new Meter { Props = new() { Value = S(0.5) } }, """<meter value="0.5"></meter>"""),
        Case("Meter.Min", () => new Meter { Props = new() { Min = S(0.5) } }, """<meter min="0.5"></meter>"""),
        Case("Meter.Max", () => new Meter { Props = new() { Max = S(0.5) } }, """<meter max="0.5"></meter>"""),
        Case("Meter.Low", () => new Meter { Props = new() { Low = S(0.5) } }, """<meter low="0.5"></meter>"""),
        Case("Meter.High", () => new Meter { Props = new() { High = S(0.5) } }, """<meter high="0.5"></meter>"""),
        Case("Meter.Optimum", () => new Meter { Props = new() { Optimum = S(0.5) } }, """<meter optimum="0.5"></meter>"""),

        Case("Object.Type", () => new Components.Object { Props = new() { Type = S("application/pdf") } }, """<object type="application/pdf"></object>"""),
        Case("Object.Name", () => new Components.Object { Props = new() { Name = S("field") } }, """<object name="field"></object>"""),
        Case("Object.Width", () => new Components.Object { Props = new() { Width = S("300") } }, """<object width="300"></object>"""),
        Case("Object.Height", () => new Components.Object { Props = new() { Height = S("150") } }, """<object height="150"></object>"""),

        Case("Ol.Reversed", () => new Ol { Props = new() { Reversed = S(true) } }, """<ol reversed></ol>"""),
        Case("Ol.Start", () => new Ol { Props = new() { Start = S(5) } }, """<ol start="5"></ol>"""),
        Case("Ol.Type", () => new Ol { Props = new() { Type = S("a") } }, """<ol type="a"></ol>"""),

        Case("OptGroup.Disabled", () => new OptGroup { Props = new() { Disabled = S(true) } }, """<optgroup disabled></optgroup>"""),
        Case("OptGroup.Label", () => new OptGroup { Props = new() { Label = S("English") } }, """<optgroup label="English"></optgroup>"""),

        Case("Option.Disabled", () => new Option { Props = new() { Disabled = S(true) } }, """<option disabled></option>"""),
        Case("Option.Label", () => new Option { Props = new() { Label = S("English") } }, """<option label="English"></option>"""),
        Case("Option.DefaultSelected", () => new Option { Props = new() { DefaultSelected = S(true) } }, """<option selected></option>"""),
        Case("Option.Selected", () => new Option { Props = new() { Selected = S(true) } }, """<option selected></option>""", browserHtml: """<option></option>""", property: ("selected", true)),
        Case("Option.Value", () => new Option { Props = new() { Value = S("v") } }, """<option value="v"></option>"""),

        Case("Output.HtmlFor", () => new Output { Props = new() { HtmlFor = S("field") } }, """<output for="field"></output>"""),
        Case("Output.Name", () => new Output { Props = new() { Name = S("field") } }, """<output name="field"></output>"""),
        Case("Output.DefaultValue", () => new Output { Props = new() { DefaultValue = S("v") } }, """<output>v</output>"""),
        Case("Output.Value", () => new Output { Props = new() { Value = S("v") } }, """<output>v</output>"""),

        Case("Progress.Value", () => new Progress { Props = new() { Value = S(0.5) } }, """<progress value="0.5"></progress>"""),
        Case("Progress.Max", () => new Progress { Props = new() { Max = S(0.5) } }, """<progress max="0.5"></progress>"""),

        Case("Q.Cite", () => new Q { Props = new() { Cite = S("/source") } }, """<q cite="/source"></q>"""),

        Case("Script.Src", () => new Script { Props = new() { Src = S("/media/clip") } }, """<script src="/media/clip"></script>"""),
        Case("Script.Type", () => new Script { Props = new() { Type = S("module") } }, """<script type="module"></script>"""),
        Case("Script.NoModule", () => new Script { Props = new() { NoModule = S(true) } }, """<script nomodule></script>"""),
        Case("Script.Async", () => new Script { Props = new() { Async = S(true) } }, """<script async></script>"""),
        Case("Script.Defer", () => new Script { Props = new() { Defer = S(true) } }, """<script defer></script>"""),
        Case("Script.CrossOrigin", () => new Script { Props = new() { CrossOrigin = S<string?>("anonymous") } }, """<script crossorigin="anonymous"></script>"""),
        Case("Script.Integrity", () => new Script { Props = new() { Integrity = S("sha384-abc") } }, """<script integrity="sha384-abc"></script>"""),
        Case("Script.ReferrerPolicy", () => new Script { Props = new() { ReferrerPolicy = S("no-referrer") } }, """<script referrerpolicy="no-referrer"></script>"""),
        Case("Script.FetchPriority", () => new Script { Props = new() { FetchPriority = S("high") } }, """<script fetchpriority="high"></script>"""),
        Case("Script.Blocking", () => new Script { Props = new() { Blocking = S("render") } }, """<script blocking="render"></script>"""),

        Case("Select.Autocomplete", () => new Select { Props = new() { Autocomplete = S("off") } }, """<select autocomplete="off"></select>"""),
        Case("Select.Disabled", () => new Select { Props = new() { Disabled = S(true) } }, """<select disabled></select>"""),
        Case("Select.Multiple", () => new Select { Props = new() { Multiple = S(true) } }, """<select multiple></select>"""),
        Case("Select.Name", () => new Select { Props = new() { Name = S("field") } }, """<select name="field"></select>"""),
        Case("Select.Required", () => new Select { Props = new() { Required = S(true) } }, """<select required></select>"""),
        Case("Select.Size", () => new Select { Props = new() { Size = S(3u) } }, """<select size="3"></select>"""),
        Case("Select.Value", () => new Select { Props = new() { Value = S("b") }, Children = [Option("a"), Option("b")] },
            """<select><option value="a">a</option><option selected value="b">b</option></select>""",
            browserHtml: """<select><option value="a">a</option><option value="b">b</option></select>""",
            property: ("value", "b")),
        Case("Select.Values", () => new Select { Props = new() { Multiple = S(true), Values = S<IReadOnlyList<string>>(["a", "c"]) }, Children = [Option("a"), Option("b"), Option("c")] },
            """<select multiple><option selected value="a">a</option><option value="b">b</option><option selected value="c">c</option></select>""",
            browserHtml: """<select multiple><option value="a">a</option><option value="b">b</option><option value="c">c</option></select>""",
            property: ("value", "a")),

        Case("Slot.Name", () => new Slot { Props = new() { Name = S("field") } }, """<slot name="field"></slot>"""),

        Case("Source.Src", () => new Source { Props = new() { Src = S("/media/clip") } }, """<source src="/media/clip">"""),
        Case("Source.Type", () => new Source { Props = new() { Type = S("video/mp4") } }, """<source type="video/mp4">"""),
        Case("Source.Srcset", () => new Source { Props = new() { Srcset = S("/a.png 2x") } }, """<source srcset="/a.png 2x">"""),
        Case("Source.Sizes", () => new Source { Props = new() { Sizes = S("100vw") } }, """<source sizes="100vw">"""),
        Case("Source.Media", () => new Source { Props = new() { Media = S("print") } }, """<source media="print">"""),
        Case("Source.Width", () => new Source { Props = new() { Width = S(3u) } }, """<source width="3">"""),
        Case("Source.Height", () => new Source { Props = new() { Height = S(3u) } }, """<source height="3">"""),

        Case("Style.Disabled", () => new Style { Props = new() { Disabled = S(true) } }, """<style disabled></style>""", browserHtml: """<style></style>"""),
        Case("Style.Media", () => new Style { Props = new() { Media = S("print") } }, """<style media="print"></style>"""),
        Case("Style.Blocking", () => new Style { Props = new() { Blocking = S("render") } }, """<style blocking="render"></style>"""),

        Case("Td.ColSpan", () => new Td { Props = new() { ColSpan = S(3u) } }, """<td colspan="3"></td>"""),
        Case("Td.RowSpan", () => new Td { Props = new() { RowSpan = S(3u) } }, """<td rowspan="3"></td>"""),
        Case("Td.Headers", () => new Td { Props = new() { Headers = S("h1") } }, """<td headers="h1"></td>"""),

        Case("TextArea.Autocomplete", () => new TextArea { Props = new() { Autocomplete = S("off") } }, """<textarea autocomplete="off"></textarea>"""),
        Case("TextArea.Cols", () => new TextArea { Props = new() { Cols = S(3u) } }, """<textarea cols="3"></textarea>"""),
        Case("TextArea.DirName", () => new TextArea { Props = new() { DirName = S("field.dir") } }, """<textarea dirname="field.dir"></textarea>"""),
        Case("TextArea.Disabled", () => new TextArea { Props = new() { Disabled = S(true) } }, """<textarea disabled></textarea>"""),
        Case("TextArea.MaxLength", () => new TextArea { Props = new() { MaxLength = S(5) } }, """<textarea maxlength="5"></textarea>"""),
        Case("TextArea.MinLength", () => new TextArea { Props = new() { MinLength = S(5) } }, """<textarea minlength="5"></textarea>"""),
        Case("TextArea.Name", () => new TextArea { Props = new() { Name = S("field") } }, """<textarea name="field"></textarea>"""),
        Case("TextArea.Placeholder", () => new TextArea { Props = new() { Placeholder = S("Name") } }, """<textarea placeholder="Name"></textarea>"""),
        Case("TextArea.ReadOnly", () => new TextArea { Props = new() { ReadOnly = S(true) } }, """<textarea readonly></textarea>"""),
        Case("TextArea.Required", () => new TextArea { Props = new() { Required = S(true) } }, """<textarea required></textarea>"""),
        Case("TextArea.Rows", () => new TextArea { Props = new() { Rows = S(3u) } }, """<textarea rows="3"></textarea>"""),
        Case("TextArea.Wrap", () => new TextArea { Props = new() { Wrap = S("hard") } }, """<textarea wrap="hard"></textarea>"""),
        Case("TextArea.Value", () => new TextArea { Props = new() { Value = S("v") } }, """<textarea>v</textarea>""", browserHtml: """<textarea></textarea>""", property: ("value", "v")),
        Case("TextArea.DefaultValue", () => new TextArea { Props = new() { DefaultValue = S("v") } }, """<textarea>v</textarea>"""),

        Case("Th.ColSpan", () => new Th { Props = new() { ColSpan = S(3u) } }, """<th colspan="3"></th>"""),
        Case("Th.RowSpan", () => new Th { Props = new() { RowSpan = S(3u) } }, """<th rowspan="3"></th>"""),
        Case("Th.Headers", () => new Th { Props = new() { Headers = S("h1") } }, """<th headers="h1"></th>"""),
        Case("Th.Scope", () => new Th { Props = new() { Scope = S("col") } }, """<th scope="col"></th>"""),
        Case("Th.Abbr", () => new Th { Props = new() { Abbr = S("Name") } }, """<th abbr="Name"></th>"""),

        Case("Time.DateTime", () => new Time { Props = new() { DateTime = S("2026-10-10") } }, """<time datetime="2026-10-10"></time>"""),

        Case("Track.Kind", () => new Track { Props = new() { Kind = S("subtitles") } }, """<track kind="subtitles">"""),
        Case("Track.Src", () => new Track { Props = new() { Src = S("/media/clip") } }, """<track src="/media/clip">"""),
        Case("Track.Srclang", () => new Track { Props = new() { Srclang = S("en") } }, """<track srclang="en">"""),
        Case("Track.Label", () => new Track { Props = new() { Label = S("English") } }, """<track label="English">"""),
        Case("Track.Default", () => new Track { Props = new() { Default = S(true) } }, """<track default>"""),

        Case("Video.Src", () => new Video { Props = new() { Src = S("/media/clip") } }, """<video src="/media/clip"></video>"""),
        Case("Video.Autoplay", () => new Video { Props = new() { Autoplay = S(true) } }, """<video autoplay></video>"""),
        Case("Video.Controls", () => new Video { Props = new() { Controls = S(true) } }, """<video controls></video>"""),
        Case("Video.Loop", () => new Video { Props = new() { Loop = S(true) } }, """<video loop></video>"""),
        Case("Video.Muted", () => new Video { Props = new() { Muted = S(true) } }, """<video muted></video>""", browserHtml: """<video></video>""", property: ("muted", true)),
        Case("Video.Preload", () => new Video { Props = new() { Preload = S("none") } }, """<video preload="none"></video>"""),
        Case("Video.CrossOrigin", () => new Video { Props = new() { CrossOrigin = S<string?>("anonymous") } }, """<video crossorigin="anonymous"></video>"""),
        Case("Video.Poster", () => new Video { Props = new() { Poster = S("/poster.png") } }, """<video poster="/poster.png"></video>"""),
        Case("Video.PlaysInline", () => new Video { Props = new() { PlaysInline = S(true) } }, """<video playsinline></video>"""),
        Case("Video.Width", () => new Video { Props = new() { Width = S(3u) } }, """<video width="3"></video>"""),
        Case("Video.Height", () => new Video { Props = new() { Height = S(3u) } }, """<video height="3"></video>"""),
        Case("Video.DisablePictureInPicture", () => new Video { Props = new() { DisablePictureInPicture = S(true) } }, """<video disablepictureinpicture></video>"""),
        Case("Video.DisableRemotePlayback", () => new Video { Props = new() { DisableRemotePlayback = S(true) } }, """<video disableremoteplayback></video>"""),
    ];

    private static Signal<T> S<T>(T value) => new(value);

    private static Option Option(string value) => new()
    {
        Props = new OptionProps { Value = S(value) },
        Children = [new DomText { Text = S(value) }],
    };

    private static DomCase Case(
        string name,
        Func<IComponent> create,
        string html,
        string? browserHtml = null,
        (string, object)? property = null,
        string? serverIssue = null,
        string? browserIssue = null) =>
        new(name, create, html)
        {
            BrowserHtml = browserHtml,
            Property = property,
            ServerIssue = serverIssue,
            BrowserIssue = browserIssue,
        };
}
