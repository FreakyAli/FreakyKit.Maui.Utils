using Uri = Android.Net.Uri;
using Android.Content;
using Android.Provider;

namespace FreakyKit.Maui.Utils;

internal partial class Permissions
{
    public partial void NavigateToAppSettings(string? packageName)
    {
#nullable disable
        Platform.CurrentActivity?.RunOnUiThread(() =>
        {
            Intent intent = new(Settings.ActionApplicationSettings);
            Uri uri = Uri.FromParts(packageName, Platform.CurrentActivity?.PackageName, null);
            intent.SetData(uri);
            Platform.CurrentActivity?.StartActivity(intent);
        });
#nullable enable
    }
}