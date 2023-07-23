using LocalizationResourceManager.Maui;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace _5EOpen.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {

        bool _canNavigate = true;

        public bool CanNavigate
        {
            get { return _canNavigate; }
            set
            {
                _canNavigate = value;
                OnPropertyChanged();
            }
        }

        public Func<object,bool> AllowNavigationObj => (object arg) =>
        {
           return CanNavigate;
        };

        public Func<bool> AllowNavigation => () =>
        {
            return CanNavigate;
        };

        #region Navigation

        public virtual void GoBack()
        {
            Shell.Current.Navigation.PopAsync();
            //add counter as param? Could use "PopPage(count)" function
        }

        public async Task PushToPage(Page page)
        {
            await Shell.Current.Navigation.PushAsync(page);
            //maybe look into a navigation helper here
        }

        public void PushModal(Page page, bool isAnimated = false)
        {
            Shell.Current.Navigation.PushModalAsync(page, isAnimated);
            //does this need to be async?
        }

        public void PopModal(bool isAnimated = false)
        {
            Shell.Current.Navigation.PopModalAsync(isAnimated);
            //does this need to be async?
        }

        //switch to tab?

        public void DisplayAlert(string title, string message, string cancel)
        {
            Shell.Current.DisplayAlert(title, message, cancel);
            //does this need to be awaited? maybe neer a modal helper
        }

        public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            return await Shell.Current.DisplayAlert(title, message, accept, cancel);
            //modal helper?
        }
        #endregion

        #region Commands

        public ICommand GoBackCommand => new Command(GoBack); //TODO: add counter as param? Could use "PopPage(count)" function

        #endregion

    }
}
