using Microsoft.Maui.ApplicationModel.Communication;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using VegFoods.Views;
using VegFoods.Views.Dashboard;
using VegFoods.Models;

namespace VegFoods.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _password;

    #region Commands

    [RelayCommand]
    async void Login()
    {
        if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))     // checks if email and password fields are filled
        {
            // Retrieves user information from the database
            var users = await App.Database.GetUsersAsync();


            // Comparing the entered email and password 
            var user = users.FirstOrDefault(u => u.Email == Email && u.Password == Password);

            // Checking if such a user exists
            if (user != null)
            {
                // Logs In by going to the Dashboard
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Invalid email or password", "OK");
            }
        }
    }

    [RelayCommand]
    async void GoRegister()     // leads to register page
    {
        await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
    }

    #endregion
}

