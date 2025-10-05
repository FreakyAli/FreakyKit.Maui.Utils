namespace FreakyKit.Maui.Utils;

internal partial class Permissions
{
    public partial void NavigateToAppSettings(string? packageName)
    {
        AppInfo.Current.ShowSettingsUI();
    }
}