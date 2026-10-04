import "./shims.js";
import { compile } from "tailwindcss";

// The single entry point the C# host calls.
//
// It is `async`, and the host unwraps the returned promise directly. That works
// because `compile()` only ever awaits `loadStylesheet`, a synchronous host
// callback: the whole chain is microtasks with no macrotask, and Jint drains them
// when the host unwraps the promise.
//
// Everything crosses the boundary as a plain value: strings, an array of
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

  return compiled.build(candidates);
};
