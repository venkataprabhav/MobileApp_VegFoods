using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using VegFoods.Models;

namespace VegFoods.Data
{
    public class UserRepository
    {
        private readonly SQLiteConnection _database;

        public static string dbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "vf.db"); // database path set to vf.db

        public UserRepository()
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<User>();  // creates user table
        }

        public List<User> List()
        {
            return _database.Table<User>().ToList();    // details 
        }
    }
}
