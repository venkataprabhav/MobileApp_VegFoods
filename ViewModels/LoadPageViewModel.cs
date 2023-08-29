using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegFoods.Views.Dashboard;

namespace VegFoods.ViewModels
{
    public class LoadPageViewModel
    {
        public LoadPageViewModel()
        {
            CheckUserLoginDetails();    // checks login details
        }

        private async void CheckUserLoginDetails()
        {
            string strUserDetails = Preferences.Get(nameof(App.UserDetails), "");

            if (string.IsNullOrWhiteSpace(strUserDetails))
            {
                // navigates user to login page
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<User>(strUserDetails); // deserializes user information
                App.UserDetails = userInfo;
                
                
                // navigates user to dashboard
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
        }
    }
}
