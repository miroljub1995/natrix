# Natrix.Browser

Browser renderer and host builder browser extensions for Natrix.

## Dev-time static assets

`MapStaticAssets()` reads its endpoint manifest once, when the server starts. Under
`dotnet watch` the client is rebuilt while that server keeps running, so any asset whose URL
or compressed form changed since startup becomes unreachable and the app fails to boot on the
next page load — a 404 and an integrity error for fingerprinted assemblies, or an empty
response with no content type for a precompressed `dotnet.js`.

This package ships `build/Natrix.Browser.props`, which turns off asset fingerprinting and
build-time compression in **Debug** so every asset keeps a stable URL and a single
representation. A rebuilt client is then picked up on the next reload without restarting the
server. Release and publish are untouched and keep both.

Override either property in your project if you need the production behavior in Debug:

```xml
<PropertyGroup>
  <WasmFingerprintAssets>true</WasmFingerprintAssets>
  <DisableBuildCompression>false</DisableBuildCompression>
</PropertyGroup>
```
