using _5EOpen.Controls.Cards;
using _5EOpen.Pages;
using _5EOpen.Pages.NavPages;
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
        private ILocalizationResourceManager _localizationResourceManager;
        public SettingsViewModel(ILocalizationResourceManager localizationResourceManager)
        {
            _localizationResourceManager = localizationResourceManager;                                                                     
            _translator = new Converters.TranslateExtension(_localizationResourceManager);

            CharactersView = new MenuCard(_translator.GetValue(nameof(AppResources.SettingsPage_CharactersCard)), CharactersTappedCommand);
            SpellbookView = new MenuCard(_translator.GetValue(nameof(AppResources.SettingsPage_SpellbookCard)), SpellbookTappedCommand);
            MonsterManualView = new MenuCard(_translator.GetValue(nameof(AppResources.SettingsPage_MonsterManualCard)), MonsterManualTappedCommand);
            AppSettingsView = new MenuCard(_translator.GetValue(nameof(AppResources.SettingsPage_AppSettingsCard)), AppSettingsTappedCommand);
        }

      
        public ContentView CharactersView { get; set; }
        public ContentView SpellbookView { get; set; }
        public ContentView MonsterManualView { get; set; }
        public ContentView AppSettingsView { get; set; }

        public Command AppSettingsTappedCommand => new Command(OnAppSettingsTapped);
        public Command CharactersTappedCommand => new Command(OnCharactersTapped);
        public Command SpellbookTappedCommand => new Command(OnSpellbookTapped);
        public Command MonsterManualTappedCommand => new Command(OnMonsterManualTapped);

        private async void OnAppSettingsTapped()
        {
            await PushToPage(new AppSettingsPage(_localizationResourceManager));
        }
        private void OnCharactersTapped()
        {
            throw new NotImplementedException();
        }

        private void OnSpellbookTapped()
        {
            throw new NotImplementedException();
        }

        private void OnMonsterManualTapped()
        {
            throw new NotImplementedException();
        }
    }
}
