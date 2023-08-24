using _5EOpen.Components;
using LocalizationResourceManager.Maui;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.ViewModels.Pages
{
    public class HomePageViewModel : ViewModelBase
    {

        int count = 0;
        LocalizationResourceManager.Maui.LocalizedString _counterClicked;
        ILocalizationResourceManager _localizationResourceManager;
        private Converters.TranslateExtension _translator;
        public HomePageViewModel(ILocalizationResourceManager localizationResourceManager)
        {
            _localizationResourceManager = localizationResourceManager;
            _counterClicked = new(() => _localizationResourceManager["Counter"]);

            RobotLogoView = new RobotLogo();
        }

        public ContentView RobotLogoView { get; set; }

        public Command CounterClicked { get; set; }

        private void OnCounterClicked()
        {
            //if (_localizationResourceManager.CurrentCulture.TwoLetterISOLanguageName == "fr")
            //{
            //    _localizationResourceManager.CurrentCulture = new CultureInfo("en");
            //}
            //else
            //{
            //    _localizationResourceManager.CurrentCulture = new CultureInfo("fr");
            //}
            //count++;

            //CounterBtn.Text = string.Format(_counterClicked.Localized, count);

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
