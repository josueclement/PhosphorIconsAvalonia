# PhosphorIconsAvalonia

PhosphorIconsAvalonia is an avalonia vector icon library using PhosphorIcons icons.

The icons are embedded in the library in svg format and their data are parsed with the `IconsService` class.

The markup extensions `IconSource` and `IconGeometry` make the usage in XAML as easy as possible.

[Repo](https://github.com/phosphor-icons/homepage)

[Website](https://phosphoricons.com/)

[License](https://github.com/phosphor-icons/homepage?tab=readme-ov-file#license)

## Examples

Import namespace in XAML :

```xaml
xmlns:pia="using:PhosphorIconsAvalonia.Markup"
```

Example of `IconSource` markup extension with an image :

```xaml
<Image Source="{pia:IconSource Icon=airplane_landing, IconType=fill, Brush=AliceBlue}" />
```

Example of `IconGeometry` markup extension with a `PathIcon` control :

```xaml
<PathIcon Data="{pia:IconGeometry Icon=file, IconType=bold}" Foreground="Red" />
```

Copyright (c) 2025 Josué Clément