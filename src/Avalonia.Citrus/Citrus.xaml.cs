using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Avalonia.Citrus
{
    public class Citrus : Styles
    {
        public Citrus() => AvaloniaXamlLoader.Load(this);
    }
}