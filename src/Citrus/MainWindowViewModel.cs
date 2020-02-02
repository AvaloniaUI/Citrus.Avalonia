using System;
using System.Reactive;
using System.Windows.Input;
using Avalonia.Markup.Xaml.Styling;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;

namespace Citrus
{
    public sealed class MainWindowViewModel : ReactiveValidationObject<MainWindowViewModel>
    {
        public enum Theme { Light, Dark, Black }

        private readonly StyleInclude _darkStyle = CreateStyle("avares://Avalonia.Citrus/Sea.xaml");
        private readonly StyleInclude _lightStyle = CreateStyle("avares://Avalonia.Citrus/Citrus.xaml");
        private readonly StyleInclude _blackStyle = CreateStyle("avares://Avalonia.Citrus/Rust.xaml");
        private readonly ReactiveCommand<Unit, Unit> _changeTheme;
        private readonly MainWindow _window;
        private Theme _theme = Theme.Light;
        
        public MainWindowViewModel(MainWindow window)
        {
            _window = window;
            _changeTheme = ReactiveCommand.Create(PerformThemeChange);
            _window.Styles.Add(_lightStyle);
            
            this.ValidationRule(x => x.Message,
                message => !string.IsNullOrWhiteSpace(message),
                "This text is not happy to be empty!");
        }
        
        [Reactive]
        public string Message { get; set; }

        public ICommand ChangeTheme => _changeTheme;

        private void PerformThemeChange()
        {
            switch (_theme)
            {
                case Theme.Light:
                    _theme = Theme.Dark;
                    _window.Styles[0] = _darkStyle;
                    break;
                case Theme.Dark:
                    _theme = Theme.Black;
                    _window.Styles[0] = _blackStyle;
                    break;
                case Theme.Black:
                    _theme = Theme.Light;
                    _window.Styles[0] = _lightStyle;
                    break;
            }
        }
        
        private static StyleInclude CreateStyle(string url) => 
            new StyleInclude(
                new Uri("resm:Styles?assembly=Citrus")) 
                    {Source = new Uri(url)};
    }
}