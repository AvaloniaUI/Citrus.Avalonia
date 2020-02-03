using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace Avalonia.Citrus.Sandbox
{
    public class App : Application
    {
        public override void Initialize() => AvaloniaXamlLoader.Load(this);

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {
                var window = new MainWindow();
                window.DataContext = new MainWindowViewModel(window);
                desktopLifetime.MainWindow = window;
            }
            
            base.OnFrameworkInitializationCompleted();
        }
    }
}
