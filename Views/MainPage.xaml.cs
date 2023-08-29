using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Text;
using VegFoods.Data;
using VegFoods.Models;




namespace VegFoods.Views;

public partial class MainPage : ContentPage
{
    //public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

    public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>(); // user table
	public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
                
        // TODO only do this when app first runs        
    }
}
