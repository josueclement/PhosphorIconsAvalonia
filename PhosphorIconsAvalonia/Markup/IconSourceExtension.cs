using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace PhosphorIconsAvalonia.Markup;

public class IconSourceExtension : MarkupExtension
{
    public IBrush Brush { get; set; } = Brushes.Black;

    public Icon Icon { get; set; }
    
    public IconType IconType { get; set; }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        var service = new IconsService();
        return service.CreateDrawingImage(Icon, IconType, Brush);
    }
}