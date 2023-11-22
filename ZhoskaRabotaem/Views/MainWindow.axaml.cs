using Avalonia.Controls;

namespace ZhoskaRabotaem.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        RoleBlock.Text = "Kent";
    }
    public MainWindow(bool Role)
    {
        if (Role)
        {
            InitializeComponent();
            RoleBlock.Text = "Admin";
        }
    }
}