using _5EOpen.Resources.ResX;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.Logging;

namespace _5EOpen;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseLocalizationResourceManager(settings =>
			{
				settings.RestoreLatestCulture(true);
				settings.AddResource(AppResources.ResourceManager);
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
