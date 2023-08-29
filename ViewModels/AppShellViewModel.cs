using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegFoods.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]
        async void SignOut()        // function for if user closes app while logged in, doesn't need to relogin unless they sign out
        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails));    
            }
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");  // takes user to login page
        }
    }
}
