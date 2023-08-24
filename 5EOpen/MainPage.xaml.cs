using _5EOpen.Components;
using _5EOpen.Resources.ResX;
using _5EOpen.ViewModels.Pages;
using LocalizationResourceManager.Maui;
using System.Globalization;

namespace _5EOpen;

public partial class MainPage : ContentPage
{
	private HomePageViewModel _viewModel;

	public MainPage(ILocalizationResourceManager localizationResourceManager)
	{
		InitializeComponent();
		_viewModel = new HomePageViewModel(localizationResourceManager);
		BindingContext = _viewModel;	
	}
}

