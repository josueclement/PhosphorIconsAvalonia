using System.Reflection;
using System.Xml;
using Avalonia.Media;

namespace PhosphorIconsAvalonia;

public class IconsService
{
    private static readonly Assembly Assembly = typeof(IPhosphorIconsAvaloniaMarker).Assembly; 
    
    private static string GetIconName(Icon icon)
        => $"{icon}".Replace("_", "-");

    private static string GetIconStreamName(Icon icon, IconType iconType)
    {
        switch (iconType)
        {
            case IconType.bold:
            case IconType.fill:
            case IconType.light:
            case IconType.thin:
                return $"PhosphorIconsAvalonia.Icons.{iconType}.{GetIconName(icon)}-{iconType}.svg";
            case IconType.regular:
                return $"PhosphorIconsAvalonia.Icons.{iconType}.{GetIconName(icon)}.svg";
            default:
                throw new InvalidOperationException($"Icon type '{iconType}' not supported");
        }
    }

    // ReSharper disable once MemberCanBePrivate.Global
    public Stream? GetIconStream(Icon icon, IconType iconType)
        => Assembly.GetManifestResourceStream(GetIconStreamName(icon, iconType));

    // ReSharper disable once MemberCanBePrivate.Global
    public string GetIconData(Icon icon, IconType iconType)
    {
        // Load the SVG file from embedded resources
        using var stream = GetIconStream(icon, iconType)
                           ?? throw new InvalidOperationException($"Icon '{icon}' not found");
        using var sr = new StreamReader(stream);
        var content = sr.ReadToEnd();

        // Parse the SVG XML content
        var xml = new XmlDocument();
        xml.LoadXml(content);

        // Set up namespace manager for SVG namespace
        var xnm = new XmlNamespaceManager(xml.NameTable);
        xnm.AddNamespace("std", "http://www.w3.org/2000/svg");

        // Extract the path element which contains the vector data
        var node = xml.SelectSingleNode("/std:svg/std:path", xnm);

        // Parse the 'd' attribute which contains the path data
        if (node?.Attributes?["d"]?.Value is { } val)
            return val;

        throw new InvalidOperationException($"Cannot read icon '{GetIconName(icon)}'");
    }

    public Geometry CreateGeometry(Icon icon, IconType iconType)
    {
        // Get the icon data
        var data = GetIconData(icon, iconType);
        
        // Parse the icon data into a Geometry object
        return Geometry.Parse(data);
    }

    public DrawingImage CreateDrawingImage(Icon icon, IconType iconType, IBrush brush)
    {
        // Get the vector geometry for the icon
        var geometry = CreateGeometry(icon, iconType);

        // Create a drawing image with the geometry and specified brush
        var drawingImage = new DrawingImage(new GeometryDrawing
        {
            Geometry = geometry,
            Brush = brush
        });
        
        return drawingImage;
    }
}