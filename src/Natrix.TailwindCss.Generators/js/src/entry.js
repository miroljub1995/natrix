import "./shims.js";
import { compile } from "tailwindcss";

// The single entry point the C# host calls.
//
// It is `async`, and the host converts the returned promise straight to a Task —
// no polling, no state object. The promise is in fact already settled by the time
// the host sees it: `compile()` only ever awaits `loadStylesheet`, which is a
// synchronous host callback, so the whole chain is microtasks with no macrotask
// and V8 drains them as the call stack unwinds.
//
// Everything crosses the boundary as a plain value: strings, a host array of
// candidates, and a host object per resolved import. No JSON in either direction.
globalThis.natrixTailwindBuild = async function natrixTailwindBuild(
  css,
  base,
  candidates,
  loadStylesheet,
) {
  const compiled = await compile(css, {
    base,
    loadStylesheet: (id, importBase) => {
      const result = loadStylesheet(String(id), String(importBase ?? ""));
      if (result.Error) throw new Error(result.Error);
      return { path: result.Path, base: result.Base, content: result.Content };
    },
    loadModule: (id) => {
      throw new Error(
        `JavaScript plugins are not supported by Natrix.TailwindCss ` +
          `(\`@plugin\`/\`@config\` referencing '${id}'). ` +
          `Express the customisation in CSS instead.`,
      );
    },
  });

  // `candidates` arrives as a host array; Tailwind wants a real JS one.
  return compiled.build(Array.from(candidates));
};
