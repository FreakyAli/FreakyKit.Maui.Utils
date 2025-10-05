namespace FreakyKit.Maui.Utils;

public partial class Permissions
{
    public partial void NavigateToAppSettings(string? packageName)
    {
        AppInfo.Current.ShowSettingsUI();
    }
}