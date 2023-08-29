namespace VegFoods.Views;

public partial class RegisterPage : ContentPage
{
    public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
    public RegisterPage(RegisterViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}