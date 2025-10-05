using static Microsoft.Maui.ApplicationModel.Permissions;

namespace FreakyKit.Maui.Utils;

internal partial class Permissions : IPermissionsUtils
{
    public async Task<PermissionStatus> CheckAndRequestPermissionAsync<TPermission>()
        where TPermission : BasePermission, new()
    {
        return await MainThread.InvokeOnMainThreadAsync(async () =>
        {
            TPermission permission = new();
            var status = await permission.CheckStatusAsync();
            if (status != PermissionStatus.Granted)
            {
                status = await permission.RequestAsync();
            }
            return status;
        });
    }

    public partial void NavigateToAppSettings(string? packageName);
}