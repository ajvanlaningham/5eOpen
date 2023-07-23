using _5EOpen.ViewModels.NavPageViewModels;
using LocalizationResourceManager.Maui;

namespace _5EOpen.Pages.NavPages;

public partial class Settings : ContentPage
{
	private SettingsViewModel _viewModel;
    ILocalizationResourceManager _localizationResourceManager;
    public Settings(ILocalizationResourceManager localizationResourceManager)
	{
        _localizationResourceManager = localizationResourceManager;
		_viewModel = new SettingsViewModel(_localizationResourceManager);
		BindingContext = _viewModel;
        InitializeComponent();
    }
}