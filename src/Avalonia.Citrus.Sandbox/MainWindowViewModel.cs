using System;
using System.Reactive;
using System.Windows.Input;
using Avalonia.Markup.Xaml.Styling;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;

namespace Avalonia.Citrus.Sandbox
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
            
            // We add the style to the main window styles section,
            // so it will override the default style defined in App.xaml. 
            _window.Styles.Add(_lightStyle);
            
            // This is ReactiveUI.Validation magic, that supports
            // INotifyDataErrorInfo <TextBox /> error messages.
            this.ValidationRule(x => x.Message,
                message => !string.IsNullOrWhiteSpace(message),
                "This text is not happy to be empty!");
        }
        
        [Reactive]
        public string Message { get; set; }

        public ICommand ChangeTheme => _changeTheme;

        private void PerformThemeChange()
        {
            // Here, we change the first style in the main window styles
            // section, and the main window instantly refreshes. Remember
            // to invoke such methods from the UI thread.
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
                new Uri("resm:Styles?assembly=Avalonia.Citrus.Sandbox")) 
                    {Source = new Uri(url)};
    }
}