using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ZhoskaRabotaem.ViewModels;
using ZhoskaRabotaem.Models;

namespace ZhoskaRabotaem.Views;

public partial class AddeditWindow : Window
{
    public AddeditWindow()
    {
        InitializeComponent();
    }
    
    private void AddButton_Click(object sender, RoutedEventArgs e) 
    { 
        string productName = ProductBox.Text; 
        string description = DescBox.Text; 
        int price = int.Parse(PriceBox.Text);
 
        
        Product newProduct = new Product 
        { 
            product_name = productName, 
            description = description, 
            price = price 
        };

        MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            
        mainWindowViewModel.AddProduct(newProduct); 
    }

    private void Addprod(object sender, RoutedEventArgs e)
    {
        Hide();
    }
}