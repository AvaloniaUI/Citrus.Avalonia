![License](https://img.shields.io/github/license/worldbeater/avalonia.citrus.svg) ![Size](https://img.shields.io/github/repo-size/worldbeater/avalonia.citrus.svg)

### Citrus

Avalonia experimental theme.

<img src="./assets/demo.gif" width="800">

### Getting Started

The simplest way to get started is to add this repo as a [submodule](https://git-scm.com/book/en/v2/Git-Tools-Submodules) to your existing git repository:

```sh
mkdir ./external
git submodule add git@github.com:worldbeater/Avalonia.Citrus.git ./external/citrus
# Reference the ../external/citrus/src/Avalonia.Citrus/Avalonia.Citrus.csproj project then.
# The ../external/citrus/src/Avalonia.Citrus.Sandbox/Avalonia.Citrus.Sandbox.csproj is 
# the sandbox where you can browse the markup samples.
```

Then, reference the default theme (or, the night theme) from your `App.xaml` file:

```xml
<Application xmlns="https://github.com/avaloniaui"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             x:Class="YourNamespace.App">
  <Application.Styles>
    <!-- The line below is the only thing you need to get started.
         Tested with Avalonia 0.9.0 only, although not with all controls. -->
    <StyleInclude Source="avares://Avalonia.Citrus/Citrus.xaml"/>

    <!-- To use the Sea theme:
         1. Comment out the <StyleInclude /> line above^
         2. Uncomment the line below <StyleInclude /> -->
    <!-- <StyleInclude Source="avares://Avalonia.Citrus/Sea.xaml"/> -->

    <!-- To use the Rust theme:
         1. Comment out the <StyleInclude /> line above^
         2. Uncomment the line below <StyleInclude /> -->
    <!-- <StyleInclude Source="avares://Avalonia.Citrus/Rust.xaml"/> -->
  </Application.Styles>
</Application>
```

Done! Now the templates of all default controls are updated. See the [sandbox project](https://github.com/worldbeater/Avalonia.Citrus/blob/master/src/Avalonia.Citrus.Sandbox/MainWindow.xaml) for more examples.
