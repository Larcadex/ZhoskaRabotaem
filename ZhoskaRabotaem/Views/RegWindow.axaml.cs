using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace ZhoskaRabotaem.Views;

public partial class RegWindow : Window
{
    public bool IsAdmin;
    public RegWindow()
    {
        InitializeComponent();
    }
    
    private void Signin_click(object sender, RoutedEventArgs e)
    {
        if (CodeTextBox.Text == "0000")
        {
            IsAdmin = true;
            var win = new MainWindow(IsAdmin);
            win.Show();

        }
        else
        {
            var win = new MainWindow();
            win.Show();

        }
    
   
        this.Close();
        
        
        
    }
}