using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegFoods.Views.Dashboard;
using VegFoods.Models;
using System.Security.Cryptography.X509Certificates;
using VegFoods.Services;

namespace VegFoods.ViewModels
{
    public partial class MenuViewModel : BaseViewModel
    {
        MenuService menuService;

        public ObservableCollection<Menu> Menus { get; } = new();

        public MenuViewModel(MenuService menuService)
        {
            Title = "Menu";
            this.menuService = menuService;
            GetMenuAsync(); // shows menu on Menu PAge
        }

        [RelayCommand]
        public async Task GetMenuAsync() // retrieves menu items
        {
            try
            {
                var menus = await menuService.GetMenu();

                if (Menus.Count != 0)
                    Menus.Clear();

                foreach (var menu in menus) // adds item to menu
                    Menus.Add(menu);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", "Nothing in Menu", "OK");
            }

        }

        

        
    }
}
