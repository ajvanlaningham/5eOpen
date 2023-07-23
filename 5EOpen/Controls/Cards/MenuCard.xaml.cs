using _5EOpen.ViewModels.Controls;

namespace _5EOpen.Controls.Cards;

public partial class MenuCard : ContentView
{
	public MenuCard(string title, Command tapCommand, string icon = "")
	{
		InitializeComponent();
		BindingContext = new MenuCardViewModel(title, tapCommand, icon);
	}
}