using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegFoods.Models
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);      // makes connection to vf.db
            _database.CreateTableAsync<User>();     // makes user table
            
            
            //_database.CreateTableAsync<Menu>();     

             var newUser = new User { Email = "s@gmail.com", Password = "ad" };  // inserts first email and password (only once) 
             _database.InsertAsync(newUser);

            
            
            //var newMenu = new Menu { Title = "Veg Biryani", Description = "Prepared with fragrant basmati rice, vegetables, flavorful spices, and occasionally nuts and dried fruits.", Image = "veg_biryani.png" };
            //var newMenu2 = new Menu { Title = "Bean Burger", Description = "A vegan burger prepared with mashed black beans, kidney beans, vegetables, and different seasonings.", Image = "bean_burger.png" };
            //var newMenu3 = new Menu { Title = "Vegetarian Sandwich", Description = "A vegetarian sandwich prepared with cheese, tomatoes, avocados and peppers.", Image = "veg_sandwich.png" };
            //var newMenu4 = new Menu { Title = "Vegan Momos", Description = "A type of dumpling originating from China. The dough of the momos is made of flour and water, and its filling with consists of ginger, cumin, garlic and cilantro.", Image = "vegan_momos.png" };

            //_database.InsertAsync(newMenu);
            //_database.InsertAsync(newMenu2);
            //_database.InsertAsync(newMenu3);
           // _database.InsertAsync(newMenu4);
        }

        
        public Task<List<User>> GetUsersAsync()     // retrieves user details from database
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<List<User>> GetEmailAsync(string email) // retrieves user emails from database
        {
            return _database.Table<User>().Where(u  => u.Email == email).ToListAsync();
        }

        public Task<int> AddUsersAsync(User user)       // adds new user details to database
        {
            return _database.InsertAsync(user);
        }

        //public Task<List<Menu>> GetMenuAsync()
        //{
        //     return _database.Table<Menu>().ToListAsync();
        //}

        
    }
}
