using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using System;
using System.Runtime.CompilerServices;
using ZhoskaRabotaem.ViewModels;

namespace ZhoskaRabotaem.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ((MainWindowViewModel)DataContext).InitializeData();


    }
    public MainWindow(bool Role)
    {
        if (Role)
        {
            InitializeComponent();
            RoleBlock.Text = "Админ";
            AddMenu.IsVisible = true;
            ((MainWindowViewModel)DataContext).InitializeData();
        }
    }

    private void ButtonSpinner_Spin(object? sender, Avalonia.Controls.SpinEventArgs e){
        ButtonSpinner spinner = sender as ButtonSpinner;
        
        int value = Convert.ToInt32(spinner.Content);
        
        if (e.Direction == SpinDirection.Increase)  
            value++;
        else if (e.Direction == SpinDirection.Decrease && value == 0) 
            return;
        else     
            value--;
        
        spinner.Content = value;
    }

    private void Addmenu(object sender, RoutedEventArgs e)
    {
        var win = new AddeditWindow();
        win.Show();
    }
}