
using System.Collections.ObjectModel;
using ZhoskaRabotaem.Context;
using ZhoskaRabotaem.Models;
using ZhoskaRabotaem.ViewModels;

namespace ZhoskaRabotaem.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindowViewModel()
        {
            InitializeData();
        }

        public void InitializeData()
        {
            using (var context = new DimaserjioContext())
            {
                Products = new ObservableCollection<Product>(context.Products);
            }
        }
    }
}
