# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

```bash
# Build
dotnet build

# Run the tester app
dotnet run --project src/TesterApp/TesterApp.csproj

# Pack NuGet package
dotnet pack src/PhosphorIconsAvalonia/PhosphorIconsAvalonia.csproj
```

## Architecture

**PhosphorIconsAvalonia** is an Avalonia UI library providing 1,000+ Phosphor Icons as embedded SVG resources. It targets `net8.0` and `net10.0`.

### Project Structure

- `src/PhosphorIconsAvalonia/` — The library (NuGet package)
- `src/TesterApp/` — Demo/test application

### Key Components

- `Icon` — Enum of all available icon names
- `IconType` — Enum for icon style variants (Bold, Fill, Light, Regular, Thin)
- `IconService` — Service that loads and caches SVG icon data using FusionCache
- `Markup/IconGeometryExtension` — XAML markup extension returning icon as Geometry
- `Markup/IconSourceExtension` — XAML markup extension returning icon as DrawingImage source

### Icons

7,560 embedded SVG files organized in `Icons/` subdirectories by style: `bold/`, `fill/`, `light/`, `regular/`, `thin/`. These are embedded resources loaded at runtime by `IconService`.

C# language version is **14**; nullable reference types are enabled throughout.
