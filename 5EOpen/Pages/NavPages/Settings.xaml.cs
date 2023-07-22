using _5EOpen.ViewModels.NavPageViewModels;

namespace _5EOpen.Pages.NavPages;

public partial class Settings : ContentPage
{
	private SettingsViewModel _viewModel;
	public Settings()
	{
		_viewModel = new SettingsViewModel();
		BindingContext = _viewModel;
        InitializeComponent();
    }
}