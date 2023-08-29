namespace VegFoods;

public partial class App : Application

{

    public static User UserDetails;

    public static Menu menu;


    private static Database database;

    public static Database Database
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "kos.db3"));
            }

            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override void OnStart()
    {

    }

    protected override void OnSleep()
    {

    }

    protected override void OnResume()
    {

    }
}
