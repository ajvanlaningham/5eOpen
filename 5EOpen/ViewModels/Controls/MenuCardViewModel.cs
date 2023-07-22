using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.ViewModels.Controls
{
    public class MenuCardViewModel : ViewModelBase
    {
        public MenuCardViewModel(string title, Command tapCommand, string icon = "")
        {
            MenuTitle = title;
            TapCommand = tapCommand;
            MenuIcon = icon;
        }

        public bool HasIcon => !string.IsNullOrEmpty(MenuIcon);
        public string MenuTitle { get; set; }
        public string MenuIcon { get; set; }
        public Command TapCommand { get; set; }
    }
}
