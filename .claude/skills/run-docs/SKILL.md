---
name: run-docs
description: Build, launch and drive the Natrix docs app (docs/Natrix.Docs, SSR host + WebAssembly client) to see a change working in the real app. Use when asked to run, start, screenshot or check the docs site or its examples (Todo, Canvas, Data Fetching).
---

# Run the docs app

`docs/Natrix.Docs` is an ASP.NET Core host that server-side renders every page
and serves `docs/Natrix.Docs.Client` (a WebAssembly app) which then hydrates
it. Most of the framework — Signals, SSR, hydration, SWR, Tailwind — shows up
here, so it is the place to see a framework change working end to end.

Routes: `/`, `/docs/quick-start`, `/docs/examples/todo`,
`/docs/examples/canvas`, `/docs/examples/data-fetching`. API: `/api/users/{id}` (ids: `ada`, `grace`,
`linus`, `alan`, `margaret`; 500 ms delay) and `/api/failing/users/{id}`
(always 503).

## 1. Build

Run all `dotnet` commands with the sandbox disabled — package restore is
blocked by the sandbox proxy. Only the .NET 10 runtime is installed locally,
so pin `-f net10.0`. Needs Node.js/npm on `PATH` (Tailwind generator) and the
`wasm-tools` workload.

```bash
dotnet build docs/Natrix.Docs -f net10.0
```

A cold build takes about a minute. Debug builds skip WASM AOT, so this is
enough; `RunAOTCompilation` only kicks in on publish.

## 2. Launch

Use the `Natrix.Docs` launch profile
(`docs/Natrix.Docs/Properties/launchSettings.json`): it serves
`https://localhost:5100` and sets `ASPNETCORE_ENVIRONMENT=Development`. The
ASP.NET Core dev certificate is trusted on this machine, so `curl` and the
browser pane accept it without `-k`.

Development has to come from the environment (the profile, or the variable),
not `--environment Development` on the command line: that flag is applied too
late for static web assets, and every `_framework/*` file comes back `200`
with an empty body (browser console: "server responded with a MIME type of
""").

```bash
nohup dotnet run --project docs/Natrix.Docs -f net10.0 --no-build --launch-profile Natrix.Docs > "$SCRATCH/docs-server.log" 2>&1 &
```

(`$SCRATCH` = the session scratchpad.) Or, from the desktop app, start the
`docs` configuration in `.claude/launch.json` with `preview_start` — it runs
the same command (without `--no-build`) and opens the browser pane at
`https://localhost:5100` itself; stop it with `preview_stop`, not `pkill`.

Wait for it:

```bash
for i in $(seq 1 60); do curl -sf -o /dev/null https://localhost:5100/ && break; sleep 1; done
```

## 3. Smoke the server (SSR)

```bash
curl -s -o /dev/null -w '%{http_code}\n' https://localhost:5100/
curl -s https://localhost:5100/docs/examples/data-fetching | grep -c 'Ada Lovelace'
curl -s https://localhost:5100/api/users/ada
```

Expect `200`, a non-zero count (SWR prefetched on the server and rendered
into the HTML), and `{"name":"Ada Lovelace",...}`. The page `<title>` is
`Natrix Docs (SSR)`.

## 4. Drive the client (hydration)

SSR output looks complete before the client is live, so **a page that renders
is not proof the WASM side works** — interact with it.

Open `https://localhost:5100/docs/examples/todo` in the built-in browser. A Debug
build downloads ~200 `_framework/*` files, so input for the first few seconds
lands on inert SSR markup and is silently ignored. Wait until
`typeof globalThis.getDotnetRuntime === 'function'` (via `javascript_tool`),
or just wait ~5 s, then:

1. Click the `Enter a new task...` textbox, type text, press Return.
2. A new row with that text appears under the three seeded tasks. If not,
   check `read_console_messages` and `read_network_requests` for a failed
   `_framework/` load.

For data fetching, open `/docs/examples/data-fetching` and switch users in the
picker; the card shows a loading state for ~500 ms, then the profile.

## 5. Stop

```bash
pkill -f 'Natrix.Docs'
```

Anything left on :5100 afterwards that is a `Claude Helper` process is the
browser pane's connection, not the server.
