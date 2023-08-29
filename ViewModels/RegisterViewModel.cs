using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegFoods.ViewModels
{
    public partial class RegisterViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        #region Commands

        [RelayCommand]
        async void Register() // command to register new user
        {
            if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password)) // checks if email and password fields are filled
            {
                try
                {
                    var registeredUsers = await App.Database.GetEmailAsync(Email); // retrieves data from database to see if someone with the same email has already registered.
                    if (registeredUsers.Any())
                    {
                        await Shell.Current.DisplayAlert("Error", "User already Registered!", "OK"); // if email present, error raised
                    }
                    else
                    {
                        var user = new User
                        {
                            Email = Email,
                            Password = Password
                        };

                        // adds new user's details to the database
                        await App.Database.AddUsersAsync(user);

                        var users = await App.Database.GetUsersAsync(); // retrieves data from database



                        var user2 = users.FirstOrDefault(u => u.Email == Email && u.Password == Password); // checks the retrieved data to see whether the database added the new users information.

                        // Check if the new users information exists
                        if (user2 != null)
                        {
                            // Navigates to Log In page
                            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                        }
                        else
                        {
                            // Display error message
                            await Shell.Current.DisplayAlert("Error", "error", "OK");
                        }
                    }
                }
                catch (Exception ex) // raises error if something wrong
                {
                    await Shell.Current.DisplayAlert("Error!", "Error", "OK");
                }
            }
        }

        #endregion
    }
}
