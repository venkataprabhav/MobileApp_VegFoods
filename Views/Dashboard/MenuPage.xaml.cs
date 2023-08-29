namespace VegFoods.Views.Dashboard;

public partial class MenuPage : ContentPage
{
    public MenuPage(MenuViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}