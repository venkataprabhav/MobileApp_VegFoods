using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegFoods.Services
{
    public class MenuService
    {
        HttpClient httpClient;
        public MenuService()
        {
            this.httpClient = new HttpClient();
        }

        List<Menu> menuList;
        public async Task<List<Menu>> GetMenu()
        {
            if (menuList?.Count > 0)
                return menuList;

            
            //var menuPath = "menu.json";

            using var stream = await FileSystem.OpenAppPackageFileAsync("menu.json");

            using var reader = new StreamReader(stream);

            var contents = await reader.ReadToEndAsync();

            menuList = JsonSerializer.Deserialize<List<Menu>>(contents);

            return menuList;
        }
    }

    
}
