using Avalonia.Controls;
using Avalonia.Controls.Primitives;
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
            ((MainWindowViewModel)DataContext).InitializeData();
        }
    }
}