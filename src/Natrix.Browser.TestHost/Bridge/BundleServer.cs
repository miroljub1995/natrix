using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Runtime.Versioning;

namespace Natrix.Browser.TestHost.Bridge;

/// <summary>
/// Serves the wasm AppBundle plus the embedded index page on a loopback port.
/// </summary>
[UnsupportedOSPlatform("browser")]
internal sealed class BundleServer : IDisposable
{
    private static readonly Dictionary<string, string> ContentTypes = new(StringComparer.OrdinalIgnoreCase)
    {
        [".html"] = "text/html; charset=utf-8",
        [".js"] = "text/javascript; charset=utf-8",
        [".mjs"] = "text/javascript; charset=utf-8",
        [".map"] = "application/json; charset=utf-8",
        [".json"] = "application/json; charset=utf-8",
        [".wasm"] = "application/wasm",
        [".css"] = "text/css; charset=utf-8",
        [".svg"] = "image/svg+xml",
        [".png"] = "image/png",
        [".txt"] = "text/plain; charset=utf-8",
    };

    private readonly HttpListener _listener;
    private readonly string _root;
    private readonly byte[] _index;

    private BundleServer(HttpListener listener, string root, string baseUrl)
    {
        _listener = listener;
        _root = root;
        BaseUrl = baseUrl;

        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("index.html")
                           ?? throw new InvalidOperationException("The embedded index.html is missing.");
        using var reader = new StreamReader(stream, Encoding.UTF8);
        _index = Encoding.UTF8.GetBytes(reader.ReadToEnd());
    }

    public string BaseUrl { get; }

    public static BundleServer Start(string bundleDirectory)
    {
        var root = Path.GetFullPath(bundleDirectory);
        var port = FreePort();
        var baseUrl = $"http://127.0.0.1:{port}/";

        var listener = new HttpListener();
        listener.Prefixes.Add(baseUrl);
        listener.Start();

        var server = new BundleServer(listener, root, baseUrl);
        _ = Task.Run(server.AcceptLoopAsync);
        return server;
    }

    private async Task AcceptLoopAsync()
    {
        while (_listener.IsListening)
        {
            HttpListenerContext context;
            try
            {
                context = await _listener.GetContextAsync();
            }
            catch (Exception) when (!_listener.IsListening)
            {
                return;
            }

            _ = Task.Run(() => HandleAsync(context));
        }
    }

    private async Task HandleAsync(HttpListenerContext context)
    {
        var response = context.Response;
        try
        {
            response.Headers["Cache-Control"] = "no-store";

            var path = Uri.UnescapeDataString(context.Request.Url?.AbsolutePath ?? "/");
            if (path is "/" or "/index.html")
            {
                await WriteAsync(response, 200, ContentTypes[".html"], _index, context.Request.HttpMethod);
                return;
            }

            var file = Path.GetFullPath(Path.Join(_root, path.TrimStart('/')));
            if (!file.StartsWith(_root, StringComparison.Ordinal) || !File.Exists(file))
            {
                await WriteAsync(response, 404, "text/plain", "Not found"u8.ToArray(), context.Request.HttpMethod);
                return;
            }

            var contentType = ContentTypes.GetValueOrDefault(Path.GetExtension(file), "application/octet-stream");
            await WriteAsync(response, 200, contentType, await File.ReadAllBytesAsync(file), context.Request.HttpMethod);
        }
        catch (Exception)
        {
            try
            {
                response.Abort();
            }
            catch (Exception)
            {
                // The client is gone; nothing to clean up.
            }
        }
    }

    private static async Task WriteAsync(HttpListenerResponse response, int status, string contentType, byte[] body, string method)
    {
        response.StatusCode = status;
        response.ContentType = contentType;
        response.ContentLength64 = body.Length;
        if (method != "HEAD")
        {
            await response.OutputStream.WriteAsync(body);
        }

        response.Close();
    }

    private static int FreePort()
    {
        using var probe = new TcpListener(IPAddress.Loopback, 0);
        probe.Start();
        return ((IPEndPoint)probe.LocalEndpoint).Port;
    }

    public void Dispose()
    {
        try
        {
            _listener.Stop();
            _listener.Close();
        }
        catch (Exception)
        {
            // Shutting down; a failure here is irrelevant.
        }
    }
}
