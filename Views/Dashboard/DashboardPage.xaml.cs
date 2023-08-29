using VegFoods.ViewModels.Dashboard;

namespace VegFoods.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}