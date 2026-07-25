using System.Reflection.Metadata;
using System.Runtime.InteropServices.JavaScript;
using Natrix.Core;
using Natrix.Core.Components;
using Natrix.JSCore;
using Natrix.Core.RenderRoot;
using Natrix.Signals;
using Natrix.Ssr.Abstractions.RenderRoot;
using Natrix.StdWeb;

namespace Natrix.Ssr.HotReload;

public sealed class HotReloadInterceptionScript : IComponent
{
    private const string ScriptContent = """
        (function() {
            if (!window.Blazor) window.Blazor = {};
            if (!window.Blazor._internal) window.Blazor._internal = {};
            var real = null;
            var beforeUpdate = null;
            Object.defineProperty(window.Blazor._internal, 'applyHotReloadDeltas', {
                configurable: true,
                enumerable: true,
                get: function() {
                    if (!real) return undefined;
                    return function(deltas, level) {
                        if (beforeUpdate) {
                            try { beforeUpdate(JSON.stringify(deltas)); } catch(e) { console.error('[Natrix] BeforeUpdate error:', e); }
                        }
                        return real(deltas, level);
                    };
                },
                set: function(fn) {
                    real = fn;
                    if (!beforeUpdate) {
                        try {
                            getDotnetRuntime(0)?.getAssemblyExports('Natrix.Browser').then(function(exports) {
                                beforeUpdate = exports.Natrix.Browser.Features.HotReload.HotReloadInterop.BeforeUpdate;
                            });
                        } catch(e) {}
                    }
                }
            });
        })();
        """;

    private IRenderSlot? _slot;

    public void Mount(IRenderSlot slot)
    {
        if (!MetadataUpdater.IsSupported)
        {
            return;
        }

        if (_slot is not null)
        {
            throw new InvalidOperationException("Component is already mounted.");
        }

        if (slot is IDomRenderSlot domRenderSlot)
        {
            if (!OperatingSystem.IsBrowser())
            {
                throw new PlatformNotSupportedException();
            }

            var existingNode = domRenderSlot.TryHydrateSlot();
            if (existingNode is null)
            {
                var scriptNode = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis)
                    .Document
                    .CreateElement("script");
                var scriptEl = JSObjectProxyFactory.GetProxy<HTMLScriptElement>(scriptNode.JSObject);
                scriptEl.TextContent = ScriptContent;
                domRenderSlot.Populate(scriptNode);
            }
        }
        else if (slot is ISsrRenderSlot ssrRenderSlot)
        {
            var scriptNode = new SsrElementNode { TagName = "script", IsVoid = false };
            var childRoot = ssrRenderSlot.CreateChildRoot(scriptNode);
            if (childRoot.CreateFirstSlot() is ISsrRenderSlot textSlot)
            {
                textSlot.Populate(new SsrTextNode { TextContent = new Signal<string>(ScriptContent) });
            }
            ssrRenderSlot.Populate(scriptNode);
        }

        _slot = slot;
    }

    public void Unmount()
    {
        if (_slot is IDomRenderSlot domRenderSlot)
        {
            if (!OperatingSystem.IsBrowser())
            {
                throw new PlatformNotSupportedException();
            }

            domRenderSlot.Empty();
        }
        else if (_slot is ISsrRenderSlot ssrRenderSlot)
        {
            ssrRenderSlot.Empty();
        }

        _slot = null;
    }
}
