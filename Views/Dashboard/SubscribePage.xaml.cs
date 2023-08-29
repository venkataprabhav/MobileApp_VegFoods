namespace VegFoods.Views.Dashboard;

public partial class SubscribePage : ContentPage
{
	public SubscribePage(SubscribeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}