using System;

namespace FreakyKit.Maui.Utils;

public static class Hosting
{
    public static MauiAppBuilder UseFreakyKitUtils(this MauiAppBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.AddSingleton<IPermissionsUtils, Permissions>();
        return builder;
    }
}
