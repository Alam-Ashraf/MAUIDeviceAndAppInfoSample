using System.Text;

namespace MAUIDeviceAndAppInfoSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        LblDeviceInfo.Text = GetDeviceInfo();
        LblAppInfo.Text = GetAppInfo();
    }

    private string GetDeviceInfo()
    {
        return new StringBuilder()
            .AppendLine($"Model : {DeviceInfo.Current.Model}")
            .AppendLine($"Manufacturer : {DeviceInfo.Current.Manufacturer}")
            .AppendLine($"Name : {DeviceInfo.Name}")
            .AppendLine($"OS Version : {DeviceInfo.VersionString}")
            .AppendLine($"Refresh Rate : {DeviceInfo.Current}")
            .AppendLine($"Idiom : {DeviceInfo.Current.Idiom}")
            .AppendLine($"Platform : {DeviceInfo.Current.Platform}")
            .AppendLine($"Device Type : {DeviceInfo.Current.DeviceType}").ToString();
    }

    private string GetAppInfo()
    {
        return new StringBuilder()
           .AppendLine($"Name : {AppInfo.Current.Name}")
           .AppendLine($"Package : {AppInfo.Current.PackageName}")
           .AppendLine($"Version : {AppInfo.Current.VersionString}")
           .AppendLine($"Build : {AppInfo.Current.BuildString}")
           .AppendLine($"LayoutDirection : {AppInfo.RequestedLayoutDirection}")
           .AppendLine($"Theme : {AppInfo.RequestedTheme}").ToString();
    }
}

