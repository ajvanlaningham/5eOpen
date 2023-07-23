using _5EOpen.ViewModels.Pages;
using LocalizationResourceManager.Maui;

namespace _5EOpen.Pages;

public partial class AppSettingsPage : ContentPage
{
	private AppSettingsPageViewModel _viewModel;
	public AppSettingsPage(ILocalizationResourceManager localizationResourceManager)
	{
        _viewModel = new AppSettingsPageViewModel(localizationResourceManager);
        BindingContext = _viewModel;
        InitializeComponent();
    }
	
}