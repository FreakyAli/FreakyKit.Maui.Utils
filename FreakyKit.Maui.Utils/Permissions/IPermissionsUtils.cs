using static Microsoft.Maui.ApplicationModel.Permissions;

namespace FreakyKit.Maui.Utils;

public interface IPermissionsUtils
{
    Task<PermissionStatus> CheckAndRequestPermissionAsync<TPermission>() where TPermission : BasePermission, new();
    void NavigateToAppSettings(string? packageName);
}
