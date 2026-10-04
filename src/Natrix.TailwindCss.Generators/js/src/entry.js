import "./shims.js";
import { compile } from "tailwindcss";

// The single entry point the C# host calls.
//
// It is `async`, and the host awaits the returned promise: Jint runs its pending
// jobs and waits until it settles, so this may await host work that finishes
// later. Jint has no timers, though, so nothing here may use `setTimeout`.
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
