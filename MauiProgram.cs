using VegFoods.ViewModels.Dashboard;
using VegFoods.Views.Dashboard;

namespace VegFoods;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<MapViewModel>();

		builder.Services.AddSingleton<MapPage>();

		builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<DashboardPageViewModel>();

        builder.Services.AddSingleton<LoadPage>();
        builder.Services.AddSingleton<LoadPageViewModel>();

        builder.Services.AddSingleton<RegisterPage>();
        builder.Services.AddSingleton<RegisterViewModel>();

        builder.Services.AddSingleton<MenuPage>();
        builder.Services.AddSingleton<MenuViewModel>();
        builder.Services.AddSingleton<MenuService>();

        builder.Services.AddSingleton<SubscribePage>();
        builder.Services.AddSingleton<SubscribeViewModel>();



        return builder.Build();
	}
}
