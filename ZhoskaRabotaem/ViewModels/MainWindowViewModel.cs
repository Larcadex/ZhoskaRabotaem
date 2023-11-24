
using System.Collections.ObjectModel;
using ZhoskaRabotaem.Context;
using ZhoskaRabotaem.Models;
using ZhoskaRabotaem.ViewModels;

namespace ZhoskaRabotaem.ViewModels
{
    public class MainWindowViewModel : ViewModelBase 
    { 
        private ObservableCollection<Product> _products; 
        public ObservableCollection<Product> Products 
        { 
            get => _products; 
            set => _products = value; 
        } 

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
        
        public void AddProduct(Product newProduct) 
        { 
            Products.Add(newProduct);
            InitializeData();
        }
    }
}
