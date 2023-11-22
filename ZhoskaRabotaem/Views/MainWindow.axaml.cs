using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace ZhoskaRabotaem.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public MainWindow(bool Role)
    {
        if (Role)
        {
            InitializeComponent();
        }
    }
}