using System;
namespace Maui.FreakyControls.Extensions;

public static class Extensions
{
    public static void InitFreakyView(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler(typeof(FreakyView), typeof(FreakyViewHandler));
        });
    }
}

