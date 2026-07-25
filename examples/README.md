# Natrix Examples

This directory contains example projects demonstrating how to use Natrix framework.

## Running Examples

Each example is independent. Just navigate to the directory and run:

```bash
cd Natrix.TodoExample
dotnet run
```

> **Note:** To test with local packages instead of NuGet, build and pack the packages first:
> ```bash
> dotnet pack src/Natrix.JSCore/Natrix.JSCore.csproj -c Release
> dotnet pack src/Natrix.StdWeb/Natrix.StdWeb.csproj -c Release
> ```
> The `nuget.config` in this directory is configured to use local package sources.

## Examples

### 1. Natrix.TodoExample - Todo List
An interactive todo list application showcasing dynamic list rendering and keyboard events.

**Run:**
```bash
cd Natrix.TodoExample
dotnet run
```
Opens on http://localhost:9002

---

### 2. Natrix.CanvasExample - Bouncing Balls
A canvas animation demonstrating Canvas API usage and requestAnimationFrame.

**Run:**
```bash
cd Natrix.CanvasExample
dotnet run
```
Opens on http://localhost:9003
