using VegFoods.Views.Dashboard;

namespace VegFoods;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
		
		Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        //Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
        Routing.RegisterRoute(nameof(MapPage), typeof(MapPage));
    }
}
