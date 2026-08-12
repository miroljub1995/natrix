// Bundles Tailwind CSS into ../Resources/tailwind.bundle.js and copies Tailwind's
// own stylesheets alongside it, for the generator to embed.
//
// Run from MSBuild by the BundleTailwind target; ../Resources is generated output
// and is gitignored. To refresh after a Tailwind version bump, change the version
// in package.json, run `npm install`, and commit the lockfile.

import * as esbuild from "esbuild";
import { copyFileSync, mkdirSync, readFileSync, statSync, writeFileSync } from "node:fs";
import { dirname, join } from "node:path";
import { fileURLToPath } from "node:url";

const here = dirname(fileURLToPath(import.meta.url));
const resources = join(here, "..", "Resources");
const tailwind = join(here, "node_modules", "tailwindcss");

// Tailwind's own stylesheets, embedded so `@import "tailwindcss"` resolves with
// no input from the consumer.
const STYLESHEETS = ["index.css", "theme.css", "preflight.css", "utilities.css"];

mkdirSync(join(resources, "tailwindcss"), { recursive: true });

const bundlePath = join(resources, "tailwind.bundle.js");

await esbuild.build({
  entryPoints: [join(here, "src", "entry.js")],
  outfile: bundlePath,
  bundle: true,
  // IIFE, not ESM: ClearScript executes this as a classic script, and entry.js
  // publishes its entry point on globalThis itself.
  format: "iife",
  // Same export condition @tailwindcss/browser uses, which is what keeps the
  // graph free of node: builtins.
  platform: "browser",
  target: ["es2022"],
  minify: true,
  legalComments: "none",
  charset: "utf8",
  define: { "process.env.NODE_ENV": '"production"' },
  // An IIFE cannot express top-level await; fail the bundle rather than emit it.
  supported: { "top-level-await": false },
  logLevel: "info",
});

for (const file of STYLESHEETS) {
  copyFileSync(join(tailwind, file), join(resources, "tailwindcss", file));
}

const version = JSON.parse(readFileSync(join(tailwind, "package.json"), "utf8")).version;
writeFileSync(join(resources, "tailwind.bundle.version.txt"), `${version}\n`);

const kb = (statSync(bundlePath).size / 1024).toFixed(0);
console.log(`Bundled tailwindcss ${version} -> Resources/tailwind.bundle.js (${kb} KB)`);
