using Avalonia.Markup.Xaml;

namespace PhosphorIconsAvalonia.Markup;

public class IconGeometryExtension : MarkupExtension
{
    public Icon Icon { get; set; }
    
    public IconType IconType { get; set; }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var service = new IconsService();
        return service.CreateGeometry(Icon, IconType);
    }
}