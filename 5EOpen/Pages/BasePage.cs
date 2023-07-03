using _5EOpen.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.Pages
{
    public partial class BasePage : ContentPage
    {

        public enum ButtonType { TextOnly, IconOnly, TextAndIcon };

        public BasePage()
        {

        }

        //To deal with the iPhone safe-area spaces, there's a helper class that sorts through all that junk
        public RowDefinitionCollection RowDefinitions
        {
            get
            {
                if (DeviceModeHelper.UsesSafeArea())
                {
                    return new RowDefinitionCollection
                    {
                        new RowDefinition { Height = new GridLength(44) },
                        new RowDefinition { Height = new GridLength(60) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                    };
                }
                else
                {
                    return new RowDefinitionCollection
                    {
                        new RowDefinition { Height = new GridLength(0)},
                        new RowDefinition { Height = new GridLength(60)},
                        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)},
                        new RowDefinition { Height = new GridLength (1, GridUnitType.Star) }
                    };
                }
            }
        }

       
        //Bindable properties that can be set with the creation of every new page
        /// <summary>
        /// 
        /// </summary>
        public static readonly BindableProperty ShowLeftButtonProperty =
            BindableProperty.Create(nameof(ShowLeftButton),
                returnType: typeof(bool),
                declaringType: typeof(BasePage),
                defaultValue: false,
                defaultBindingMode: BindingMode.OneWay,
                validateValue: null,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    (bindable as BasePage).ShowLeftButton = (bool)newValue;
                });

        public static readonly BindableProperty LeftButtonTypeProperty =
         BindableProperty.Create(nameof(LeftButtonType),
             returnType: typeof(ButtonType),
             declaringType: typeof(BasePage),
             defaultValue: ButtonType.IconOnly,
             defaultBindingMode: BindingMode.OneWay,
             validateValue: null,
             propertyChanged: (bindable, oldValue, newValue) =>
             {
                 (bindable as BasePage).LeftButtonType = (ButtonType)newValue;
             });

        public bool ShowLeftButton
        {
            get { return (bool)GetValue(ShowLeftButtonProperty);}
            set
            {
                SetValue(ShowLeftButtonProperty, value);
                OnPropertyChanged(nameof(ShowLeftTextButton));
                OnPropertyChanged(nameof(ShowLeftIconButton));
                OnPropertyChanged(nameof(ShowLeftTextAndIconButton));
            }
        }

        public bool ShowLeftTextButton => ShowLeftButton && LeftButtonType == ButtonType.TextOnly;
        public bool ShowLeftIconButton => ShowLeftButton && LeftButtonType == ButtonType.IconOnly;
        public bool ShowLeftTextAndIconButton => ShowLeftButton && LeftButtonType == ButtonType.TextAndIcon;

        public ButtonType LeftButtonType
        {
            get { return (ButtonType)GetValue(LeftButtonTypeProperty); }
            set
            {
                SetValue (LeftButtonTypeProperty, value);
                OnPropertyChanged(nameof(ShowLeftButton));
                OnPropertyChanged(nameof(ShowLeftIconButton));
                OnPropertyChanged(nameof (ShowLeftTextAndIconButton));
            }
        }

    }
}
