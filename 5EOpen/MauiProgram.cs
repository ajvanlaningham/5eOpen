using _5EOpen.Pages;
using _5EOpen.Pages.NavPages;
using _5EOpen.Resources.ResX;
using _5EOpen.ViewModels;
using LocalizationResourceManager.Maui;
using Microsoft.Extensions.Logging;
using System.Reflection.Metadata;

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
		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<Settings>();
		builder.Services.AddTransient<AppSettingsPage>();
		
		
#endif

		return builder.Build();
	}
}
