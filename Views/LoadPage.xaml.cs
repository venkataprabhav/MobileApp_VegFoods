namespace VegFoods.Views;

public partial class LoadPage : ContentPage
{
	public LoadPage(LoadPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}