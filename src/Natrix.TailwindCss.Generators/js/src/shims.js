// Shims for running Tailwind's browser bundle under a bare V8 isolate.
//
// ClearScript gives us a plain V8 context: ECMAScript built-ins and nothing
// else. Tailwind's dist reaches for exactly two non-ECMAScript globals, so this
// is the complete list. If a Tailwind upgrade adds more, the bundle will throw a
// ReferenceError on the first compile and the generator surfaces it as TWCSS001.

if (typeof globalThis.console === "undefined") {
  // Tailwind only logs deprecation warnings; the generator has no channel to
  // surface them on, so they go nowhere.
  const noop = () => {};
  globalThis.console = {
    log: noop,
    warn: noop,
    error: noop,
    info: noop,
    debug: noop,
    trace: noop,
  };
}

if (typeof globalThis.structuredClone !== "function") {
  // Used once, to clone the default legacy config. That object can hold plugin
  // functions, so a JSON round-trip would silently drop them.
  globalThis.structuredClone = function structuredClone(value) {
    const seen = new Map();
    const clone = (v) => {
      if (v === null || typeof v !== "object") return v; // functions pass by reference
      if (seen.has(v)) return seen.get(v);
      if (v instanceof Date) return new Date(v.getTime());
      if (v instanceof RegExp) return new RegExp(v.source, v.flags);
      if (v instanceof Map) {
        const m = new Map();
        seen.set(v, m);
        for (const [k, x] of v) m.set(clone(k), clone(x));
        return m;
      }
      if (v instanceof Set) {
        const s = new Set();
        seen.set(v, s);
        for (const x of v) s.add(clone(x));
        return s;
      }
      const out = Array.isArray(v) ? [] : Object.create(Object.getPrototypeOf(v));
      seen.set(v, out);
      for (const k of Reflect.ownKeys(v)) out[k] = clone(v[k]);
      return out;
    };
    return clone(value);
  };
}
