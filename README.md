![netstandard](https://img.shields.io/badge/.NET%20Standard-2.0-green.svg) ![netstandard](https://img.shields.io/nuget/v/Citrus.Avalonia.svg) ![License](https://img.shields.io/github/license/worldbeater/avalonia.citrus.svg) ![Size](https://img.shields.io/github/repo-size/worldbeater/avalonia.citrus.svg)

### Citrus

Avalonia experimental theme.

<img src="./assets/demo.gif" width="800">

### Getting Started

The simplest way to get started is to install the library as a NuGet package:

```powershell
Install-Package Citrus.Avalonia
# Or 'dotnet add package Citrus.Avalonia'
```

Then, reference the default theme (or, the night theme) from your `App.xaml` file:

```xml
<Application xmlns="https://github.com/avaloniaui"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             x:Class="YourNamespace.App">
  <Application.Styles>
    <!-- The line below is the only thing you need to get started.
         Tested with Avalonia 0.9.0 only, although not with all controls. -->
    <StyleInclude Source="avares://Citrus.Avalonia/Citrus.xaml"/>

    <!-- To use the Sea theme:
         1. Comment out all of the <StyleInclude /> lines.
         2. Uncomment the <StyleInclude /> line below. -->
    <!-- <StyleInclude Source="avares://Citrus.Avalonia/Sea.xaml"/> -->

    <!-- To use the Rust theme:
         1. Comment out all of the <StyleInclude /> lines.
         2. Uncomment the <StyleInclude /> line below. -->
    <!-- <StyleInclude Source="avares://Citrus.Avalonia/Rust.xaml"/> -->

    <!-- To use the Holidays theme:
         1. Comment out all of the <StyleInclude /> lines.
         2. Uncomment the <StyleInclude /> line below. -->
    <!-- <StyleInclude Source="avares://Citrus.Avalonia/Holidays.xaml"/> -->
  </Application.Styles>
</Application>
```

Done! Now the templates of all default controls are updated. See the [sandbox project](https://github.com/worldbeater/Citrus.Avalonia/blob/master/src/Citrus.Avalonia.Sandbox/MainWindow.xaml) for more examples.

### Getting Started without NuGet

Another way to get started is to add this repo as a [submodule](https://git-scm.com/book/en/v2/Git-Tools-Submodules) to your existing git repository:

```sh
mkdir ./external
git submodule add git@github.com:worldbeater/Citrus.Avalonia.git ./external/citrus
# Reference the ../external/citrus/src/Citrus.Avalonia/Citrus.Avalonia.csproj project then.
# The ../external/citrus/src/Citrus.Avalonia.Sandbox/Citrus.Avalonia.Sandbox.csproj is 
# the sandbox where you can browse the markup samples.
```
