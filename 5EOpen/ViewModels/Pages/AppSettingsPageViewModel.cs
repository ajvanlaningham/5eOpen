using _5EOpen.Controls.Cards;
using _5EOpen.Resources.ResX;
using LocalizationResourceManager.Maui;


namespace _5EOpen.ViewModels.Pages
{
    public class AppSettingsPageViewModel : ViewModelBase
    {
        private Converters.TranslateExtension _translator;
        public AppSettingsPageViewModel(ILocalizationResourceManager localizationResourceManager) 
        {
            _translator = new Converters.TranslateExtension(localizationResourceManager);

            DisplayView = new MenuCard(_translator.GetValue(nameof(AppResources.AppSettingsPage_DisplayCard)), DisplayTappedCommand);
            LanguageView = new MenuCard(_translator.GetValue(nameof(AppResources.AppSettingsPage_LanguageCard)), LanguageTappedCommand);
        }

        public ContentView DisplayView { get; set; }
        public ContentView LanguageView { get; set; }

        public Command DisplayTappedCommand => new Command(OnDisplayTapped);
        public Command LanguageTappedCommand => new Command(OnLanguageTapped);

        private void OnDisplayTapped()
        {
            throw new NotImplementedException();
        }
        private void OnLanguageTapped()
        {
            throw new NotImplementedException();
        }
    }
}
