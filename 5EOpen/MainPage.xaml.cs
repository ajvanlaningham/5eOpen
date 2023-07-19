using _5EOpen.Resources.ResX;
using LocalizationResourceManager.Maui;
using System.Globalization;

namespace _5EOpen;

public partial class MainPage : ContentPage
{
	int count = 0;
	LocalizationResourceManager.Maui.LocalizedString _counterClicked;

	ILocalizationResourceManager _localizationResourceManager;

	public MainPage(ILocalizationResourceManager localizationResourceManager)
	{
		InitializeComponent();
		_localizationResourceManager = localizationResourceManager;
		_counterClicked = new (() =>_localizationResourceManager["Counter"]);
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (_localizationResourceManager.CurrentCulture.TwoLetterISOLanguageName == "fr")
		{
            _localizationResourceManager.CurrentCulture = new CultureInfo("en");
        }
		else
		{ 
			_localizationResourceManager.CurrentCulture = new CultureInfo("fr");
		}
		count++;

		CounterBtn.Text = string.Format(_counterClicked.Localized, count);

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

