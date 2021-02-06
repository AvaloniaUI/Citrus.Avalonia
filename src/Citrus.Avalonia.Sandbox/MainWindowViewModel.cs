using System;
using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;

namespace Citrus.Avalonia.Sandbox
{
    public sealed class MainWindowViewModel : ReactiveValidationObject
    {
        public MainWindowViewModel(StyleManager styles)
        {
            // This is ReactiveUI.Validation magic, that supports
            // INotifyDataErrorInfo <TextBox /> error messages.
            this.ValidationRule(x => x.Message,
                message => !string.IsNullOrWhiteSpace(message),
                "This text is not happy to be empty!");
            
            // Each time a user clicks 'Switch theme', we load next theme. See 'StyleManager.cs'.
            ChangeTheme = ReactiveCommand.Create(() => styles.UseTheme(styles.CurrentTheme switch
            {
                StyleManager.Theme.Citrus => StyleManager.Theme.Sea,
                StyleManager.Theme.Sea => StyleManager.Theme.Rust,
                StyleManager.Theme.Rust => StyleManager.Theme.Candy,
                StyleManager.Theme.Candy => StyleManager.Theme.Magma,
                StyleManager.Theme.Magma => StyleManager.Theme.Citrus,
                _ => throw new ArgumentOutOfRangeException(nameof(styles.CurrentTheme))
            }));
        }
        
        [Reactive]
        public string Message { get; set; }

        public ReactiveCommand<Unit, Unit> ChangeTheme { get; }
    }
}