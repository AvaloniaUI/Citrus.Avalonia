using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Citrus.Avalonia.Sandbox
{
    public class App : Application
    {
        public override void Initialize() => AvaloniaXamlLoader.Load(this);

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                var window = new MainWindow();
                window.DataContext = new MainWindowViewModel(new StyleManager(window));
                desktopLifetime.MainWindow = window;
            }
            
            base.OnFrameworkInitializationCompleted();
        }
    }
}
