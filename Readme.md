<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
<!-- default file list end -->
# How to customize DateNavigator presentation for specific themes


<p>To accomplish this task, override the DateNavigator ControlTemplates with <strong>x:Key</strong> attribute values defined in the following manner:</p><p><ControlTemplate x:Key="{dxet:DateNavigatorThemeKey ThemeName=<Target_theme_name>, ...</p><p>This example shows how to do this for <strong>LightGray</strong> and <strong>Office2007Blue</strong> themes. You can easily add templates for other themes by using the same approach.</p>

<br/>


