# PhosphorIconsAvalonia

A comprehensive Avalonia UI library providing access to **1,000+ beautiful, open-source icons** from [Phosphor Icons](https://phosphoricons.com/). Easily integrate scalable vector icons into your Avalonia applications with simple XAML markup extensions.

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/phosphor-icons/homepage?tab=readme-ov-file#license)

## ✨ Features

- 🎨 **1,000+ high-quality icons** covering UI, arrows, shapes, brands, technology, and more
- 🎭 **5 visual styles**: Bold, Fill, Light, Regular, and Thin
- 🚀 **Easy XAML integration** with markup extensions
- 📦 **Embedded SVG resources** - no external dependencies
- 🎯 **Full control** over size, color, and styling
- ⚡ **Performance optimized** - icons parsed on-demand with FusionCache for fast repeated access

## 📦 Installation

```
dotnet add package PhosphorIconsAvalonia
```

## 🚀 Quick Start

### 1. Import the Namespace

Add the namespace to your XAML file:

```xaml
xmlns:pia="using:PhosphorIconsAvalonia.Markup"
```

### 2. Use Icons in Your UI

#### With Image Control (IconSource)

The `IconSource` extension creates a complete `DrawingImage` perfect for Image controls:

```xaml
<Image Source="{pia:IconSource Icon=airplane_landing, IconType=fill, Brush=AliceBlue}" />
```

#### With PathIcon Control (IconGeometry)

The `IconGeometry` extension provides raw geometry data for maximum flexibility:

```xaml
<PathIcon Data="{pia:IconGeometry Icon=file, IconType=bold}" Foreground="Red" />
```

## 🎨 Icon Styles

Each icon is available in **5 visual styles**:

| Style | Description | Use Case |
|-------|-------------|----------|
| `thin` | Minimal stroke weight | Elegant, minimalist designs |
| `light` | Thin, delicate strokes | Subtle UI, large displays |
| `regular` | Standard stroke width | General purpose (default) |
| `bold` | Thick, prominent strokes | Emphasis, primary actions |
| `fill` | Solid filled shapes | Active states, selections |

Copyright (c) 2026 Josué Clément

Made with ❤️ for the Avalonia community