using _5EOpen.Controls.Cards;
using _5EOpen.Resources.ResX;
using LocalizationResourceManager.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.ViewModels.NavPageViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        private Converters.TranslateExtension _translator;
        public SettingsViewModel(ILocalizationResourceManager localizationResourceManager)
        {
            _translator = new Converters.TranslateExtension(localizationResourceManager);

            DisplayView = new MenuCard(_translator.GetValue(nameof(AppResources.SettingsPage_DisplayCard)), DisplayTappedCommand);
            LanguageView = new MenuCard(_translator.GetValue(nameof(AppResources.SettingsPage_LanguageCard)), DisplayTappedCommand);
        }

        public ContentView DisplayView { get; set; }
        public ContentView LanguageView { get; set; }

        public Command DisplayTappedCommand => new Command(OnDisplayTapped);

        private void OnDisplayTapped()
        {
            throw new NotImplementedException();
        }
    }
}
